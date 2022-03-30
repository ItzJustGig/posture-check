using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

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
        private string directory = Directory.GetCurrentDirectory() + "\\sounds\\";

        struct Time
        {
            public int hour;
            public int min;
            public int sec;
        }

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
            if (postureCheck == 0 || !postureCheckBox.Checked)
                postureCheck = -1;

            breakCheck = Convert.ToInt32(breakTimeUpDown.Value*60);
            if (breakCheck == 0 || !breakCheckBox.Checked)
                breakCheck = -1;

            timer.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopTimer();

            if (!postureCheckBox.Checked)
                postureTimeUpDown.Enabled = false;
            else
                postureTimeUpDown.Enabled = true;

            if (!breakCheckBox.Checked)
                breakTimeUpDown.Enabled = false;
            else
                breakTimeUpDown.Enabled = true;
        }

        private void StopTimer()
        {
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            changeEnabled(true);
            timer.Stop();
            timer.Dispose();
            lblPostureTime.Text = "00:00:00";
            lblBreakTime.Text = "00:00:00";
        }

        private int RestartTimer(decimal val)
        {
            return Convert.ToInt32(val * 60);
        }

        private Time ConvertTime(int secs)
        {
            Time tempo;
            tempo.sec = secs;
            tempo.min = 0;
            tempo.hour = 0;
            
            while (tempo.sec > 60)
            {
                if (tempo.sec > 60)
                {
                    tempo.min++;
                    tempo.sec -= 60;
                }

                if (tempo.min >= 60)
                {
                    tempo.hour++;
                    tempo.min -= 60;
                }
            }

            return tempo;
        }

        private void PlaySound(string path)
        {
            SoundPlayer Sound = new SoundPlayer(path);
            Sound.Play();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (postureCheck > 0)
            {
                postureCheck--;
                Time posture = ConvertTime(postureCheck);
                lblPostureTime.Text = (posture.hour.ToString("00") + ":" + posture.min.ToString("00") + ":" + posture.sec.ToString("00"));
            }
                
            if (breakCheck > 0)
            {
                breakCheck--;
                Time breakC = ConvertTime(breakCheck);
                lblBreakTime.Text = (breakC.hour.ToString("00") + ":" + breakC.min.ToString("00") + ":" + breakC.sec.ToString("00"));
            }
            
            if (postureCheck == 0)
            {
                PlaySound(directory + "yes1.wav");
                postureCheck = RestartTimer(postureTimeUpDown.Value);
            }

            if (breakCheck == 0)
            {
                PlaySound(directory + "yes1.wav");
                breakCheck = RestartTimer(breakTimeUpDown.Value);
            }

        }
    }
}
