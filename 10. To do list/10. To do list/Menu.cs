using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _10.To_do_list
{
    public partial class Menu : Form
    {
        AddTasks AddTasks;


        public Menu()
        {
            InitializeComponent();
            LoadTasks();
            this.FormClosing += new FormClosingEventHandler(Menu_FormClosing);
        }


        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            AddTasks addTasks = new AddTasks(this);
            addTasks.ShowDialog();
            
        }

        private void BtnRemoveTask_Click(object sender, EventArgs e)
        {
            List<ListViewItem> itemsToRemove = new List<ListViewItem>();

            // Parcourir les éléments de la liste
            foreach (ListViewItem task in listTask.Items)
            {
                // Vérifier si l'élément est une CheckBox et si elle est cochée
                if (task.Checked)
                {
                    // Ajouter à la liste des éléments à supprimer
                    itemsToRemove.Add(task);
                }
            }

            // Supprimer les éléments cochés de la liste principale
            foreach (var item in itemsToRemove)
            {
                listTask.Items.Remove(item);
            }


        }

        public void AddTaskToList(string newTask)
        {
            listTask.Items.Add(newTask);
        }

        private void LoadTasks()
        {
            if (System.IO.File.Exists("tasks.txt"))
            {
                string[] tasksFromFile = System.IO.File.ReadAllLines("tasks.txt");

                foreach (string taskLine in tasksFromFile)
                {
                    //Retrieve the status of the task(checked or not) and the text
                    bool isChecked = taskLine.StartsWith("1");
                    string taskText = taskLine.Substring(1);

                    ListViewItem item = new ListViewItem(taskText);
                    item.Checked = isChecked;

                    listTask.Items.Add(item);
                }
            }
        }

         
        private void SaveTasks()
        {
            List<string> tasksToSave = new List<string>();

            foreach (ListViewItem task in listTask.Items)
            {
                // Format : [0|1]TaskDescription
                // 0 for not finished, 1 for finished
                string taskLine = (task.Checked ? "1" : "0") + task.Text;
                tasksToSave.Add(taskLine);
            }

            System.IO.File.WriteAllLines("tasks.txt", tasksToSave);
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveTasks();
        }
    }
}
