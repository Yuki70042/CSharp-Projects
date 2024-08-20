using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9.Clock
{ 
    public partial class Form1 : Form
    {
        // --  Initialize variables

        int hours, minutes;
        int seconds = 1; // Initialize at one for the timer_tick

        int tickCount = 0; // Add a tick counter to use only one timer
        int intervalCount = 900; // 800 ticks = 8 * timerclock_Tick

        private SoundPlayer alarmSound; // Initialize a sound object "alarmSound"
        AlarmForm AlarmForm;

        public Form1()
        {
            InitializeComponent();
            ContextMenuStrip = MenuListView;


            string soundFilePathAlarm = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sounds", "alarmSound.wav");
            alarmSound = new SoundPlayer(soundFilePathAlarm);
        }



        private void timerclock_Tick(object sender, EventArgs e)
            // Displays current time
        {
            Clock.Text = DateTime.Now.ToString("HH:mm:ss");
            tickCount += 100; 

            if (tickCount >= intervalCount)
            {
                tickCount = 0; // reset the ticker Count
                StartAlarm();  // Check if an alarm is programmed
            }
        }


        // ----------- Alarm part
        private void Alarm_Click(object sender, EventArgs e)
            // Open the second form 
        {
            AlarmForm alarmForm = new AlarmForm(this); 
            alarmForm.ShowDialog(); // Open the AlarmForm            
        }

        public void AddAlarmToList(DateTime alarmTime)
            // This method add the new alarm in the list in the correct format
            // This method is public to be use in the second form (AlarmForm)
        {
            listAlarms.Items.Add(alarmTime.ToString("HH:mm:ss"));
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

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listAlarms.SelectedItems.Count > 0)
                // If Select an Item with right Click
            {
                listAlarms.Items.Remove(listAlarms.SelectedItems[0]);
                // Delete the select Item
            }
            else
            {
                MessageBox.Show("No items to delete");               
            }
        }


        private void StartAlarm()
        {
            for (int i = 0; i < listAlarms.Items.Count ; i++)
            {
                // Convertir l'élément en chaîne
                string alarmTime = listAlarms.Items[i].ToString();

                // Vérifier si l'élément contient exactement l'heure actuelle au format HH:mm:ss
                if (alarmTime.Contains(DateTime.Now.ToString("HH:mm:ss")))
                {
                    alarmSound.Play();
                    MessageBox.Show("DING");
                    listAlarms.Items.Remove(listAlarms.Items[i]);
                }
            }         
        }
    }
    
}
