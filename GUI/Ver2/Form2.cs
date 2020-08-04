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
using System.IO;

namespace Ver2
{
    public partial class Form2 : Form
    {

        int lenport = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            if (lenport != ports.Length)
            {
                lenport = ports.Length;
                CbCOM.Items.Clear();
                for (int j = 0; j < lenport; j++)
                {
                    CbCOM.Items.Add(ports[j]);
                }
            }
        }

        private void BtAppSerial_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PortName = CbCOM.Text;
            Properties.Settings.Default.BaudRate = Convert.ToInt32(CbBaud.Text);
            Properties.Settings.Default.DataBits = Convert.ToInt32(CbDataB.Text);
            Properties.Settings.Default.StopBits = (StopBits)Enum.Parse(typeof(StopBits), CbStopB.Text);
            Properties.Settings.Default.Parity = (Parity)Enum.Parse(typeof(Parity), CbParity.Text);
        }

        private void BtSetS_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Period1 = Convert.ToInt32(TbSpeed1.Text);
            Properties.Settings.Default.Period2 = Convert.ToInt32(TbSpeed2.Text);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CbCOM.Text = Properties.Settings.Default.PortName;
            CbBaud.Text = Properties.Settings.Default.BaudRate.ToString();
            CbDataB.Text = Properties.Settings.Default.DataBits.ToString();
            CbStopB.Text = Properties.Settings.Default.StopBits.ToString();
            CbParity.Text = Properties.Settings.Default.Parity.ToString();
            TbSpeed1.Text = Properties.Settings.Default.Period1.ToString();
            TbSpeed2.Text = Properties.Settings.Default.Period2.ToString();
            CLT2.Text = Properties.Settings.Default.CT2.ToString();
            CLT3.Text = Properties.Settings.Default.CT3.ToString();
            CLD1.Text = Properties.Settings.Default.CD1.ToString();
        }

        private void btSetCalib_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CT2 = Convert.ToDouble(CLT2.Text);
            Properties.Settings.Default.CT3 = Convert.ToDouble(CLT3.Text);
            Properties.Settings.Default.CD1 = Convert.ToDouble(CLD1.Text);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
