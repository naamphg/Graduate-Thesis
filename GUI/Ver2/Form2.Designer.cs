namespace Ver2
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.TabSet = new System.Windows.Forms.TabControl();
            this.SetSerial = new System.Windows.Forms.TabPage();
            this.BtAppSerial = new System.Windows.Forms.Button();
            this.CbCOM = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbParity = new System.Windows.Forms.ComboBox();
            this.CbStopB = new System.Windows.Forms.ComboBox();
            this.CbDataB = new System.Windows.Forms.ComboBox();
            this.CbBaud = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SetControl = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.BtSetS = new System.Windows.Forms.Button();
            this.TbSpeed2 = new System.Windows.Forms.TextBox();
            this.TbSpeed1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabCalib = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btSetCalib = new System.Windows.Forms.Button();
            this.CLD1 = new System.Windows.Forms.TextBox();
            this.CLT3 = new System.Windows.Forms.TextBox();
            this.CLT2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TabSet.SuspendLayout();
            this.SetSerial.SuspendLayout();
            this.SetControl.SuspendLayout();
            this.tabCalib.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabSet
            // 
            this.TabSet.Controls.Add(this.SetSerial);
            this.TabSet.Controls.Add(this.SetControl);
            this.TabSet.Controls.Add(this.tabCalib);
            this.TabSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabSet.Location = new System.Drawing.Point(7, 5);
            this.TabSet.Name = "TabSet";
            this.TabSet.SelectedIndex = 0;
            this.TabSet.Size = new System.Drawing.Size(219, 320);
            this.TabSet.TabIndex = 0;
            // 
            // SetSerial
            // 
            this.SetSerial.Controls.Add(this.BtAppSerial);
            this.SetSerial.Controls.Add(this.CbCOM);
            this.SetSerial.Controls.Add(this.label5);
            this.SetSerial.Controls.Add(this.CbParity);
            this.SetSerial.Controls.Add(this.CbStopB);
            this.SetSerial.Controls.Add(this.CbDataB);
            this.SetSerial.Controls.Add(this.CbBaud);
            this.SetSerial.Controls.Add(this.label4);
            this.SetSerial.Controls.Add(this.label3);
            this.SetSerial.Controls.Add(this.label2);
            this.SetSerial.Controls.Add(this.label1);
            this.SetSerial.Location = new System.Drawing.Point(4, 24);
            this.SetSerial.Name = "SetSerial";
            this.SetSerial.Padding = new System.Windows.Forms.Padding(3);
            this.SetSerial.Size = new System.Drawing.Size(211, 292);
            this.SetSerial.TabIndex = 0;
            this.SetSerial.Text = "Cổng COM";
            this.SetSerial.UseVisualStyleBackColor = true;
            // 
            // BtAppSerial
            // 
            this.BtAppSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAppSerial.Location = new System.Drawing.Point(104, 242);
            this.BtAppSerial.Name = "BtAppSerial";
            this.BtAppSerial.Size = new System.Drawing.Size(76, 35);
            this.BtAppSerial.TabIndex = 1;
            this.BtAppSerial.Text = "Apply";
            this.BtAppSerial.UseVisualStyleBackColor = true;
            this.BtAppSerial.Click += new System.EventHandler(this.BtAppSerial_Click);
            // 
            // CbCOM
            // 
            this.CbCOM.FormattingEnabled = true;
            this.CbCOM.Items.AddRange(new object[] {
            "none",
            "even",
            "odd",
            "mark"});
            this.CbCOM.Location = new System.Drawing.Point(104, 24);
            this.CbCOM.Name = "CbCOM";
            this.CbCOM.Size = new System.Drawing.Size(76, 23);
            this.CbCOM.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Port Name";
            // 
            // CbParity
            // 
            this.CbParity.FormattingEnabled = true;
            this.CbParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd",
            "Mark"});
            this.CbParity.Location = new System.Drawing.Point(104, 204);
            this.CbParity.Name = "CbParity";
            this.CbParity.Size = new System.Drawing.Size(76, 23);
            this.CbParity.TabIndex = 7;
            // 
            // CbStopB
            // 
            this.CbStopB.FormattingEnabled = true;
            this.CbStopB.Items.AddRange(new object[] {
            "One",
            "Two",
            "OnePointFive"});
            this.CbStopB.Location = new System.Drawing.Point(104, 157);
            this.CbStopB.Name = "CbStopB";
            this.CbStopB.Size = new System.Drawing.Size(76, 23);
            this.CbStopB.TabIndex = 6;
            // 
            // CbDataB
            // 
            this.CbDataB.FormattingEnabled = true;
            this.CbDataB.Items.AddRange(new object[] {
            "7",
            "8"});
            this.CbDataB.Location = new System.Drawing.Point(104, 112);
            this.CbDataB.Name = "CbDataB";
            this.CbDataB.Size = new System.Drawing.Size(76, 23);
            this.CbDataB.TabIndex = 5;
            // 
            // CbBaud
            // 
            this.CbBaud.FormattingEnabled = true;
            this.CbBaud.Items.AddRange(new object[] {
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.CbBaud.Location = new System.Drawing.Point(104, 67);
            this.CbBaud.Name = "CbBaud";
            this.CbBaud.Size = new System.Drawing.Size(76, 23);
            this.CbBaud.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Parity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "StopBits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "DataBits";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "BauRate";
            // 
            // SetControl
            // 
            this.SetControl.Controls.Add(this.label15);
            this.SetControl.Controls.Add(this.label14);
            this.SetControl.Controls.Add(this.BtSetS);
            this.SetControl.Controls.Add(this.TbSpeed2);
            this.SetControl.Controls.Add(this.TbSpeed1);
            this.SetControl.Controls.Add(this.label7);
            this.SetControl.Controls.Add(this.label6);
            this.SetControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetControl.Location = new System.Drawing.Point(4, 24);
            this.SetControl.Name = "SetControl";
            this.SetControl.Padding = new System.Windows.Forms.Padding(3);
            this.SetControl.Size = new System.Drawing.Size(211, 292);
            this.SetControl.TabIndex = 1;
            this.SetControl.Text = "Tốc độ";
            this.SetControl.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(166, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 15);
            this.label15.TabIndex = 9;
            this.label15.Text = "rpm";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(166, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 15);
            this.label14.TabIndex = 8;
            this.label14.Text = "rpm";
            // 
            // BtSetS
            // 
            this.BtSetS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSetS.Location = new System.Drawing.Point(85, 105);
            this.BtSetS.Name = "BtSetS";
            this.BtSetS.Size = new System.Drawing.Size(76, 35);
            this.BtSetS.TabIndex = 6;
            this.BtSetS.Text = "Apply";
            this.BtSetS.UseVisualStyleBackColor = true;
            this.BtSetS.Click += new System.EventHandler(this.BtSetS_Click);
            // 
            // TbSpeed2
            // 
            this.TbSpeed2.Location = new System.Drawing.Point(85, 62);
            this.TbSpeed2.Name = "TbSpeed2";
            this.TbSpeed2.Size = new System.Drawing.Size(75, 21);
            this.TbSpeed2.TabIndex = 4;
            this.TbSpeed2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TbSpeed1
            // 
            this.TbSpeed1.Location = new System.Drawing.Point(85, 20);
            this.TbSpeed1.Name = "TbSpeed1";
            this.TbSpeed1.Size = new System.Drawing.Size(75, 21);
            this.TbSpeed1.TabIndex = 3;
            this.TbSpeed1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Động cơ B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Động cơ A";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tabCalib
            // 
            this.tabCalib.Controls.Add(this.label19);
            this.tabCalib.Controls.Add(this.label20);
            this.tabCalib.Controls.Add(this.label21);
            this.tabCalib.Controls.Add(this.label16);
            this.tabCalib.Controls.Add(this.label17);
            this.tabCalib.Controls.Add(this.label18);
            this.tabCalib.Controls.Add(this.textBox1);
            this.tabCalib.Controls.Add(this.textBox2);
            this.tabCalib.Controls.Add(this.textBox3);
            this.tabCalib.Controls.Add(this.label13);
            this.tabCalib.Controls.Add(this.label12);
            this.tabCalib.Controls.Add(this.label11);
            this.tabCalib.Controls.Add(this.label10);
            this.tabCalib.Controls.Add(this.label9);
            this.tabCalib.Controls.Add(this.label8);
            this.tabCalib.Controls.Add(this.btSetCalib);
            this.tabCalib.Controls.Add(this.CLD1);
            this.tabCalib.Controls.Add(this.CLT3);
            this.tabCalib.Controls.Add(this.CLT2);
            this.tabCalib.Location = new System.Drawing.Point(4, 24);
            this.tabCalib.Name = "tabCalib";
            this.tabCalib.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalib.Size = new System.Drawing.Size(211, 292);
            this.tabCalib.TabIndex = 2;
            this.tabCalib.Text = "HOME";
            this.tabCalib.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(171, 208);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 15);
            this.label19.TabIndex = 18;
            this.label19.Text = "mm";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(170, 171);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 15);
            this.label20.TabIndex = 17;
            this.label20.Text = "mm";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(170, 131);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 15);
            this.label21.TabIndex = 16;
            this.label21.Text = "mm";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(33, 208);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 15);
            this.label16.TabIndex = 15;
            this.label16.Text = "Z";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(32, 171);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 15);
            this.label17.TabIndex = 14;
            this.label17.Text = "Y";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(32, 131);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(15, 15);
            this.label18.TabIndex = 13;
            this.label18.Text = "X";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 205);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 21);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(82, 168);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 21);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(82, 128);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 21);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "279";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(170, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 15);
            this.label13.TabIndex = 9;
            this.label13.Text = "mm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(170, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "deg";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(170, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 15);
            this.label11.TabIndex = 7;
            this.label11.Text = "deg";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "D1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Theta 3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Theta 2";
            // 
            // btSetCalib
            // 
            this.btSetCalib.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSetCalib.Location = new System.Drawing.Point(82, 241);
            this.btSetCalib.Name = "btSetCalib";
            this.btSetCalib.Size = new System.Drawing.Size(76, 35);
            this.btSetCalib.TabIndex = 3;
            this.btSetCalib.Text = "Apply";
            this.btSetCalib.UseVisualStyleBackColor = true;
            this.btSetCalib.Click += new System.EventHandler(this.btSetCalib_Click);
            // 
            // CLD1
            // 
            this.CLD1.Location = new System.Drawing.Point(82, 89);
            this.CLD1.Name = "CLD1";
            this.CLD1.Size = new System.Drawing.Size(76, 21);
            this.CLD1.TabIndex = 2;
            this.CLD1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CLT3
            // 
            this.CLT3.Location = new System.Drawing.Point(82, 52);
            this.CLT3.Name = "CLT3";
            this.CLT3.Size = new System.Drawing.Size(76, 21);
            this.CLT3.TabIndex = 1;
            this.CLT3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CLT2
            // 
            this.CLT2.Location = new System.Drawing.Point(82, 16);
            this.CLT2.Name = "CLT2";
            this.CLT2.Size = new System.Drawing.Size(76, 21);
            this.CLT2.TabIndex = 0;
            this.CLT2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 332);
            this.Controls.Add(this.TabSet);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Cài đặt";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.TabSet.ResumeLayout(false);
            this.SetSerial.ResumeLayout(false);
            this.SetSerial.PerformLayout();
            this.SetControl.ResumeLayout(false);
            this.SetControl.PerformLayout();
            this.tabCalib.ResumeLayout(false);
            this.tabCalib.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage SetSerial;
        private System.Windows.Forms.TabPage SetControl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox TbSpeed2;
        private System.Windows.Forms.TextBox TbSpeed1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TabControl TabSet;
        public System.Windows.Forms.ComboBox CbCOM;
        public System.Windows.Forms.ComboBox CbParity;
        public System.Windows.Forms.ComboBox CbStopB;
        public System.Windows.Forms.ComboBox CbDataB;
        public System.Windows.Forms.ComboBox CbBaud;
        public System.Windows.Forms.Button BtAppSerial;
        public System.Windows.Forms.Button BtSetS;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabCalib;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btSetCalib;
        private System.Windows.Forms.TextBox CLD1;
        private System.Windows.Forms.TextBox CLT3;
        private System.Windows.Forms.TextBox CLT2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}