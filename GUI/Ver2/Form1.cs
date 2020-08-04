using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using ZedGraph;
using System.IO;

namespace Ver2
{
    public partial class Form1 : Form
    {
        //*****  USER VARIABLE  ***************
        const double scl = 1;
        const double ofsx = 100;
        const double ofsy = 0;
        const double ofs = 0;
        double a2 = 162.5;
        double a3 = 116.5;
        double d4 = 0;
        string[] Lines;
        List<int> Locat = new List<int>();
        List<double> Sizze = new List<double>();
        List<List<double[]>> Counterr = new List<List<double[]>>();
        List<int> Disst = new List<int>();
        double[] curP = new double[4] { 0, 0, 0, 0 };
        double[] curJ = new double[4] { 0, 0, 0, 0 };
        double[] preP = new double[4] { 0, 0, 0, 0 };
        double[] preJ = new double[4] { 0, 0, 0, 0 };
        int[] Per = new int[3] { 0, 0, 0 };
        double[] Spe = new double[3] { 0, 0, 0 };
        double scale = 100;
        string filename;
        bool IsScaraStopped = true;
        bool IsSending;
        bool IsDrilling = false;
        bool Pause = false;
        Color[] myColors = new Color[10] { Color.Blue, Color.Brown, Color.BlueViolet, Color.BurlyWood, Color.CadetBlue, Color.Chocolate, Color.Coral, Color.CornflowerBlue, Color.Crimson, Color.Cyan };
        PointPairList donePoint = new PointPairList();
        PointPairList currPoint = new PointPairList();
        List<PointPairList> ListOfType = new List<PointPairList>();
        List<LineItem> myLineItems = new List<LineItem>();
        List<LineItem> curItem = new List<LineItem>();
        //OpenFileDialog OFile = new OpenFileDialog();
        Form2 Setting = new Form2();
        Thread myth2;
        int count = 0;
        bool tt = true;
        int[] FStep = new int[3] { 0, 0, 0 };
        int[] steps = new int[4] { 0, 0, 0, 0 };
        int[] direc = new int[4] { 1, 1, 1, 1 };
        string Rx;
        bool IsCalibrating = false;
        bool IsCalibrated = false;
        double Unit;
        int decima;
        int origin;


        //*****  END OF USER VARIABLE  ********

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsCalibrating == true)
            {
                CmdX.Text = "Cân chỉnh";
                CmdY.Text = "Cân chỉnh";
                CmdZ.Text = "Cân chỉnh";
                CmdT2.Text = "Cân chỉnh";
                CmdT3.Text = "Cân chỉnh";
                CmdD1.Text = "Cân chỉnh";
            }
            else
            {
                GetCurrPoint(steps, direc, FStep, curP, curJ);
                CurrentPoint(curP, Graph);
                CmdX.Text = curP[1].ToString("N2");
                CmdY.Text = curP[2].ToString("N2");
                CmdZ.Text = curP[0].ToString("N2");
                CmdT2.Text = curJ[1].ToString("N2");
                CmdT3.Text = curJ[2].ToString("N2");
                CmdD1.Text = curJ[0].ToString("N2");
                count++;
                if (count % 10 == 0)
                {
                    tt = false;
                }
                else
                {
                    tt = true;
                }
                if (tt == true)
                {
                    curItem[0].Symbol.Fill = new Fill(Color.Yellow);
                }
                else
                {
                    curItem[0].Symbol.Fill = new Fill(Color.Black);
                }
            }
            Graph.Refresh();
        }

        private void COM_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            Rx = sp.ReadLine();
            switch (Rx[0])
            {
                case 'S':
                    IsScaraStopped = true;
                    break;
                case 'F':
                    FStep[0] = Convert.ToInt32(Rx.Substring(1, 6));
                    FStep[1] = Convert.ToInt32(Rx.Substring(7, 6));
                    FStep[2] = Convert.ToInt32(Rx.Substring(13, 6));
                    if (FStep[0] == 0 && FStep[1] == 0 && FStep[2] == 0)
                        IsScaraStopped = true;
                    break;
                case 'P':
                    FStep[0] = Convert.ToInt32(Rx.Substring(1, 6));
                    FStep[1] = Convert.ToInt32(Rx.Substring(7, 6));
                    FStep[2] = Convert.ToInt32(Rx.Substring(13, 6));
                    IsScaraStopped = true;
                    break;
                case '1':
                    Thread.Sleep(100);
                    CalibT2a();
                    break;
                case '2':
                    Thread.Sleep(100);
                    CalibT2b();
                    break;
                case '3':
                    Thread.Sleep(100);
                    CalibT3a();
                    break;
                case '4':
                    Thread.Sleep(100);
                    CalibT3b();
                    break;
                case '5':
                    Thread.Sleep(100);
                    CalibD1a();
                    break;
                case '6':
                    Thread.Sleep(100);
                    CalibD1b();
                    break;
                case '7':
                    Thread.Sleep(100);
                    curP[0] = 0;
                    curP[1] = a2 + a3;
                    curP[2] = 0;
                    curP[3] = 0;
                    curJ[0] = d4;
                    curJ[1] = 0;
                    curJ[2] = 0;
                    curJ[3] = 0;
                    preP[0] = 0;
                    preP[1] = a2 + a3;
                    preP[2] = 0;
                    preP[3] = 0;
                    preJ[0] = d4;
                    preJ[1] = 0;
                    preJ[2] = 0;
                    preJ[3] = 0;
                    steps[0] = 0;
                    steps[1] = 0;
                    steps[2] = 0;
                    steps[3] = 0;
                    direc[0] = 1;
                    direc[1] = 1;
                    direc[2] = 1;
                    direc[3] = 1;
                    FStep[0] = 0;
                    FStep[1] = 0;
                    FStep[2] = 0;
                    IsCalibrating = false;
                    IsCalibrated = true;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Graph.GraphPane.XAxis.Scale.Min = -300;
            Graph.GraphPane.XAxis.Scale.Max = 300;
            Graph.GraphPane.YAxis.Scale.Min = 0;
            Graph.GraphPane.YAxis.Scale.Max = 300;

            currPoint.Add(curP[2], curP[1]);
            curItem.Add(Graph.GraphPane.AddCurve("Vị trí hiện tại", currPoint, Color.Yellow, SymbolType.Square));
            curItem[0].Line.IsVisible = false;
            curItem[0].Symbol.Border.IsVisible = false;
            curItem[0].Symbol.Size = 3;
            curItem[0].Symbol.Fill = new Fill(Color.Yellow);

            Graph.GraphPane.Title.IsVisible = false;
            Graph.GraphPane.XAxis.Title.IsVisible = false;
            Graph.GraphPane.YAxis.Title.IsVisible = false;
            //Graph.GraphPane.XAxis.Title.Text = "Y";
            //Graph.GraphPane.YAxis.Title.Text = "X";
            Graph.GraphPane.Chart.Fill = new Fill(Color.Black);
            Graph.GraphPane.IsFontsScaled = false;
            Graph.AxisChange();
            PnControl.Enabled = false;
            btCalib.Enabled = false;
            BtDrill.Enabled = false;
            BtGotoHome.Enabled = false;
            BtStop.Enabled = false;
            myth2 = new Thread(Automode);
            curP[1] = a2 + a3;
            preP[1] = a2 + a3;
            curJ[0] = d4;
            preJ[0] = d4;
            timer1.Enabled = true;
            //MessageBox.Show("Warning", "Robot must be calibrated", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //myth2.Start();
        }

        //*****  CODE FOR CONTROL MODE  ************************

        private void Rb1000_CheckedChanged(object sender, EventArgs e)
        {
            scale = 10;
        }

        private void Rb100_CheckedChanged(object sender, EventArgs e)
        {
            scale = 1;
        }

        private void Rb10_CheckedChanged(object sender, EventArgs e)
        {
            scale = 0.1;
        }

        private void Rb1_CheckedChanged(object sender, EventArgs e)
        {
            scale = 100;
        }

        private void BtXDe_Click(object sender, EventArgs e)
        {
            curP[1] = curP[1] - scale;
            SendP();
        }

        private void BtXIn_Click(object sender, EventArgs e)
        {
            curP[1] = curP[1] + scale;
            SendP();
        }

        private void BtYDe_Click(object sender, EventArgs e)
        {
            curP[2] = curP[2] - scale;
            SendP();
        }

        private void BtYIn_Click(object sender, EventArgs e)
        {
            curP[2] = curP[2] + scale;
            SendP();
        }

        private void BtZDe_Click(object sender, EventArgs e)
        {
            curP[0] = curP[0] - scale;
            SendP();
        }

        private void BtZIn_Click(object sender, EventArgs e)
        {
            curP[0] = curP[0] + scale;
            SendP();
        }

        private void BtT2De_Click(object sender, EventArgs e)
        {
            curJ[1] = curJ[1] - scale;
            SendJ();
        }

        private void BtT2In_Click(object sender, EventArgs e)
        {
            curJ[1] = curJ[1] + scale;
            SendJ();
        }

        private void BtT3De_Click(object sender, EventArgs e)
        {
            curJ[2] = curJ[2] - scale;
            SendJ();
        }

        private void BtT3In_Click(object sender, EventArgs e)
        {
            curJ[2] = curJ[2] + scale;
            SendJ();
        }

        private void BtD1De_Click(object sender, EventArgs e)
        {
            curJ[0] = curJ[0] - scale;
            SendJ();
        }

        private void BtD1In_Click(object sender, EventArgs e)
        {
            curJ[0] = curJ[0] + scale;
            SendJ();
        }
        private void BtSend_Click(object sender, EventArgs e)
        {
            if (tbX.Text == "" || tbY.Text == "" || tbZ.Text == "")
            {
                MessageBox.Show("Vui lòng nhâọ đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                curP[1] = Convert.ToDouble(tbX.Text);
                curP[2] = Convert.ToDouble(tbY.Text);
                curP[0] = Convert.ToDouble(tbZ.Text);
            }
            if (curP[0] < -130 || curP[0] > 300 || curP[1] < -100 || curP[1] > (a2 + a3) || curP[2] < -(a2 + a3) || curP[2] > (a2 + a3) || (Math.Pow(curP[1], 2) + Math.Pow(curP[2], 2) > Math.Pow((a2 + a3), 2)) || (Math.Pow(curP[1], 2) + Math.Pow(curP[2], 2) < Math.Pow((a2 - a3), 2)))
            {
                string err = (a2 + a3).ToString();
                MessageBox.Show("X từ -100 đếm " + err + " mm.\r\nY từ - " + err + " đến " + err + " mm.\r\nZ từ 0 đến -130 mm.", "Out of range", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (IsScaraStopped == true)
                {
                    IsScaraStopped = false;
                    GetstepP(preP, curP, preJ, curJ, steps, direc);
                    SynSpeed(steps);
                    Send(steps, direc, Per);
                }
                else
                    MessageBox.Show("Vui lòng đợi", "Robot vẫn đang chạy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtSendJ_Click(object sender, EventArgs e)
        {
            if (tbT2.Text == "" || tbT3.Text == "" || tbD1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                curJ[1] = Convert.ToDouble(tbT2.Text);
                curJ[2] = Convert.ToDouble(tbT3.Text);
                curJ[0] = Convert.ToDouble(tbD1.Text);
            }
            forward_kinetic(curJ, curP);
            if (curP[0] < -130 || curP[0] > 300 || curP[1] < 0 || curP[1] > (a2 + a3) || curP[2] < -(a2 + a3) || curP[2] > (a2 + a3) || (Math.Pow(curP[1], 2) + Math.Pow(curP[2], 2) > Math.Pow((a2 + a3), 2)) || (Math.Pow(curP[1], 2) + Math.Pow(curP[2], 2) < Math.Pow((a2 - a3), 2)))
            {
                string err = (a2 + a3).ToString();
                MessageBox.Show("X từ -100 đếm " + err + " mm.\r\nY từ - " + err + " đến " + err + " mm.\r\nZ từ 0 đến -130 mm.", "Out of range", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (IsScaraStopped == true)
                {
                    IsScaraStopped = false;
                    GetstepJ(preJ, curJ, steps, direc);
                    SynSpeed(steps);
                    Send(steps, direc, Per);
                }
                else
                    MessageBox.Show("Vui lòng chờ", "Robot vẫn đang chạy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SendP()
        {
            try
            {
                if (curP[0] < -130 || curP[0] > 300 || curP[1] < -100 || curP[1] > (a2 + a3) || curP[2] < -(a2 + a3) || curP[2] > (a2 + a3) || (Math.Pow(curP[1], 2) + Math.Pow(curP[2], 2) > Math.Pow(a2 + a3, 2)) || (Math.Pow(curP[1], 2) + Math.Pow(curP[2], 2) < Math.Pow((a2 - a3), 2)))
                {
                    string err = (a2 + a3).ToString();
                    MessageBox.Show("X từ -100 đếm " + err + " mm.\r\nY từ - " + err + " đến " + err + " mm.\r\nZ từ 0 đến -130 mm.", "Out of range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (IsScaraStopped == true)
                    {
                        IsScaraStopped = false;
                        GetstepP(preP, curP, preJ, curJ, steps, direc);
                        SynSpeed(steps);
                        Send(steps, direc, Per);
                    }
                    else
                        MessageBox.Show("Vui lòng chờ", "Robot vẫn đang chạy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SendJ()
        {
            try
            {
                forward_kinetic(curJ, curP);
                if (curP[0] < -130 || curP[0] > 300 || curP[1] < 100 || curP[1] > (a2 + a3) || curP[2] < -(a2 + a3) || curP[2] > (a2 + a3) || (Math.Pow(curP[1], 2) + Math.Pow(curP[2], 2) > Math.Pow(a2 + a3, 2) + 0.1) || (Math.Pow(curP[1], 2) + Math.Pow(curP[2], 2) < Math.Pow((a2 - a3), 2) - 0.1))
                {
                    string err = (a2 + a3).ToString();
                    MessageBox.Show("X từ -100 đếm " + err + " mm.\r\nY từ - " + err + " đến " + err + " mm.\r\nZ từ 0 đến -130 mm.", "Vượt quá tầm hoạt động", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (IsScaraStopped == true)
                    {
                        IsScaraStopped = false;
                        GetstepJ(preJ, curJ, steps, direc);
                        SynSpeed(steps);
                        Send(steps, direc, Per);
                    }
                    else
                        MessageBox.Show("Vui lòng chờ", "Robot vẫn đang chạy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SendJC()
        {
            GetstepJ(preJ, curJ, steps, direc);
            SynSpeed(steps);
            Send(steps, direc, Per);
        }

        private void BtDrill_Click(object sender, EventArgs e)
        {
            if (IsDrilling == false)
            {
                BtDrill.Text = "Tắt động cơ khoan";
                COM.WriteLine("D_ON");
                IsDrilling = true;
            }
            else
            {
                BtDrill.Text = "Bật động cơ khoan";
                COM.WriteLine("D_OFF");
                IsDrilling = false;
            }
        }

        private void BtGotoHome_Click(object sender, EventArgs e)
        {
            curP[0] = 0;
            curP[1] = a2 + a3;
            curP[2] = 0;
            if (IsScaraStopped == true)
            {
                IsScaraStopped = false;
                GetstepP(preP, curP, preJ, curJ, steps, direc);
                SynSpeed(steps);
                Send(steps, direc, Per);
            }
            else
                MessageBox.Show("Vui lòng chờ", "Robot vẫn đang chạy", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //*****  END OF CONTROL MODE  **************************

        //*****  CODE FOR AUTO MODE  ***************************

        OpenFileDialog OFile = new OpenFileDialog();
        private void BtAdd_Click(object sender, EventArgs e)
        {
            if (OFile.ShowDialog() == DialogResult.OK)
            {
                filename = OFile.FileName;
            }
            try
            {
                tbFN.Text = filename;
                Lines = File.ReadAllLines(filename);
                refr();
                getCountersink(Lines, Locat, Sizze, Counterr, Disst);
                if (checkfile() == true)
                {
                    CreateChart(Graph);
                    BtStart.Enabled = true;
                }
                else
                    MessageBox.Show("Kích thước mạch vượt quá tầm hoạt động của robot", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (BtStart.Text == "Bắt đầu")
                {
                    myth2.Start();
                    myth2.IsBackground = true;
                    IsSending = true;
                    ///BtStart.Text = "Hủy";
                }
                else
                {
                    //myth2.Abort();
                    //COM.WriteLine("STOP");
                    BtStart.Text = "Bắt đầu";                
                }
                //IsSending = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Automode()
        {
            while (IsSending == true)
            {              
                for (int i = 0; i < Counterr.Count; i++)
                {
                    curP[0] = 0;
                    curP[1] = a2 + a3;
                    curP[2] = 0;
                    GetstepP(preP, curP, preJ, curJ, steps, direc);
                    SynSpeed(steps);
                    Send(steps, direc, Per);
                    IsScaraStopped = false;
                    while (IsScaraStopped == false) ;
                    while (Pause == true) ;
                    Thread.Sleep(100);
                    IsScaraStopped = false;
                    double nextSsize = Sizze[i];
                    COM.WriteLine("I");
                    string NextSize = "Thay mũi khoan loại " + nextSsize.ToString() + " mm";
                    DialogResult DRL = MessageBox.Show(NextSize, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);               
                    while (DRL != DialogResult.OK);
                    IsCalibrated = false;
                    if (IsCalibrated == false)
                    {
                        COM.WriteLine("C");
                        while (IsCalibrated == false) ;
                        Thread.Sleep(200);
                    }
                    //COM.WriteLine("D_ON");
                    //IsDrilling = true;
                    for (int j = 0; j < Counterr[i].Count; j++)
                    {
                        curP[0] = -110;
                        ExtractData(Counterr[i][j], curP);
                        GetstepP(preP, curP, preJ, curJ, steps, direc);
                        SynSpeed(steps);
                        Send(steps, direc, Per);
                        while (IsScaraStopped == false) ;
                        while (Pause == true);
                        if (IsDrilling == false)
                        {
                            COM.WriteLine("D_ON");
                            IsDrilling = true;
                        }
                        else { }
                        Thread.Sleep(100);
                        IsScaraStopped = false;
                        curP[0] = -120;
                        GetstepP(preP, curP, preJ, curJ, steps, direc);
                        SynSpeed(steps);
                        Send(steps, direc, Per);
                        while (IsScaraStopped == false) ;
                        while (Pause == true) ;
                        Thread.Sleep(100);
                        IsScaraStopped = false;
                        curP[0] = -110;
                        GetstepP(preP, curP, preJ, curJ, steps, direc);
                        SynSpeed(steps);
                        Send(steps, direc, Per);
                        while (IsScaraStopped == false) ;
                        while (Pause == true) ;
                        Thread.Sleep(100);
                        IsScaraStopped = false;
                        updateGraph(i, curP, Graph);
                    }
                    COM.WriteLine("D_OFF");
                    IsDrilling = false;
                    IsCalibrated = false;
                }
                curP[0] = 0;
                curP[1] = a2 + a3;
                curP[2] = 0;
                GetstepP(preP, curP, preJ, curJ, steps, direc);
                SynSpeed(steps);
                Send(steps, direc, Per);
                IsScaraStopped = false;
                while (IsScaraStopped == false) ;
                while (Pause == true) ;
                DialogResult DRL2 = MessageBox.Show("Đã hoàn tất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                while (DRL2 != DialogResult.OK);
                rfr(Graph);
                IsSending = false;
                IsScaraStopped = true;
                IsCalibrated = true;
                //BtStart.Text = "Bắt đầu";
                myth2.Abort();
            }
        }

        //*****  END OF AUTO MODE  *****************************

        //*****  PUBLIC BUTTON  ********************************

        private void BtConnect_Click(object sender, EventArgs e)
        {
            if (COM.IsOpen == false)
            {
                try
                {
                    COM.PortName = Properties.Settings.Default.PortName;
                    COM.BaudRate = Properties.Settings.Default.BaudRate;
                    COM.DataBits = Properties.Settings.Default.DataBits;
                    COM.StopBits = Properties.Settings.Default.StopBits;
                    COM.Parity = Properties.Settings.Default.Parity;

                    COM.DataReceived += new SerialDataReceivedEventHandler(COM_DataReceived);
                    COM.Open();
                    PnControl.Enabled = true;
                    btCalib.Enabled = true;
                    BtDrill.Enabled = true;
                    BtGotoHome.Enabled = true;
                    BtStop.Enabled = true;
                    BtStart.Enabled = false;
                    BtConnect.Text = "Ngắt kết nối";
                    DialogResult DRL3 = MessageBox.Show("Bấm Yes để tiến hành cân chỉnh Robot cho lần chạy đầu tiên", "Robot chưa được cân chỉnh", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(DRL3 == DialogResult.Yes)
                    {
                        IsCalibrating = true;
                        COM.WriteLine("C");
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                COM.Close();
                PnControl.Enabled = false;
                btCalib.Enabled = false;
                BtDrill.Enabled = false;
                BtGotoHome.Enabled = false;
                BtStop.Enabled = false;
                BtConnect.Text = "Kết nối";
            }
        }

        private void BtStop_Click(object sender, EventArgs e)
        {
            if (BtStop.Text == "Tạm dừng")
            {
                Pause = true;
                IsScaraStopped = false;
                COM.WriteLine("PAUSE");
                while (IsScaraStopped == false);
                BtStop.Text = "Tiếp tục";
            }
            else
            {
                COM.WriteLine("OK");
                Pause = false;
                IsScaraStopped = false;
                BtStop.Text = "Tạm dừng";
            }

        }
        //*****  END OF PUBLIC BUTTON  *************************

        //*****  GRAPH *****************************************
        public void CreateChart(ZedGraphControl zgc)
        {
            foreach (List<double[]> type in Counterr)
            {
                PointPairList beginPoint = new PointPairList();
                foreach (double[] xy in type)
                {
                    beginPoint.Add(xy[1] + ofsy, xy[0] + ofsx);
                }
                ListOfType.Add(beginPoint);
            }

            for (int i = 0; i < ListOfType.Count; i++)
            {
                myLineItems.Add(Graph.GraphPane.AddCurve(Sizze[i].ToString(), ListOfType[i], Color.Black, SymbolType.Circle));
            }

            for (int i = 0; i < myLineItems.Count; i++)
            {
                myLineItems[i].Line.IsVisible = false;
                myLineItems[i].Symbol.Size = (float)Sizze[i] + 7;
                myLineItems[i].Symbol.Border.IsVisible = false;
                myLineItems[i].Symbol.Fill = new Fill(myColors[i]);
                zgc.AxisChange();
            }
            LineItem myCurve = Graph.GraphPane.AddCurve("Hoàn thành", donePoint, Color.Black, SymbolType.Circle);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.Green);
            zgc.AxisChange();
        }

        private void updateGraph(int index1, double[] xy, ZedGraphControl zgc)
        {
            myLineItems[index1].RemovePoint(0);
            donePoint.Add(xy[2], xy[1]);
            zgc.AxisChange();
        }

        private void CurrentPoint(double[] xy, ZedGraphControl zgc)
        {
            curItem[0].RemovePoint(0);
            currPoint.Add(xy[2], xy[1]);
            zgc.AxisChange();
        }

        //*****  END OF GRAPH *****************************

        delegate void refCallback(ZedGraphControl zgc);

        private void rfr (ZedGraphControl zgc)
        {
            if(this.Graph.InvokeRequired)
            {
                refCallback d = new refCallback(rfr);
                this.Invoke(d, new object[] {zgc});
            }
            else
            {
                refr();
            }
        }

        //delegate void SetTextXCallback(string text);
        //delegate void SetTextYCallback(string text);
        //delegate void SetTextZCallback(string text);
        //private void SetTextX(string text)
        //{
        //    if (this.CmdX.InvokeRequired)
        //    {
        //        SetTextXCallback d = new SetTextXCallback(SetTextX);
        //        this.Invoke(d, new object[] { text });
        //    }
        //    else
        //    {
        //        this.CmdX.Text = text;
        //    }
        //}
        //private void SetTextY(string text)
        //{
        //    if (this.CmdY.InvokeRequired)
        //    {
        //        SetTextYCallback d = new SetTextYCallback(SetTextY);
        //        this.Invoke(d, new object[] { text });
        //    }
        //    else
        //    {
        //        this.CmdY.Text = text;
        //    }
        //}
        //private void SetTextZ(string text)
        //{
        //    if (this.CmdZ.InvokeRequired)
        //    {
        //        SetTextZCallback d = new SetTextZCallback(SetTextZ);
        //        this.Invoke(d, new object[] { text });
        //    }
        //    else
        //    {
        //        this.CmdZ.Text = text;
        //    }
        //}
        private void Send(int[] stp, int[] dr,int[] period)
        {
            COM.WriteLine("A" + dr[0] + period[0].ToString("D6") + stp[0].ToString("D6") + "B" + dr[1] + period[1].ToString("D6") + stp[1].ToString("D6") + "C" + dr[2] + period[2].ToString("D6") + stp[2].ToString("D6"));
        }
        private void ExtractData(double[] xy, double[] intP)
        {
            intP[1] = xy[0] + ofsx;
            intP[2] = xy[1] + ofsy;
        }

        private void getCountersink(string[] FileLines, List<int> Loca, List<double> Size, List<List<double[]>> Countersinks, List<int> Dist)
        {
            if(FileLines[3][0] == 'M')
            {
                Unit = 1;
                origin = 4;
                decima = Convert.ToInt32(FileLines[2][FileLines[2].Length - 1]) - 48;
            }
            else if(FileLines[3][0] == 'I')
            {
                Unit = 0.0254;
                origin = 5;
                decima = Convert.ToInt32(FileLines[2][FileLines[2].Length - 1]) - 51;
            }
            for (int i = 0; i < FileLines.Length; i++)
            {
                if (FileLines[i][0] == 'T')
                {
                    if (FileLines[i].Length > 3)
                    {
                        if (Unit == 1)
                            Size.Add(Math.Round(double.Parse(FileLines[i].Substring(FileLines[i].Length - decima - 2, decima + 2)), 2));
                        else
                            Size.Add(Math.Round(25.4*double.Parse(FileLines[i].Substring((FileLines[i].Length) - decima - 5, decima + 5)), 2));
                    }
                    else
                    {
                        Loca.Add(i);
                    }
                }
            }

            for (int i = 0; i < Loca.Count; i++)
            {
                if (i == Loca.Count - 1)
                {
                    Dist.Add(Lines.Length - 2 - Loca[i]);
                }
                else
                    Dist.Add(Loca[i + 1] - 1 - Loca[i]);
            }

            for (int i = 0; i < Dist.Count; i++)
            {
                Countersinks.Add(new List<double[]>());
                for (int j = Loca[i] + 1; j <= Loca[i] + Dist[i]; j++)
                {
                    double[] xy = new double[2];
                    string Line = FileLines[j];

                    if ( Line.Length == 2 + origin + origin + decima + decima)
                        {
                            xy[0] = Unit * double.Parse(Line.Substring(1, (origin + decima))) * Math.Pow(10, - decima);
                            xy[1] = Unit * double.Parse(Line.Substring(2 + origin + decima, (origin + decima))) * Math.Pow(10, - decima);
                        }
                    else
                        {
                            if(Line[0] == 'X')
                            {
                                xy[0] = Unit * double.Parse(Line.Substring(1, (origin + decima))) * Math.Pow(10, -decima);
                                xy[1] = Countersinks[i][Countersinks[i].Count - 1][1] / scl;
                        }
                            else
                            {
                                xy[0] = Countersinks[i][Countersinks[i].Count - 1][0] / scl;
                                xy[1] = Unit * double.Parse(Line.Substring(1, (origin + decima))) * Math.Pow(10, -decima);
                            }
                        }
                    xy[0] = xy[0] * scl;
                    xy[1] = xy[1] * scl;
                    Countersinks[i].Add(xy);
                }
            }
        }

        private void inverse_kinetic(double x, double y, double z, double anpha, double[] joints)
        {
            double c3, s3_1, s3_2;
            double[] temp = new double[2];
            c3 = (Math.Pow(x, 2) + Math.Pow(y, 2) - Math.Pow(a2, 2) - Math.Pow(a3, 2)) / (2 * a2 * a3);
            if(c3 >= -1.001 && c3 <= 1.001)
            {
                if (c3 < -1)
                    c3 = -1;
                else if (c3 > 1)
                    c3 = 1;
                s3_1 = Math.Sqrt(1 - Math.Pow(c3, 2));
                s3_2 = -Math.Sqrt(1 - Math.Pow(c3, 2));
                joints[0] = z + d4;
                joints[2] = Math.Atan2(s3_1, c3);
                joints[1] = Math.Atan2(y, x) - Math.Atan2(a3 * Math.Sin(joints[2]), a2 + a3 * Math.Cos(joints[2]));
                joints[3] = joints[1] + joints[2] - anpha;
                temp[0] = Math.Atan2(s3_2, c3);
                temp[1] = Math.Atan2(y, x) - Math.Atan2(a3 * Math.Sin(temp[0]), a2 + a3 * Math.Cos(temp[0]));
                if ((Math.Abs((temp[0])) + Math.Abs((temp[1]))) < (Math.Abs((joints[1]) + Math.Abs((joints[2])))))
                {
                    joints[2] = temp[0];
                    joints[1] = temp[1];
                }
            }          
        }

        private void forward_kinetic(double[] join, double[] Loca)
        {
            Loca[0] = join[0] - d4;
            Loca[1] = a3 * Math.Cos(join[1] * Math.PI / 180 + join[2] * Math.PI / 180) + a2 * Math.Cos(join[1] * Math.PI / 180);
            Loca[2] = a3 * Math.Sin(join[1] * Math.PI / 180 + join[2] * Math.PI / 180) + a2 * Math.Sin(join[1] * Math.PI / 180);
        }

        private void GetstepP(double[] pre, double[] nex, double[] prep, double[] nexp, int[] step, int[] dir)
        {
            inverse_kinetic(pre[1], pre[2], pre[0], pre[3], prep);
            inverse_kinetic(nex[1], nex[2], nex[0], nex[3], nexp);
            nexp[1] = nexp[1] * 180 / Math.PI;
            nexp[2] = nexp[2] * 180 / Math.PI;
            nexp[3] = nexp[3] * 180 / Math.PI;
            prep[1] = prep[1] * 180 / Math.PI;
            prep[2] = prep[2] * 180 / Math.PI;
            prep[3] = prep[3] * 180 / Math.PI;

            double ang;

            if ((nexp[0] - prep[0]) > 0)
                dir[0] = 1;
            else
                dir[0] = 0;
            if ((nexp[1] - prep[1]) > 0)
            {
                dir[1] = 1;
            }               
            else
            {
                dir[1] = 0;
            }

            if (nex[1] == pre[1] && nex[2] == pre[2])
                ang = Math.Abs(nexp[1] - prep[1]) / 3;
            else if (dir[1] == 1)
            {
                ang = (Math.Abs(nexp[1] - prep[1]) + ofs) / 3;
            }
            else
                ang = Math.Abs(nexp[1] - prep[1]) / 3;

            if (dir[1] == 0)
            {
                if ((nexp[2] - prep[2] - ang) > 0)
                    dir[2] = 1;
                else
                    dir[2] = 0;
            }
            else
            {
                if ((nexp[2] - prep[2] + ang) > 0)
                    dir[2] = 1;
                else
                    dir[2] = 0;
            }
            if ((nexp[3] - prep[3]) > 0)
                dir[3] = 1;
            else
                dir[3] = 0;

            step[0] = Convert.ToInt32(Math.Abs((nexp[0] - prep[0]) * 259.0909090909091));
            if (nex[1] == pre[1] && nex[2] == pre[2])
                step[1] = Convert.ToInt32((Math.Abs(nexp[1] - prep[1]) / 0.01085526316));
            else if(dir[1] == 1)
                step[1] = Convert.ToInt32((Math.Abs(nexp[1] - prep[1]) + ofs)/ 0.01085526316);
            else
                step[1] = Convert.ToInt32(Math.Abs(nexp[1] - prep[1]) / 0.01085526316);
            if (dir[1] == 0)
                step[2] = Convert.ToInt32(Math.Abs((nexp[2] - prep[2] - ang) / 0.01875));
            else
                step[2] = Convert.ToInt32(Math.Abs((nexp[2] - prep[2] + ang) / 0.01875));
            step[3] = Convert.ToInt32(Math.Abs((nexp[3] - prep[3]) / 0.05625));

            pre[0] = nex[0];
            pre[1] = nex[1];
            pre[2] = nex[2];
            pre[3] = nex[3];
            prep[0] = nexp[0];
            prep[1] = nexp[1];
            prep[2] = nexp[2];
        }

        private void GetstepJ(double[] preeJ, double[] neexJ, int[] step, int[] dir)
        {
            preP[0] = curP[0];
            preP[1] = curP[1];
            preP[2] = curP[2];

            double ang;            

            if ((neexJ[0] - preeJ[0]) > 0)
                dir[0] = 1;
            else
                dir[0] = 0;
            if ((neexJ[1] - preeJ[1]) > 0)
                dir[1] = 1;
            else
                dir[1] = 0;

            if (neexJ[1] == preeJ[1])
                ang = Math.Abs(neexJ[1] - preeJ[1]) / 3;
            else if (dir[1] == 1)
                ang = (Math.Abs(neexJ[1] - preeJ[1]) + ofs) / 3;
            else
                ang = Math.Abs(neexJ[1] - preeJ[1]) / 3;

            if (dir[1] == 0)
            {
                if ((neexJ[2] - preeJ[2] - ang) > 0)
                    dir[2] = 1;
                else
                    dir[2] = 0;
            }
            else
            {
                if ((neexJ[2] - preeJ[2] + ang) > 0)
                    dir[2] = 1;
                else
                    dir[2] = 0;
            }
            if ((neexJ[3] - preeJ[3]) > 0)
                dir[3] = 1;
            else
                dir[3] = 0;

            step[0] = Convert.ToInt32(Math.Abs((neexJ[0] - preeJ[0]) * 259.0909090909091));
            if(neexJ[1] == preeJ[1])
                step[1] = Convert.ToInt32(Math.Abs(neexJ[1] - preeJ[1])/ 0.01085526316);
            else if (dir[1] == 1)
                step[1] = Convert.ToInt32((Math.Abs(neexJ[1] - preeJ[1]) + ofs) / 0.01085526316);
            else
                step[1] = Convert.ToInt32((Math.Abs(neexJ[1] - preeJ[1])) / 0.01085526316);
            if (dir[1] == 0)
                step[2] = Convert.ToInt32(Math.Abs((neexJ[2] - preeJ[2] - ang) / 0.01875));
            else
                step[2] = Convert.ToInt32(Math.Abs((neexJ[2] - preeJ[2] + ang) / 0.01875));
            step[3] = Convert.ToInt32(Math.Abs((neexJ[3] - preeJ[3]) / 0.05625));

            preeJ[0] = neexJ[0];
            preeJ[1] = neexJ[1];
            preeJ[2] = neexJ[2];
            preeJ[3] = neexJ[3];
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Setting.IsDisposed)
            {
                Setting = new Form2();
            }
            Setting.Show();
        }

        private void SynSpeed(int[] step)
        {
            Spe[0] = Properties.Settings.Default.Period1;
            Spe[1] = Properties.Settings.Default.Period2;

            Per[0] = Convert.ToInt32((60 * Math.Pow(10, 6)) / (Spe[0] * 2072.727273));
            Per[1] = Convert.ToInt32((60 * Math.Pow(10, 6)) / (Spe[1] * 33163.63636));

            if (step[2] != 0)
            {
                if (step[1] != 0)
                {
                    Per[2] = Per[1] * step[1] / step[2];
                    if (Per[2] < 499)
                        Per[2] = 999;
                }
       
                else
                    Per[2] = 999;
            }
            else
                Per[2] = 999;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult DRL = MessageBox.Show("Luận văn tốt nghiệp \r\nSCARA Arm PCB Drilling \r\nTrần Phương Nam","Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GetCurrPoint(int[] stp, int[] dr, int[] cstp, double[] currP, double[] crJ)
        {
            double[] rtdJ = new double[4];
            double[] prvJ = new double[4];
            if(dr[0] == 0)
            {
                rtdJ[0] = -(stp[0] - cstp[0])/ 259.0909090909091;
                prvJ[0] = preJ[0] + stp[0]/ 259.0909090909091;
            }
            else
            {
                rtdJ[0] = (stp[0] - cstp[0]) / 259.0909090909091;
                prvJ[0] = preJ[0] - stp[0] / 259.0909090909091;
            }
                
            if (dr[1] == 0)
            {
                rtdJ[1] = -(stp[1] - cstp[1])* 0.01085526316;
                prvJ[1] = preJ[1] + stp[1] * 0.01085526316;
            }
            else
            {
                rtdJ[1] = (stp[1] - cstp[1]) * 0.01085526316;
                prvJ[1] = preJ[1] - stp[1] * 0.01085526316;
            }
                
            if (dr[2] == 0)
            {
                rtdJ[2] = -rtdJ[1]/3 - (stp[2] - cstp[2]) * 0.01875;
                if(dr[1] == 0)
                    prvJ[2] = preJ[2] + stp[2] * 0.01875 - (stp[1] * 0.01085526316) / 3;
                else
                    prvJ[2] = preJ[2] + stp[2] * 0.01875 + (stp[1] * 0.01085526316) / 3;
            }
            else
            {
                rtdJ[2] = -rtdJ[1] / 3 + (stp[2] - cstp[2]) * 0.01875;
                if(dr[1] == 0)
                    prvJ[2] = preJ[2] - stp[2] * 0.01875 - (stp[1] * 0.01085526316) / 3;
                else
                    prvJ[2] = preJ[2] - stp[2] * 0.01875 + (stp[1] * 0.01085526316) / 3;
            }
                
            crJ[0] = rtdJ[0] + prvJ[0];
            crJ[1] = rtdJ[1] + prvJ[1];
            crJ[2] = rtdJ[2] + prvJ[2];
            forward_kinetic(crJ, currP);
        }

        private void btCalib_Click(object sender, EventArgs e)
        {
            IsCalibrating = true;
            COM.WriteLine("C");           
        }
        private void CalibT2a()
        {
            preJ[1] = 0;
            curJ[1] = -200;
            SendJC();
        }

        private void CalibT3a()
        {
            preJ[2] = 0;
            curJ[2] = -350;
            SendJC();
        }

        private void CalibD1a()
        {
            preJ[0] = 0;
            curJ[0] = 300;
            SendJC();
        }

        private void CalibT2b()
        {
            preJ[1] = 0;
            curJ[1] = Properties.Settings.Default.CT2;
            SendJC();
        }

        private void CalibT3b()
        {
            preJ[2] = 0;
            curJ[2] = Properties.Settings.Default.CT3;
            SendJC();
        }

        private void CalibD1b()
        {
            preJ[0] = 0;
            curJ[0] = Properties.Settings.Default.CD1;
            SendJC();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            COM.Close();
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            COM.Close();
        }

        private void refr()
        {
            Locat.Clear();
            Sizze.Clear();
            Counterr.Clear();
            Disst.Clear();
            Graph.GraphPane.CurveList.Clear();
            Graph.GraphPane.GraphObjList.Clear();
            Graph.Invalidate();
            curItem.Clear();
            donePoint.Clear();
            ListOfType.Clear();
            myLineItems.Clear();
            Graph.GraphPane.XAxis.Scale.Min = -300;
            Graph.GraphPane.XAxis.Scale.Max = 300;
            Graph.GraphPane.YAxis.Scale.Min = 0;
            Graph.GraphPane.YAxis.Scale.Max = 300;

            currPoint.Add(curP[2], curP[1]);
            curItem.Add(Graph.GraphPane.AddCurve("Vị trí hiện tại", currPoint, Color.Yellow, SymbolType.Square));
            curItem[0].Line.IsVisible = false;
            curItem[0].Symbol.Border.IsVisible = false;
            curItem[0].Symbol.Size = 3;
            curItem[0].Symbol.Fill = new Fill(Color.Yellow);
            //myPane.XAxis.Title.IsVisible = false;
            //myPane.YAxis.Title.IsVisible = false;
            //myPane.Legend.IsVisible = false;
            //myPane.Title.IsVisible = false;
            Graph.GraphPane.Chart.Fill = new Fill(Color.Black);
            Graph.AxisChange();
            Graph.Refresh();
        }

        private bool checkfile()
        {
            foreach (List<double[]> type in Counterr)
            {
                foreach (double[] xy in type)
                {
                    if (Math.Pow(xy[0]+ofsx, 2) + Math.Pow(xy[1]+ofsy, 2) > Math.Pow(a2 + a3, 2) + 0.1 || Math.Pow(xy[0]+ofsx, 2) + Math.Pow(xy[1]+ofsy, 2) < Math.Pow(a2 - a3, 2) - 0.1)
                        return false;
                }
            }
            return true;
        }
    }
}
