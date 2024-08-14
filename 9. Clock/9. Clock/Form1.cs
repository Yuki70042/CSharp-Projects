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
        AlarmForm AlarmForm;
        public string listAlarm;

        public Form1()
        {
            InitializeComponent();
        }

        // --  Initialize variables

        int hours, minutes;
        int seconds = 1; // Initialize at one for the timer_tick


        private void timerclock_Tick(object sender, EventArgs e)
            // Displays current time
        {
            Clock.Text = DateTime.Now.ToString("HH:mm:ss");
        }



        // ----------- Alarm part
        private void Alarm_Click(object sender, EventArgs e)
            //
        {           
            using (var alarmForm = new AlarmForm())
            alarmForm.ShowDialog();
            listAlarms.Items.Add(hours);
        }

        private void ActivatesAlarm()
        {
            
        }



        // ------------- StopWatch event
        private void timer_Tick(object sender, EventArgs e)
            // Every Second, display the new value in the timer and add 1 second
        {
            timeLabel.Text = GetFormattedTime();
            seconds++;

            if (seconds == 60)
                // 60 seconds = one minute, reset seconds
            {
                seconds = 0;
                minutes++;
            }
            else if (minutes == 60)
                // 60 minutes = one hour, reset minutes
            {
                minutes = 0;
                hours++;
            }
        }


        private void StopWatch_Button_Click(object sender, EventArgs e)
        {

            if (StopWatch_Button.Text == "Timer")
                // Start the timer and change the button Text
            {
                StopWatch_Button.Text = "Stop";
                timer.Start();
            }

            else if (StopWatch_Button.Text == "Stop")
                // If the timer already start, Stop it and change the button Text
            {
                StopWatch_Button.Text = "Reset";
                timer.Stop();
            }

            else
            // If it's stop, reset the timer when the button is press
            {
                StopWatch_Button.Text = "Timer";             
                hours = minutes = seconds = 0;
                timeLabel.Text = GetFormattedTime();
            }
        }

        string GetFormattedTime()
            // Return the time in the good format ('00/00/00')
        {
            return $"{hours:D2}:{minutes:D2}:{seconds:D2}"; // D2 put the number in a "00" Format
        }



    }
    
}
