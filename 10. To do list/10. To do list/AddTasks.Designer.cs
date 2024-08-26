namespace _10.To_do_list
{
    partial class AddTasks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nameNewTask = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.comboBoxImportance = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDueDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the Name of the Task";
            // 
            // nameNewTask
            // 
            this.nameNewTask.Location = new System.Drawing.Point(72, 62);
            this.nameNewTask.Name = "nameNewTask";
            this.nameNewTask.Size = new System.Drawing.Size(186, 20);
            this.nameNewTask.TabIndex = 2;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(107, 291);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(105, 37);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // comboBoxImportance
            // 
            this.comboBoxImportance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxImportance.FormattingEnabled = true;
            this.comboBoxImportance.Items.AddRange(new object[] {
            "★",
            "★★",
            "★★★",
            "★★★★",
            "★★★★★"});
            this.comboBoxImportance.Location = new System.Drawing.Point(72, 143);
            this.comboBoxImportance.Name = "comboBoxImportance";
            this.comboBoxImportance.Size = new System.Drawing.Size(186, 21);
            this.comboBoxImportance.TabIndex = 4;
            // 
            // dateTimePickerDueDate
            // 
            this.dateTimePickerDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDueDate.Location = new System.Drawing.Point(72, 221);
            this.dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            this.dateTimePickerDueDate.Size = new System.Drawing.Size(186, 20);
            this.dateTimePickerDueDate.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Which Importance?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date Limit?";
            // 
            // AddTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 376);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerDueDate);
            this.Controls.Add(this.comboBoxImportance);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.nameNewTask);
            this.Controls.Add(this.label1);
            this.Name = "AddTasks";
            this.Text = "AddTasks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameNewTask;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ComboBox comboBoxImportance;
        private System.Windows.Forms.DateTimePicker dateTimePickerDueDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}