namespace Moxa.IO.Modbus.Client
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudOutputStartAddress = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudOutputChannelNumber = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudInputChannelNumber = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudInputStartAddress = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.flpOutput = new System.Windows.Forms.FlowLayoutPanel();
            this.flpInput = new System.Windows.Forms.FlowLayoutPanel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.nudChannelAddress = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.cbValue = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutputStartAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutputChannelNumber)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInputChannelNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInputStartAddress)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChannelAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.tbHost);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Moxa IO Paramters";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host:";
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(101, 19);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(120, 20);
            this.tbHost.TabIndex = 1;
            this.tbHost.Text = "192.168.127.254";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.nudOutputChannelNumber);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nudOutputStartAddress);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 81);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output Paramters";
            // 
            // nudOutputStartAddress
            // 
            this.nudOutputStartAddress.Location = new System.Drawing.Point(101, 19);
            this.nudOutputStartAddress.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudOutputStartAddress.Name = "nudOutputStartAddress";
            this.nudOutputStartAddress.Size = new System.Drawing.Size(120, 20);
            this.nudOutputStartAddress.TabIndex = 4;
            this.nudOutputStartAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Start Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Channel Number:";
            // 
            // nudOutputChannelNumber
            // 
            this.nudOutputChannelNumber.Location = new System.Drawing.Point(101, 45);
            this.nudOutputChannelNumber.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudOutputChannelNumber.Name = "nudOutputChannelNumber";
            this.nudOutputChannelNumber.Size = new System.Drawing.Size(120, 20);
            this.nudOutputChannelNumber.TabIndex = 4;
            this.nudOutputChannelNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudOutputChannelNumber.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.nudInputChannelNumber);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.nudInputStartAddress);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 81);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Input Paramters";
            // 
            // nudInputChannelNumber
            // 
            this.nudInputChannelNumber.Location = new System.Drawing.Point(101, 45);
            this.nudInputChannelNumber.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudInputChannelNumber.Name = "nudInputChannelNumber";
            this.nudInputChannelNumber.Size = new System.Drawing.Size(120, 20);
            this.nudInputChannelNumber.TabIndex = 4;
            this.nudInputChannelNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudInputChannelNumber.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Channel Number:";
            // 
            // nudInputStartAddress
            // 
            this.nudInputStartAddress.Location = new System.Drawing.Point(101, 19);
            this.nudInputStartAddress.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudInputStartAddress.Name = "nudInputStartAddress";
            this.nudInputStartAddress.Size = new System.Drawing.Size(120, 20);
            this.nudInputStartAddress.TabIndex = 4;
            this.nudInputStartAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Start Address:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbValue);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.nudChannelAddress);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(12, 245);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(308, 69);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Actions";
            // 
            // flpOutput
            // 
            this.flpOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpOutput.Location = new System.Drawing.Point(12, 320);
            this.flpOutput.Name = "flpOutput";
            this.flpOutput.Size = new System.Drawing.Size(308, 55);
            this.flpOutput.TabIndex = 2;
            // 
            // flpInput
            // 
            this.flpInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpInput.Location = new System.Drawing.Point(12, 381);
            this.flpInput.Name = "flpInput";
            this.flpInput.Size = new System.Drawing.Size(308, 55);
            this.flpInput.TabIndex = 2;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(233, 17);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(69, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Start";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Apply";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Channel Address:";
            // 
            // nudChannelAddress
            // 
            this.nudChannelAddress.Location = new System.Drawing.Point(101, 19);
            this.nudChannelAddress.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudChannelAddress.Name = "nudChannelAddress";
            this.nudChannelAddress.Size = new System.Drawing.Size(120, 20);
            this.nudChannelAddress.TabIndex = 4;
            this.nudChannelAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(233, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Apply";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbValue
            // 
            this.cbValue.AutoSize = true;
            this.cbValue.Location = new System.Drawing.Point(101, 45);
            this.cbValue.Name = "cbValue";
            this.cbValue.Size = new System.Drawing.Size(43, 17);
            this.cbValue.TabIndex = 5;
            this.cbValue.Text = "0/1";
            this.cbValue.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 447);
            this.Controls.Add(this.flpInput);
            this.Controls.Add(this.flpOutput);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoxaIOModbusClient";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutputStartAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOutputChannelNumber)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInputChannelNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInputStartAddress)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChannelAddress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudOutputStartAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudOutputChannelNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nudInputChannelNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudInputStartAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.FlowLayoutPanel flpOutput;
        private System.Windows.Forms.FlowLayoutPanel flpInput;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown nudChannelAddress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox cbValue;
    }
}

