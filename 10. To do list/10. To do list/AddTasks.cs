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
        string taskName;

        public AddTasks(Menu Menu)
        {
            InitializeComponent();
            mainForm = Menu;
            comboBoxImportance.SelectedIndex = 0; // Valeur par défaut
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string taskName = nameNewTask.Text;
            string importance = comboBoxImportance.SelectedItem.ToString();
            DateTime dueDate = dateTimePickerDueDate.Value;

            // Add the task to the main form
            mainForm.AddTaskToList(taskName, importance, dueDate);

            this.Close();
        }
    }
}
