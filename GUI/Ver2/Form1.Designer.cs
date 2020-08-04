namespace Ver2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtSend = new System.Windows.Forms.Button();
            this.CmdX = new System.Windows.Forms.TextBox();
            this.CmdY = new System.Windows.Forms.TextBox();
            this.CmdZ = new System.Windows.Forms.TextBox();
            this.BtGotoHome = new System.Windows.Forms.Button();
            this.BtAdd = new System.Windows.Forms.Button();
            this.BtStart = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Graph = new ZedGraph.ZedGraphControl();
            this.COM = new System.IO.Ports.SerialPort(this.components);
            this.BtStop = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Rb10 = new System.Windows.Forms.RadioButton();
            this.Rb100 = new System.Windows.Forms.RadioButton();
            this.Rb1000 = new System.Windows.Forms.RadioButton();
            this.PnControl = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbFN = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbD1 = new System.Windows.Forms.TextBox();
            this.tbT3 = new System.Windows.Forms.TextBox();
            this.tbT2 = new System.Windows.Forms.TextBox();
            this.BtSendJ = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtD1De = new System.Windows.Forms.Button();
            this.BtT2De = new System.Windows.Forms.Button();
            this.CmdD1 = new System.Windows.Forms.TextBox();
            this.CmdT3 = new System.Windows.Forms.TextBox();
            this.CmdT2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtD1In = new System.Windows.Forms.Button();
            this.BtT2In = new System.Windows.Forms.Button();
            this.BtT3De = new System.Windows.Forms.Button();
            this.BtT3In = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbZ = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.BtZDe = new System.Windows.Forms.Button();
            this.BtXDe = new System.Windows.Forms.Button();
            this.BtZIn = new System.Windows.Forms.Button();
            this.BtXIn = new System.Windows.Forms.Button();
            this.BtYDe = new System.Windows.Forms.Button();
            this.BtYIn = new System.Windows.Forms.Button();
            this.PnButtons = new System.Windows.Forms.Panel();
            this.BtConnect = new System.Windows.Forms.Button();
            this.BtDrill = new System.Windows.Forms.Button();
            this.btCalib = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PnControl.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PnButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtSend
            // 
            this.BtSend.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSend.Location = new System.Drawing.Point(7, 8);
            this.BtSend.Margin = new System.Windows.Forms.Padding(4);
            this.BtSend.Name = "BtSend";
            this.BtSend.Size = new System.Drawing.Size(50, 127);
            this.BtSend.TabIndex = 92;
            this.BtSend.Text = "IK";
            this.BtSend.UseVisualStyleBackColor = true;
            this.BtSend.Click += new System.EventHandler(this.BtSend_Click);
            // 
            // CmdX
            // 
            this.CmdX.Location = new System.Drawing.Point(267, 15);
            this.CmdX.Margin = new System.Windows.Forms.Padding(4);
            this.CmdX.Name = "CmdX";
            this.CmdX.Size = new System.Drawing.Size(70, 21);
            this.CmdX.TabIndex = 70;
            // 
            // CmdY
            // 
            this.CmdY.Location = new System.Drawing.Point(267, 61);
            this.CmdY.Margin = new System.Windows.Forms.Padding(4);
            this.CmdY.Name = "CmdY";
            this.CmdY.Size = new System.Drawing.Size(70, 21);
            this.CmdY.TabIndex = 71;
            // 
            // CmdZ
            // 
            this.CmdZ.Location = new System.Drawing.Point(267, 107);
            this.CmdZ.Margin = new System.Windows.Forms.Padding(4);
            this.CmdZ.Name = "CmdZ";
            this.CmdZ.Size = new System.Drawing.Size(70, 21);
            this.CmdZ.TabIndex = 72;
            // 
            // BtGotoHome
            // 
            this.BtGotoHome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtGotoHome.Location = new System.Drawing.Point(10, 61);
            this.BtGotoHome.Margin = new System.Windows.Forms.Padding(4);
            this.BtGotoHome.Name = "BtGotoHome";
            this.BtGotoHome.Size = new System.Drawing.Size(164, 45);
            this.BtGotoHome.TabIndex = 74;
            this.BtGotoHome.Text = "Về vị trí Home";
            this.BtGotoHome.UseVisualStyleBackColor = true;
            this.BtGotoHome.Click += new System.EventHandler(this.BtGotoHome_Click);
            // 
            // BtAdd
            // 
            this.BtAdd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAdd.Location = new System.Drawing.Point(7, 8);
            this.BtAdd.Margin = new System.Windows.Forms.Padding(4);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(164, 45);
            this.BtAdd.TabIndex = 9;
            this.BtAdd.Text = "Chọn file";
            this.BtAdd.UseVisualStyleBackColor = true;
            this.BtAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // BtStart
            // 
            this.BtStart.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtStart.Location = new System.Drawing.Point(175, 8);
            this.BtStart.Margin = new System.Windows.Forms.Padding(4);
            this.BtStart.Name = "BtStart";
            this.BtStart.Size = new System.Drawing.Size(164, 45);
            this.BtStart.TabIndex = 3;
            this.BtStart.Text = "Bắt đầu";
            this.BtStart.UseVisualStyleBackColor = true;
            this.BtStart.Click += new System.EventHandler(this.BtStart_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1151, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Image = global::Ver2.Properties.Resources.gear;
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.settingToolStripMenuItem.Text = "Cài đặt";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::Ver2.Properties.Resources.info;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.aboutToolStripMenuItem.Text = "Thông tin";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Graph
            // 
            this.Graph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Graph.Location = new System.Drawing.Point(383, 28);
            this.Graph.Margin = new System.Windows.Forms.Padding(4);
            this.Graph.Name = "Graph";
            this.Graph.ScrollGrace = 0D;
            this.Graph.ScrollMaxX = 0D;
            this.Graph.ScrollMaxY = 0D;
            this.Graph.ScrollMaxY2 = 0D;
            this.Graph.ScrollMinX = 0D;
            this.Graph.ScrollMinY = 0D;
            this.Graph.ScrollMinY2 = 0D;
            this.Graph.Size = new System.Drawing.Size(760, 628);
            this.Graph.TabIndex = 2;
            // 
            // COM
            // 
            this.COM.BaudRate = 115200;
            this.COM.PortName = "COM3";
            this.COM.WriteBufferSize = 4096;
            this.COM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.COM_DataReceived);
            // 
            // BtStop
            // 
            this.BtStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtStop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtStop.Location = new System.Drawing.Point(188, 61);
            this.BtStop.Margin = new System.Windows.Forms.Padding(4);
            this.BtStop.Name = "BtStop";
            this.BtStop.Size = new System.Drawing.Size(164, 45);
            this.BtStop.TabIndex = 4;
            this.BtStop.Text = "Tạm dừng";
            this.BtStop.UseVisualStyleBackColor = true;
            this.BtStop.Click += new System.EventHandler(this.BtStop_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Yellow;
            this.label12.Location = new System.Drawing.Point(190, 109);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 19);
            this.label12.TabIndex = 88;
            this.label12.Text = "Z";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Yellow;
            this.label13.Location = new System.Drawing.Point(189, 63);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 19);
            this.label13.TabIndex = 87;
            this.label13.Text = "Y";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.Rb10);
            this.panel1.Controls.Add(this.Rb100);
            this.panel1.Controls.Add(this.Rb1000);
            this.panel1.Location = new System.Drawing.Point(10, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 40);
            this.panel1.TabIndex = 0;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(24, 10);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(46, 19);
            this.radioButton2.TabIndex = 99;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "100";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.Rb1_CheckedChanged);
            // 
            // Rb10
            // 
            this.Rb10.AutoSize = true;
            this.Rb10.Location = new System.Drawing.Point(276, 10);
            this.Rb10.Margin = new System.Windows.Forms.Padding(4);
            this.Rb10.Name = "Rb10";
            this.Rb10.Size = new System.Drawing.Size(42, 19);
            this.Rb10.TabIndex = 3;
            this.Rb10.Text = "0.1";
            this.Rb10.UseVisualStyleBackColor = true;
            this.Rb10.CheckedChanged += new System.EventHandler(this.Rb10_CheckedChanged);
            // 
            // Rb100
            // 
            this.Rb100.AutoSize = true;
            this.Rb100.Location = new System.Drawing.Point(193, 10);
            this.Rb100.Margin = new System.Windows.Forms.Padding(4);
            this.Rb100.Name = "Rb100";
            this.Rb100.Size = new System.Drawing.Size(32, 19);
            this.Rb100.TabIndex = 2;
            this.Rb100.Text = "1";
            this.Rb100.UseVisualStyleBackColor = true;
            this.Rb100.CheckedChanged += new System.EventHandler(this.Rb100_CheckedChanged);
            // 
            // Rb1000
            // 
            this.Rb1000.AutoSize = true;
            this.Rb1000.Location = new System.Drawing.Point(108, 10);
            this.Rb1000.Margin = new System.Windows.Forms.Padding(4);
            this.Rb1000.Name = "Rb1000";
            this.Rb1000.Size = new System.Drawing.Size(39, 19);
            this.Rb1000.TabIndex = 1;
            this.Rb1000.Text = "10";
            this.Rb1000.UseVisualStyleBackColor = true;
            this.Rb1000.CheckedChanged += new System.EventHandler(this.Rb1000_CheckedChanged);
            // 
            // PnControl
            // 
            this.PnControl.BackColor = System.Drawing.Color.Gainsboro;
            this.PnControl.Controls.Add(this.panel6);
            this.PnControl.Controls.Add(this.panel4);
            this.PnControl.Controls.Add(this.panel3);
            this.PnControl.Controls.Add(this.panel1);
            this.PnControl.Location = new System.Drawing.Point(14, 203);
            this.PnControl.Margin = new System.Windows.Forms.Padding(4);
            this.PnControl.Name = "PnControl";
            this.PnControl.Size = new System.Drawing.Size(361, 454);
            this.PnControl.TabIndex = 95;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Controls.Add(this.tbFN);
            this.panel6.Controls.Add(this.BtAdd);
            this.panel6.Controls.Add(this.BtStart);
            this.panel6.Location = new System.Drawing.Point(10, 353);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(346, 91);
            this.panel6.TabIndex = 98;
            // 
            // tbFN
            // 
            this.tbFN.Location = new System.Drawing.Point(7, 60);
            this.tbFN.Margin = new System.Windows.Forms.Padding(4);
            this.tbFN.Name = "tbFN";
            this.tbFN.Size = new System.Drawing.Size(330, 21);
            this.tbFN.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Controls.Add(this.tbD1);
            this.panel4.Controls.Add(this.tbT3);
            this.panel4.Controls.Add(this.tbT2);
            this.panel4.Controls.Add(this.BtSendJ);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.BtD1De);
            this.panel4.Controls.Add(this.BtT2De);
            this.panel4.Controls.Add(this.CmdD1);
            this.panel4.Controls.Add(this.CmdT3);
            this.panel4.Controls.Add(this.CmdT2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.BtD1In);
            this.panel4.Controls.Add(this.BtT2In);
            this.panel4.Controls.Add(this.BtT3De);
            this.panel4.Controls.Add(this.BtT3In);
            this.panel4.Location = new System.Drawing.Point(10, 204);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(346, 142);
            this.panel4.TabIndex = 97;
            // 
            // tbD1
            // 
            this.tbD1.Location = new System.Drawing.Point(64, 104);
            this.tbD1.Margin = new System.Windows.Forms.Padding(4);
            this.tbD1.Name = "tbD1";
            this.tbD1.Size = new System.Drawing.Size(68, 21);
            this.tbD1.TabIndex = 103;
            // 
            // tbT3
            // 
            this.tbT3.Location = new System.Drawing.Point(64, 60);
            this.tbT3.Margin = new System.Windows.Forms.Padding(4);
            this.tbT3.Name = "tbT3";
            this.tbT3.Size = new System.Drawing.Size(70, 21);
            this.tbT3.TabIndex = 102;
            // 
            // tbT2
            // 
            this.tbT2.Location = new System.Drawing.Point(64, 14);
            this.tbT2.Margin = new System.Windows.Forms.Padding(4);
            this.tbT2.Name = "tbT2";
            this.tbT2.Size = new System.Drawing.Size(68, 21);
            this.tbT2.TabIndex = 101;
            // 
            // BtSendJ
            // 
            this.BtSendJ.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSendJ.Location = new System.Drawing.Point(7, 8);
            this.BtSendJ.Margin = new System.Windows.Forms.Padding(4);
            this.BtSendJ.Name = "BtSendJ";
            this.BtSendJ.Size = new System.Drawing.Size(50, 127);
            this.BtSendJ.TabIndex = 92;
            this.BtSendJ.Text = "FK";
            this.BtSendJ.UseVisualStyleBackColor = true;
            this.BtSendJ.Click += new System.EventHandler(this.BtSendJ_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(185, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 19);
            this.label1.TabIndex = 86;
            this.label1.Text = "T2";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(185, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 19);
            this.label2.TabIndex = 88;
            this.label2.Text = "D1";
            // 
            // BtD1De
            // 
            this.BtD1De.Location = new System.Drawing.Point(143, 100);
            this.BtD1De.Margin = new System.Windows.Forms.Padding(4);
            this.BtD1De.Name = "BtD1De";
            this.BtD1De.Size = new System.Drawing.Size(39, 35);
            this.BtD1De.TabIndex = 100;
            this.BtD1De.Text = "-";
            this.BtD1De.UseVisualStyleBackColor = true;
            this.BtD1De.Click += new System.EventHandler(this.BtD1De_Click);
            // 
            // BtT2De
            // 
            this.BtT2De.Location = new System.Drawing.Point(143, 8);
            this.BtT2De.Margin = new System.Windows.Forms.Padding(4);
            this.BtT2De.Name = "BtT2De";
            this.BtT2De.Size = new System.Drawing.Size(39, 35);
            this.BtT2De.TabIndex = 98;
            this.BtT2De.Text = "-";
            this.BtT2De.UseVisualStyleBackColor = true;
            this.BtT2De.Click += new System.EventHandler(this.BtT2De_Click);
            // 
            // CmdD1
            // 
            this.CmdD1.Location = new System.Drawing.Point(267, 106);
            this.CmdD1.Margin = new System.Windows.Forms.Padding(4);
            this.CmdD1.Name = "CmdD1";
            this.CmdD1.Size = new System.Drawing.Size(70, 21);
            this.CmdD1.TabIndex = 72;
            // 
            // CmdT3
            // 
            this.CmdT3.Location = new System.Drawing.Point(267, 60);
            this.CmdT3.Margin = new System.Windows.Forms.Padding(4);
            this.CmdT3.Name = "CmdT3";
            this.CmdT3.Size = new System.Drawing.Size(70, 21);
            this.CmdT3.TabIndex = 71;
            // 
            // CmdT2
            // 
            this.CmdT2.Location = new System.Drawing.Point(267, 13);
            this.CmdT2.Margin = new System.Windows.Forms.Padding(4);
            this.CmdT2.Name = "CmdT2";
            this.CmdT2.Size = new System.Drawing.Size(70, 21);
            this.CmdT2.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(185, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 19);
            this.label3.TabIndex = 87;
            this.label3.Text = "T3";
            // 
            // BtD1In
            // 
            this.BtD1In.Location = new System.Drawing.Point(216, 100);
            this.BtD1In.Margin = new System.Windows.Forms.Padding(4);
            this.BtD1In.Name = "BtD1In";
            this.BtD1In.Size = new System.Drawing.Size(39, 35);
            this.BtD1In.TabIndex = 97;
            this.BtD1In.Text = "+";
            this.BtD1In.UseVisualStyleBackColor = true;
            this.BtD1In.Click += new System.EventHandler(this.BtD1In_Click);
            // 
            // BtT2In
            // 
            this.BtT2In.Location = new System.Drawing.Point(216, 8);
            this.BtT2In.Margin = new System.Windows.Forms.Padding(4);
            this.BtT2In.Name = "BtT2In";
            this.BtT2In.Size = new System.Drawing.Size(39, 35);
            this.BtT2In.TabIndex = 96;
            this.BtT2In.Text = "+";
            this.BtT2In.UseVisualStyleBackColor = true;
            this.BtT2In.Click += new System.EventHandler(this.BtT2In_Click);
            // 
            // BtT3De
            // 
            this.BtT3De.Location = new System.Drawing.Point(143, 54);
            this.BtT3De.Margin = new System.Windows.Forms.Padding(4);
            this.BtT3De.Name = "BtT3De";
            this.BtT3De.Size = new System.Drawing.Size(39, 35);
            this.BtT3De.TabIndex = 99;
            this.BtT3De.Text = "-";
            this.BtT3De.UseVisualStyleBackColor = true;
            this.BtT3De.Click += new System.EventHandler(this.BtT3De_Click);
            // 
            // BtT3In
            // 
            this.BtT3In.Location = new System.Drawing.Point(216, 54);
            this.BtT3In.Margin = new System.Windows.Forms.Padding(4);
            this.BtT3In.Name = "BtT3In";
            this.BtT3In.Size = new System.Drawing.Size(39, 35);
            this.BtT3In.TabIndex = 97;
            this.BtT3In.Text = "+";
            this.BtT3In.UseVisualStyleBackColor = true;
            this.BtT3In.Click += new System.EventHandler(this.BtT3In_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.tbZ);
            this.panel3.Controls.Add(this.BtSend);
            this.panel3.Controls.Add(this.tbY);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.tbX);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.BtZDe);
            this.panel3.Controls.Add(this.BtXDe);
            this.panel3.Controls.Add(this.CmdZ);
            this.panel3.Controls.Add(this.CmdY);
            this.panel3.Controls.Add(this.CmdX);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.BtZIn);
            this.panel3.Controls.Add(this.BtXIn);
            this.panel3.Controls.Add(this.BtYDe);
            this.panel3.Controls.Add(this.BtYIn);
            this.panel3.Location = new System.Drawing.Point(10, 55);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(346, 142);
            this.panel3.TabIndex = 96;
            // 
            // tbZ
            // 
            this.tbZ.Location = new System.Drawing.Point(64, 105);
            this.tbZ.Margin = new System.Windows.Forms.Padding(4);
            this.tbZ.Name = "tbZ";
            this.tbZ.Size = new System.Drawing.Size(68, 21);
            this.tbZ.TabIndex = 100;
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(64, 61);
            this.tbY.Margin = new System.Windows.Forms.Padding(4);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(68, 21);
            this.tbY.TabIndex = 99;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Yellow;
            this.label14.Location = new System.Drawing.Point(189, 17);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 19);
            this.label14.TabIndex = 86;
            this.label14.Text = "X";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(64, 15);
            this.tbX.Margin = new System.Windows.Forms.Padding(4);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(68, 21);
            this.tbX.TabIndex = 98;
            // 
            // BtZDe
            // 
            this.BtZDe.Location = new System.Drawing.Point(143, 100);
            this.BtZDe.Margin = new System.Windows.Forms.Padding(4);
            this.BtZDe.Name = "BtZDe";
            this.BtZDe.Size = new System.Drawing.Size(39, 35);
            this.BtZDe.TabIndex = 100;
            this.BtZDe.Text = "-";
            this.BtZDe.UseVisualStyleBackColor = true;
            this.BtZDe.Click += new System.EventHandler(this.BtZDe_Click);
            // 
            // BtXDe
            // 
            this.BtXDe.Location = new System.Drawing.Point(143, 8);
            this.BtXDe.Margin = new System.Windows.Forms.Padding(4);
            this.BtXDe.Name = "BtXDe";
            this.BtXDe.Size = new System.Drawing.Size(39, 35);
            this.BtXDe.TabIndex = 98;
            this.BtXDe.Text = "-";
            this.BtXDe.UseVisualStyleBackColor = true;
            this.BtXDe.Click += new System.EventHandler(this.BtXDe_Click);
            // 
            // BtZIn
            // 
            this.BtZIn.Location = new System.Drawing.Point(216, 100);
            this.BtZIn.Margin = new System.Windows.Forms.Padding(4);
            this.BtZIn.Name = "BtZIn";
            this.BtZIn.Size = new System.Drawing.Size(39, 35);
            this.BtZIn.TabIndex = 97;
            this.BtZIn.Text = "+";
            this.BtZIn.UseVisualStyleBackColor = true;
            this.BtZIn.Click += new System.EventHandler(this.BtZIn_Click);
            // 
            // BtXIn
            // 
            this.BtXIn.Location = new System.Drawing.Point(216, 8);
            this.BtXIn.Margin = new System.Windows.Forms.Padding(4);
            this.BtXIn.Name = "BtXIn";
            this.BtXIn.Size = new System.Drawing.Size(39, 35);
            this.BtXIn.TabIndex = 96;
            this.BtXIn.Text = "+";
            this.BtXIn.UseVisualStyleBackColor = true;
            this.BtXIn.Click += new System.EventHandler(this.BtXIn_Click);
            // 
            // BtYDe
            // 
            this.BtYDe.Location = new System.Drawing.Point(143, 54);
            this.BtYDe.Margin = new System.Windows.Forms.Padding(4);
            this.BtYDe.Name = "BtYDe";
            this.BtYDe.Size = new System.Drawing.Size(39, 35);
            this.BtYDe.TabIndex = 99;
            this.BtYDe.Text = "-";
            this.BtYDe.UseVisualStyleBackColor = true;
            this.BtYDe.Click += new System.EventHandler(this.BtYDe_Click);
            // 
            // BtYIn
            // 
            this.BtYIn.Location = new System.Drawing.Point(216, 54);
            this.BtYIn.Margin = new System.Windows.Forms.Padding(4);
            this.BtYIn.Name = "BtYIn";
            this.BtYIn.Size = new System.Drawing.Size(39, 35);
            this.BtYIn.TabIndex = 97;
            this.BtYIn.Text = "+";
            this.BtYIn.UseVisualStyleBackColor = true;
            this.BtYIn.Click += new System.EventHandler(this.BtYIn_Click);
            // 
            // PnButtons
            // 
            this.PnButtons.BackColor = System.Drawing.Color.Gainsboro;
            this.PnButtons.Controls.Add(this.BtConnect);
            this.PnButtons.Controls.Add(this.BtDrill);
            this.PnButtons.Controls.Add(this.btCalib);
            this.PnButtons.Controls.Add(this.btExit);
            this.PnButtons.Controls.Add(this.BtStop);
            this.PnButtons.Controls.Add(this.BtGotoHome);
            this.PnButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnButtons.Location = new System.Drawing.Point(14, 28);
            this.PnButtons.Margin = new System.Windows.Forms.Padding(4);
            this.PnButtons.Name = "PnButtons";
            this.PnButtons.Size = new System.Drawing.Size(361, 167);
            this.PnButtons.TabIndex = 97;
            // 
            // BtConnect
            // 
            this.BtConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtConnect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtConnect.Location = new System.Drawing.Point(10, 9);
            this.BtConnect.Margin = new System.Windows.Forms.Padding(4);
            this.BtConnect.Name = "BtConnect";
            this.BtConnect.Size = new System.Drawing.Size(164, 45);
            this.BtConnect.TabIndex = 101;
            this.BtConnect.Text = "Kết nối";
            this.BtConnect.UseVisualStyleBackColor = true;
            this.BtConnect.Click += new System.EventHandler(this.BtConnect_Click);
            // 
            // BtDrill
            // 
            this.BtDrill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtDrill.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDrill.Location = new System.Drawing.Point(188, 113);
            this.BtDrill.Margin = new System.Windows.Forms.Padding(4);
            this.BtDrill.Name = "BtDrill";
            this.BtDrill.Size = new System.Drawing.Size(164, 45);
            this.BtDrill.TabIndex = 100;
            this.BtDrill.Text = "Bật động cơ khoan";
            this.BtDrill.UseVisualStyleBackColor = true;
            this.BtDrill.Click += new System.EventHandler(this.BtDrill_Click);
            // 
            // btCalib
            // 
            this.btCalib.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalib.Location = new System.Drawing.Point(10, 113);
            this.btCalib.Margin = new System.Windows.Forms.Padding(4);
            this.btCalib.Name = "btCalib";
            this.btCalib.Size = new System.Drawing.Size(164, 45);
            this.btCalib.TabIndex = 99;
            this.btCalib.Text = "Cân chỉnh robot";
            this.btCalib.UseVisualStyleBackColor = true;
            this.btCalib.Click += new System.EventHandler(this.btCalib_Click);
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(188, 9);
            this.btExit.Margin = new System.Windows.Forms.Padding(4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(164, 45);
            this.btExit.TabIndex = 98;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1125, 660);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 98;
            this.label4.Text = "Y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 679);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PnButtons);
            this.Controls.Add(this.PnControl);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "SCARA ARM PCB Drilling";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PnControl.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PnButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private ZedGraph.ZedGraphControl Graph;
        private System.Windows.Forms.Button BtStart;
        private System.Windows.Forms.Button BtStop;
        private System.Windows.Forms.Button BtAdd;
        public System.IO.Ports.SerialPort COM;
        private System.Windows.Forms.Button BtGotoHome;
        private System.Windows.Forms.Button BtSend;
        private System.Windows.Forms.TextBox CmdX;
        private System.Windows.Forms.TextBox CmdY;
        private System.Windows.Forms.TextBox CmdZ;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PnControl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button BtZDe;
        private System.Windows.Forms.Button BtXDe;
        private System.Windows.Forms.Button BtZIn;
        private System.Windows.Forms.Button BtXIn;
        private System.Windows.Forms.Button BtYDe;
        private System.Windows.Forms.Button BtYIn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtSendJ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtD1De;
        private System.Windows.Forms.Button BtT2De;
        private System.Windows.Forms.TextBox CmdD1;
        private System.Windows.Forms.TextBox CmdT3;
        private System.Windows.Forms.TextBox CmdT2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtD1In;
        private System.Windows.Forms.Button BtT2In;
        private System.Windows.Forms.Button BtT3De;
        private System.Windows.Forms.Button BtT3In;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel PnButtons;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.TextBox tbZ;
        private System.Windows.Forms.TextBox tbD1;
        private System.Windows.Forms.TextBox tbT3;
        private System.Windows.Forms.TextBox tbT2;
        private System.Windows.Forms.Button btCalib;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton Rb10;
        private System.Windows.Forms.RadioButton Rb100;
        private System.Windows.Forms.RadioButton Rb1000;
        private System.Windows.Forms.Button BtDrill;
        private System.Windows.Forms.TextBox tbFN;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtConnect;
        private System.Windows.Forms.Label label4;
    }
}

