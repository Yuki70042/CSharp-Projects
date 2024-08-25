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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

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


            // Activer l'événement ItemDrag
            listTask.ItemDrag += listTask_ItemDrag;

            // Activer l'événement DragEnter
            listTask.DragEnter += listTask_DragEnter;

            // Activer l'événement DragDrop
            listTask.DragDrop += listTask_DragDrop;

            // Configurer le contrôle pour autoriser le drop
            listTask.AllowDrop = true;
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
            // Start the programm and load the different tasks
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
            // Save the current taks in a text file
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
            // When the programm ends, save the taks
        {
            SaveTasks();
        }


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
            // Remove the task select with right click
        {
            foreach (ListViewItem selectedItem in listTask.SelectedItems)
            {
                listTask.Items.Remove(selectedItem);
                SaveTasks(); // Save the current List with modifications
            }
        }

        private void listTask_MouseDown(object sender, MouseEventArgs e)
            // Allows you to display the delete option only on tasks already created
        {
            //  Check if the right mouse button was clicked
            if (e.Button == MouseButtons.Right)
            {
                // Obtenir l'élément sous le curseur
                ListViewItem item = listTask.GetItemAt(e.X, e.Y);

                if (item != null)
                {
                    // Select the item you right-clicked on
                    item.Selected = true;
                    // Afficher le menu contextuel sur l'élément
                    listTask.ContextMenuStrip = contextMenuStrip1;
                }
                else
                {
                    // Prevent context menu from showing if no item is selected
                    listTask.ContextMenuStrip = null;
                }
            }
        }

        private void listTask_ItemDrag(object sender, ItemDragEventArgs e)
        {
            // Start drag and drop operation
            DoDragDrop(e.Item, DragDropEffects.Move);

        }

        private void listTask_DragEnter(object sender, DragEventArgs e)
        {
            // Check if it is the good format and if the movement possible
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listTask_DragDrop(object sender, DragEventArgs e)
            // Drag and Drop function
        {
            // recover the item that is moved
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                ListViewItem draggedItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));

                // Calculate the new position in the listView
                Point pt = listTask.PointToClient(new Point(e.X, e.Y));
                ListViewItem targetItem = listTask.GetItemAt(pt.X, pt.Y);

                if (targetItem != null)
                {
                    int targetIndex = targetItem.Index;
                    listTask.Items.Remove(draggedItem);
                    listTask.Items.Insert(targetIndex, draggedItem);
                }
            }
        }
    }
}
