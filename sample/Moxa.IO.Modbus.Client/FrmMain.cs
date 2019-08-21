using System;
using System.Drawing;
using System.Windows.Forms;

namespace Moxa.IO.Modbus.Client
{
    public partial class FrmMain : Form
    {
        delegate void ControlChangedHandler<T>(T t);

        Label[] iLabels = null;
        Label[] oLabels = null;
        bool connected = false;
        RemoteInputOutputClient client = null;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            SetOutputViews();
            SetInputViews();
        }

        private void SetOutputViews()
        {
            oLabels = new Label[(int)this.nudOutputChannelNumber.Value];
            InitializeStatusViews(ref oLabels, "O");

            this.flpOutput.Controls.Clear();
            this.flpOutput.Controls.AddRange(oLabels);
        }

        private void SetInputViews()
        {
            iLabels = new Label[(int)this.nudInputChannelNumber.Value];
            InitializeStatusViews(ref iLabels, "I");

            this.flpInput.Controls.Clear();
            this.flpInput.Controls.AddRange(iLabels);
        }

        private void InitializeStatusViews(ref Label[] labels, string prefix)
        {
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i] = new Label() { Name = $"{prefix}.{i.ToString("X2")}", Text = $"{prefix}:{i.ToString("X2")}", Margin = new Padding(1), ForeColor = Color.White, AutoSize = false, Size = new Size(35, 24), TextAlign = ContentAlignment.MiddleCenter, BackColor= Color.Gray };
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (client == null)
                {
                    client = new RemoteInputOutputClient(this.tbHost.Text.Trim())
                    {
                        OnException = (ex) => { Console.WriteLine($"{ex.Message}"); },
                        OnConnectChanged = (b) => 
                        {
                            connected = b;
                            Console.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")} / Connected:{b}");
                            RemoteInputOutputConnectChangedHandler(b);
                        },
                        OnInputReceived = (bs) =>
                        {
                            Console.WriteLine($"{DateTime.Now.ToString("HH:mm:ss.fff")} / I:{string.Join(" ", bs)} / {connected}");
                            RemoteDiStatusHandler(bs);
                        },
                        OnOutputReceived = (bs) =>
                        {
                            Console.WriteLine($"{DateTime.Now.ToString("HH:mm:ss.fff")} / O:{string.Join(" ", bs)} / {connected}");
                            RemoteDoStatusHandler(bs);
                        }
                    };
                }

                if(client.Running)
                {
                    client.EndListener();
                    client.Stop();
                }
                else
                {
                    client.Start();
                    client.BeginListener();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SetOutputViews();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SetInputViews();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                client?.SetOutput((ushort)nudChannelAddress.Value, cbValue.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RemoteDoStatusHandler(bool[] bs)
        {
            this.BeginInvoke(new Action<bool[]>((p) =>
            {
                try
                {
                    for (int i = 0; i < p.Length; i++)
                    {
                        if (i < oLabels.Length) SetIoStatus(oLabels[i], p[i]);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }), bs);
        }

        private void RemoteDiStatusHandler(bool[] bs)
        {
            this.BeginInvoke(new Action<bool[]>((p) =>
            {
                try
                {
                    for (int i = 0; i < p.Length; i++)
                    {
                        if (i < iLabels.Length) SetIoStatus(iLabels[i], p[i]);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }), bs);
        }

        private void RemoteInputOutputConnectChangedHandler(bool b)
        {
            this.BeginInvoke(new Action<bool>((p) =>
            {
                try
                {
                    btnConnect.Text = p ? "Stop" : "Start";
                    btnConnect.BackColor = p ? Color.Green : Color.Red;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }), b);
        }

        private void SetIoStatus(Control control, bool ret)
        {
            control.BackColor = ret ? Color.LimeGreen : Color.Silver;
        }
    }
}
