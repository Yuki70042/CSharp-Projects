using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9.Clock
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        int hours, minutes;
        int secondes = 1;


        private void timerclock_Tick(object sender, EventArgs e)
        {
            Clock.Text = DateTime.Now.ToString("HH:mm:ss");
        }



        // ----------- Alarm part
        private void Alarm_Click(object sender, EventArgs e)
        {
            var formPopup = new Form();
            formPopup.Show(this); // if you need non-modal window
        }



        // ------------- Timer event
        private void timer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = GetFormattedTime();
            secondes++;

            if (secondes == 60)
            {
                secondes = 0;
                minutes++;
            }
            else if (minutes == 60)
            {
                minutes = 0;
                hours++;
            }
        }


        private void StopWatch_Button_Click(object sender, EventArgs e)
        {

            if (StopWatch_Button.Text == "Timer")
            {
                StopWatch_Button.Text = "Stop";
                timer.Start();
            }

            else if (StopWatch_Button.Text == "Stop")
            {
                StopWatch_Button.Text = "Reset";
                timer.Stop();
            }

            else
            {
                StopWatch_Button.Text = "Timer";             
                hours = minutes = secondes = 0;
                timeLabel.Text = GetFormattedTime();
            }
        }

        string GetFormattedTime()
        {
            return $"{hours:D2}:{minutes:D2}:{secondes:D2}"; // D2 put the number in a "00" Format
        }
    }
    
}
