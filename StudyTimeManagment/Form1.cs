using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyTimeManagment
{
    public partial class Form1 : Form
    {
        SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\ring01.wav");
        private System.Windows.Forms.Timer timer;
        private int curTime = 20;
        public int studyTime = 52 * 60;
        public int leisureTime = 17 * 60;
        private bool isStudying = true;
        private bool isCounting = false;
        private bool isPlaying = false;
        public Form1()
        {
            InitializeComponent();
            curTime = studyTime;
            ModelLabel.Text = "Study: 52min\nRest: 17min";
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; //one second
            //after every tick do function
            timer.Tick += new EventHandler(changeTime);
        }
        private void StartStopBtn_Click(object sender, EventArgs e)
        {
            isPlaying = false;
            simpleSound.Stop();
            isCounting = !isCounting;
            if(isCounting)
            {
                TimeSpan time = TimeSpan.FromSeconds(curTime);
                TimerLabel.Text = time.ToString(@"mm\:ss");
                timer.Start();
                StartStopBtn.Text = "Stop";
            }
            else
            {
                timer.Stop();
                StartStopBtn.Text = "Start";
            }
        }
        private void changeTime(object state, EventArgs e)
        {
            curTime--;
            if(curTime<=0)
            {
                timer.Stop();
                TimerLabel.Text = "Times Up";
                isStudying = !isStudying;
                isCounting=false;
                if(isStudying)
                {
                    StartStopBtn.Text = "Start studying";
                    curTime = studyTime;
                }
                else
                {
                    StartStopBtn.Text = "Start rest";
                    curTime = leisureTime;
                }
                if(!isPlaying)
                {
                    simpleSound.PlayLooping();
                    isPlaying = true;
                }
            }
            else
            {
                TimeSpan time = TimeSpan.FromSeconds(curTime);
                TimerLabel.Text = time.ToString(@"mm\:ss");
            }
        }
    }
}
