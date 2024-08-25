using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10.To_do_list
{
    public partial class AddTasks : Form
    {
        private Menu mainForm; 
        string newTask;

        public AddTasks(Menu Menu)
        {
            InitializeComponent();
            mainForm = Menu;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
           newTask = nameNewTask.Text;
           mainForm.AddTaskToList(newTask);
           this.Close();
        }
    }
}
