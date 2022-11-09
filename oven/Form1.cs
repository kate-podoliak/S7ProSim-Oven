using System;
using System.Windows.Forms;
using S7PROSIMLib;

namespace oven
{
    public partial class Form1 : Form
    {
        // library that allows to connect to the SIMATIC program
        public S7ProSim PS = new S7ProSim();

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Run_Click(object sender, EventArgs e)
        {
            // connection to simatic SIMATIC
            PS.Connect();
            // the RUN state is setted
            PS.SetState("RUN");
            // scan mode is seted to Continuous
            PS.SetScanMode(ScanModeConstants.ContinuousScan);

            // change label
            label_Status.Text = "ПІДКЛЮЧЕННЯ";
            label_Status.ForeColor = System.Drawing.Color.Green;
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            // the STOP state is setted
            PS.SetState("STOP");
            // disconnection from the SIMATIC program
            PS.Disconnect();

            // change label
            label_Status.Text = "ВІДКЛЮЧЕННЯ";
            label_Status.ForeColor = System.Drawing.Color.Red;
        }

        private void checkBox_I00_CheckedChanged(object sender, EventArgs e)
        {
            // read I0.0 
            object I0_0 = checkBox_I00.Checked;
            // record I0.0
            PS.WriteInputPoint(0, 0, ref I0_0);
        }

        private void checkBox_I01_CheckedChanged(object sender, EventArgs e)
        {
            // read I0.1
            object I0_1 = checkBox_I01.Checked;
            // record I0.1
            PS.WriteInputPoint(0, 1, ref I0_1);
        }

        private void checkBox_I02_CheckedChanged(object sender, EventArgs e)
        {
            // read I0.2
            object I0_2 = checkBox_I02.Checked;
            // record I0.2
            PS.WriteInputPoint(0, 2, ref I0_2);
        }

        private void checkBox_I03_CheckedChanged(object sender, EventArgs e)
        {
            // read I0.3
            object I0_3 = checkBox_I03.Checked;
            // record I0.3
            PS.WriteInputPoint(0, 3, ref I0_3);
        }

        private void timer_Read_Output_Tick(object sender, EventArgs e)
        {
            // read Q0.0
            object Q0_0 = false;
            // record Q0.0
            PS.ReadOutputPoint(0, 0, PointDataTypeConstants.S7_Bit, ref Q0_0);

            // if Q0.0 does not get a value 1
            if (!(bool)Q0_0)
            {
                label_Q00.Text = "СИГНАЛІЗАЦІЯ ВИМКНЕНА";
                label_Q00.ForeColor = System.Drawing.Color.Red;
            }
            else
            {                
                label_Q00.Text = "СИГНАЛІЗАЦІЯ УВІМКНЕНО";
                label_Q00.ForeColor = System.Drawing.Color.Green;
            }
        }
    }
}
