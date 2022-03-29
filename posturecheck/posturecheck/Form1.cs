using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace posturecheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int postureCheck;
        private int breakCheck;

        private void changeEnabled(bool set)
        {
            breakTimeUpDown.Enabled = set;
            breakCheckBox.Enabled = set;
            postureTimeUpDown.Enabled = set;
            postureCheckBox.Enabled = set;
        }

        private void postureCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!postureCheckBox.Checked)
                postureTimeUpDown.Enabled = false;
            else
                postureTimeUpDown.Enabled = true;
        }

        private void breakCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!breakCheckBox.Checked)
                breakTimeUpDown.Enabled = false;
            else
                breakTimeUpDown.Enabled = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            changeEnabled(false);
            postureCheck = Convert.ToInt32(postureTimeUpDown.Value*60);
            breakCheck = Convert.ToInt32(breakTimeUpDown.Value*60);
            timer.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopTimer();
        }

        private void StopTimer()
        {
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            changeEnabled(true);
            timer.Stop();
            timer.Dispose();
            lblPostureTime.Text = "00:00";
            lblBreakTime.Text = "00:00";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblPostureTime.Text = postureCheck--.ToString();
            if (postureCheck == 0)
                StopTimer();
            
        }
    }
}
