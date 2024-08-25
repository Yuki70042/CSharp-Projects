namespace _10.To_do_list
{
    partial class Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Title = new System.Windows.Forms.Label();
            this.listTask = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BtnAddTask = new System.Windows.Forms.Button();
            this.BtnRemoveTask = new System.Windows.Forms.Button();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("MV Boli", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(167, 19);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(188, 44);
            this.Title.TabIndex = 0;
            this.Title.Text = "To Do List";
            // 
            // listTask
            // 
            this.listTask.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listTask.AllowColumnReorder = true;
            this.listTask.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listTask.CheckBoxes = true;
            this.listTask.ContextMenuStrip = this.contextMenuStrip1;
            this.listTask.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTask.HideSelection = false;
            this.listTask.LabelEdit = true;
            this.listTask.Location = new System.Drawing.Point(44, 85);
            this.listTask.Name = "listTask";
            this.listTask.Size = new System.Drawing.Size(446, 374);
            this.listTask.TabIndex = 1;
            this.listTask.UseCompatibleStateImageBehavior = false;
            this.listTask.View = System.Windows.Forms.View.List;
            this.listTask.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listTask_ItemDrag);
            this.listTask.DragDrop += new System.Windows.Forms.DragEventHandler(this.listTask_DragDrop);
            this.listTask.DragEnter += new System.Windows.Forms.DragEventHandler(this.listTask_DragEnter);
            this.listTask.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listTask_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 26);
            // 
            // BtnAddTask
            // 
            this.BtnAddTask.Location = new System.Drawing.Point(77, 498);
            this.BtnAddTask.Name = "BtnAddTask";
            this.BtnAddTask.Size = new System.Drawing.Size(155, 57);
            this.BtnAddTask.TabIndex = 2;
            this.BtnAddTask.Text = "Add Task";
            this.BtnAddTask.UseVisualStyleBackColor = true;
            this.BtnAddTask.Click += new System.EventHandler(this.BtnAddTask_Click);
            // 
            // BtnRemoveTask
            // 
            this.BtnRemoveTask.Location = new System.Drawing.Point(308, 498);
            this.BtnRemoveTask.Name = "BtnRemoveTask";
            this.BtnRemoveTask.Size = new System.Drawing.Size(153, 57);
            this.BtnRemoveTask.TabIndex = 3;
            this.BtnRemoveTask.Text = "Remove Tasks Done";
            this.BtnRemoveTask.UseVisualStyleBackColor = true;
            this.BtnRemoveTask.Click += new System.EventHandler(this.BtnRemoveTask_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Remove the Task";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(535, 606);
            this.Controls.Add(this.BtnRemoveTask);
            this.Controls.Add(this.BtnAddTask);
            this.Controls.Add(this.listTask);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Menu";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ListView listTask;
        private System.Windows.Forms.Button BtnAddTask;
        private System.Windows.Forms.Button BtnRemoveTask;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

