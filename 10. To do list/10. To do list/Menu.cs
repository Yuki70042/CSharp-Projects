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
    public partial class Menu : Form
    {
        AddTasks AddTasks;

        public Menu()
        {
            InitializeComponent();            
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
    }
}
