using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9.Clock
{
    public partial class AlarmForm : Form
    {
        public DateTime alarm;
        public string test;
        Form1 Form1;

        public AlarmForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void createAlarm_Click(object sender, EventArgs e)
        {
            alarm = TimePicker1.Value;
            label1.Text = alarm.ToString();
            Close();
        }

    }
}
