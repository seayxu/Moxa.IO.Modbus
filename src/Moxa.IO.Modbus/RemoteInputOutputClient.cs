using NModbus;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace Moxa.IO.Modbus
{
    public class RemoteInputOutputClient
    {
        public string Host { get; set; }
        public int Port { get; set; } = 502;

        public bool Running { get; private set; }

        public int DelayTime { get; set; } = 200;
        public Action<Exception> OnException { get; set; }
        public Action<bool> OnConnectChanged { get; set; }
        public Action<bool[]> OnOutputReceived { get; set; }
        public Action<bool[]> OnInputReceived { get; set; }
        public byte SlaveAddress { get; set; } = 1;
        public ushort InputStartAddress { get; set; } = 0;
        public ushort InputChannelNumber { get; set; } = 16;
        public ushort OutputStartAddress { get; set; } = 0;
        public ushort OutputChannelNumber { get; set; } = 8;

        private bool connected { get; set; } = false;

        IModbusMaster master = null;
        bool initialized = false;

        Task statusTask = null;
        CancellationTokenSource statusToken = null;
        TcpClient tcp = null;

        public RemoteInputOutputClient()
        {
            Running = false;
        }

        public RemoteInputOutputClient(string host, int port = 502) : this()
        {
            Host = host;
            Port = port;

            Initialize();
        }

        public void Initialize()
        {
            tcp = new TcpClient(Host, Port);
            master = new ModbusFactory().CreateMaster(tcp);
            initialized = true;
        }

        public void CreateClient()
        {
            try
            {
                tcp = new TcpClient(Host, Port);
                master = new ModbusFactory().CreateMaster(tcp);
            }
            catch (Exception ex)
            {
                OnException?.Invoke(ex);
            }
        }

        public void Start()
        {
            if (!initialized) Initialize();
            connected = false;
            Running = true;
        }

        public void BeginListener()
        {
            BeginStatusListener();
        }

        private void BeginStatusListener()
        {
            statusToken = new CancellationTokenSource();
            statusTask = Task.Factory.StartNew(StatusLoop, statusToken.Token, TaskCreationOptions.LongRunning, TaskScheduler.Default);
        }

        private async void StatusLoop()
        {
            try
            {
                Dictionary<string, DateTime> exceptions = new Dictionary<string, DateTime>();
                bool connected = false;

                while (!statusToken.IsCancellationRequested && Running)
                {
                    try
                    {
                        this.connected = tcp.Client.IsConnected();

                        if (connected != this.connected)
                        {
                            connected = this.connected;
                            OnConnectChanged?.Invoke(this.connected);
                        }

                        if (!this.connected)
                        {
                            using (Ping ping = new Ping())
                            {
                                PingReply reply = ping.Send(Host);

                                if (reply.Status == IPStatus.Success) CreateClient();
                            }

                            continue;
                        }
                        
                        OnOutputReceived?.Invoke(GetOutput(OutputStartAddress, OutputChannelNumber));

                        OnInputReceived?.Invoke(GetInput(InputStartAddress,InputChannelNumber));
                    }
                    catch (Exception ex)
                    {
                        bool writable = false;
                        if (!exceptions.ContainsKey(ex.Message))
                        {
                            exceptions.Add(ex.Message, DateTime.Now);
                            writable = true;
                        }
                        else
                        {
                            if ((DateTime.Now - exceptions[ex.Message]) < TimeSpan.FromSeconds(60)) continue;

                            exceptions[ex.Message] = DateTime.Now;
                            writable = true;
                        }

                        if (writable) OnException?.Invoke(ex);
                    }
                    finally
                    {
                        if (!statusToken.IsCancellationRequested && Running) await Task.Delay(DelayTime);
                    }
                }
            }
            catch (OperationCanceledException) { }
            catch (Exception ex)
            {
                OnException?.Invoke(ex);
            }

            if (Running) BeginStatusListener();
        }
        
        public void EndListener()
        {
            try
            {
                statusToken?.Cancel();
            }
            catch (Exception ex)
            {
                OnException?.Invoke(ex);
            }
        }

        public void Stop()
        {
            Running = false;
            EndListener();
            connected = false;
        }

        public void SetOutput(ushort ch, bool val)
        {
            try
            {
                master.WriteSingleCoil(SlaveAddress, ch, val);
            }
            catch (Exception ex)
            {
                OnException?.Invoke(ex);
            }
        }

        public bool[] GetOutput(ushort ch = 0, ushort num = 8)
        {
            try
            {
                return master.ReadCoils(SlaveAddress, ch, num);
            }
            catch (Exception ex)
            {
                OnException?.Invoke(ex);
                return null;
            }
        }

        public bool[] GetInput(ushort ch = 0, ushort num = 16)
        {
            try
            {
                return master.ReadInputs(SlaveAddress, ch, num);
            }
            catch (Exception ex)
            {
                OnException?.Invoke(ex);
                return null;
            }
        }
    }
}
