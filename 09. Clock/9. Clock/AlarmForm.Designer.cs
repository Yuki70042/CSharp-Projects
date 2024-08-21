namespace _9.Clock
{
    partial class AlarmForm
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
            this.TimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.close_Button = new System.Windows.Forms.Button();
            this.createAlarm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimePicker1
            // 
            this.TimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker1.Location = new System.Drawing.Point(31, 52);
            this.TimePicker1.Name = "TimePicker1";
            this.TimePicker1.ShowUpDown = true;
            this.TimePicker1.Size = new System.Drawing.Size(200, 20);
            this.TimePicker1.TabIndex = 0;
            // 
            // close_Button
            // 
            this.close_Button.Location = new System.Drawing.Point(31, 107);
            this.close_Button.Name = "close_Button";
            this.close_Button.Size = new System.Drawing.Size(75, 23);
            this.close_Button.TabIndex = 1;
            this.close_Button.Text = "Close";
            this.close_Button.UseVisualStyleBackColor = true;
            this.close_Button.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // createAlarm
            // 
            this.createAlarm.Location = new System.Drawing.Point(156, 107);
            this.createAlarm.Name = "createAlarm";
            this.createAlarm.Size = new System.Drawing.Size(75, 23);
            this.createAlarm.TabIndex = 2;
            this.createAlarm.Text = "Create";
            this.createAlarm.UseVisualStyleBackColor = true;
            this.createAlarm.Click += new System.EventHandler(this.createAlarm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "At what time to add an alarm?";
            // 
            // AlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 144);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createAlarm);
            this.Controls.Add(this.close_Button);
            this.Controls.Add(this.TimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AlarmForm";
            this.Text = "Alarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker TimePicker1;
        private System.Windows.Forms.Button close_Button;
        private System.Windows.Forms.Button createAlarm;
        private System.Windows.Forms.Label label1;
    }
}