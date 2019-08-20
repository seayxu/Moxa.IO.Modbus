using System;

namespace Moxa.IO.Modbus.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello ");
            bool connected = false;

            RemoteInputOutputClient client = new RemoteInputOutputClient("192.168.2.101")
            {
                OnException = (ex) => { Console.WriteLine($"{ex.Message}"); },
                OnConnectChanged = (b) => { connected = b; Console.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")} / Connected:{b}"); },
                OnInputReceived = (bs) =>
                {
                    Console.WriteLine($"{DateTime.Now.ToString("HH:mm:ss.fff")} / I:{string.Join(" ", bs)} / {connected}");
                },
                OnOutputReceived = (bs) =>
                {
                    Console.WriteLine($"{DateTime.Now.ToString("HH:mm:ss.fff")} / O:{string.Join(" ", bs)} / {connected}");
                }
            };
            client.Start();
            client.BeginStatusListener();
            
            string cmd = null;

            do
            {
                cmd = Console.ReadLine();

                if (cmd == null) continue;

                string[] str = cmd.Split(' ');
                if (str.Length != 2) continue;

                if (!ushort.TryParse(str[0], out ushort ch)) continue;

                client.SetOutput(ch, str[1] == "1" ? true : false);

            } while (cmd != "q");

            client.EndListener();
            client.Stop();
        }
    }
}
