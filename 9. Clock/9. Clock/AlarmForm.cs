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
        public AlarmForm()
        {
            InitializeComponent();
        }

        DateTime addAlarm;

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createAlarm_Click(object sender, EventArgs e)
        {
            addAlarm = TimePicker1.Value;
            label1.Text = addAlarm.ToString();
        }
    }
}
