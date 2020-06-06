using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLights
{
    public partial class TrafficLights : Form
    {
        private Timer timerSwitch;
        private int timeCounter = 0;

        public TrafficLights()
        {
            InitializeComponent();
            InitializeTrafficLights();
            InitializeTimerSwitch();
        }

        private void InitializeTimerSwitch()
        {
            timerSwitch = new Timer();
            timerSwitch.Interval = 1000;
            timerSwitch.Tick += new EventHandler(TimerSwitch_Tick);
            timerSwitch.Start();
        }

        private void TimerSwitch_Tick(object sender, EventArgs e)
        {
            if(timeCounter == 0)
            {
                redLight.BackColor = Color.Red;
            }
            else if(timeCounter == 3)
            {
                redLight.BackColor = Color.Gray;
                yellowLight.BackColor = Color.Yellow;
            }
            else if(timeCounter == 6)
            {
                yellowLight.BackColor = Color.Gray;
                greenLight.BackColor = Color.Green;
            }
            else if(timeCounter == 9)
            {
                greenLight.BackColor = Color.Gray;
                yellowLight.BackColor = Color.Yellow;
            }
            else if (timeCounter == 12)
            {
                yellowLight.BackColor = Color.Gray;
                redLight.BackColor = Color.Red;
                timeCounter = -1;
            }
            timeCounter++;
            //if(redLight.BackColor == Color.Gray)
            //{
            //    redLight.BackColor = Color.Red;
            //}
            //else
            //{
            //    redLight.BackColor = Color.Gray;
            //}
        }

        private void InitializeTrafficLights()
        {
            redLight.BackColor = Color.Gray;
            yellowLight.BackColor = Color.Gray;
            greenLight.BackColor = Color.Gray;
        }
    }
}
