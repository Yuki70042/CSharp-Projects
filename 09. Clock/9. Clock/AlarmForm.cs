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
        private Form1 mainForm;
        

        public AlarmForm(Form1 form1)
            // Create the link between the main form : Form1 and the AlarmForm
        {
            InitializeComponent();
            mainForm = form1;
        }

        public void createAlarm_Click(object sender, EventArgs e)
        {
            DateTime selectTime = TimePicker1.Value;
            mainForm.AddAlarmToList(selectTime);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
