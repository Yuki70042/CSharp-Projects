namespace _9.Clock
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clockArea = new System.Windows.Forms.TableLayoutPanel();
            this.Clock = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Alarm = new System.Windows.Forms.Button();
            this.StopWatch_Button = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.listAlarms = new System.Windows.Forms.ListView();
            this.timerclock = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.MenuListBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clockArea.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.MenuListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // clockArea
            // 
            this.clockArea.ColumnCount = 1;
            this.clockArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.clockArea.Controls.Add(this.Clock, 0, 0);
            this.clockArea.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.clockArea.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.clockArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clockArea.Location = new System.Drawing.Point(0, 0);
            this.clockArea.Name = "clockArea";
            this.clockArea.RowCount = 3;
            this.clockArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.24267F));
            this.clockArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.97554F));
            this.clockArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.78179F));
            this.clockArea.Size = new System.Drawing.Size(570, 500);
            this.clockArea.TabIndex = 0;
            // 
            // Clock
            // 
            this.Clock.AutoSize = true;
            this.Clock.BackColor = System.Drawing.Color.LightGray;
            this.Clock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock.Location = new System.Drawing.Point(3, 0);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(564, 196);
            this.Clock.TabIndex = 0;
            this.Clock.Text = "\"HH:MM:SS\"";
            this.Clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Alarm, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.StopWatch_Button, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 199);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(564, 83);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Alarm
            // 
            this.Alarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Alarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Alarm.Location = new System.Drawing.Point(5, 5);
            this.Alarm.Margin = new System.Windows.Forms.Padding(5);
            this.Alarm.Name = "Alarm";
            this.Alarm.Size = new System.Drawing.Size(272, 73);
            this.Alarm.TabIndex = 0;
            this.Alarm.Text = "Add Alarm";
            this.Alarm.UseVisualStyleBackColor = true;
            this.Alarm.Click += new System.EventHandler(this.Alarm_Click);
            // 
            // StopWatch_Button
            // 
            this.StopWatch_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopWatch_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StopWatch_Button.Location = new System.Drawing.Point(287, 5);
            this.StopWatch_Button.Margin = new System.Windows.Forms.Padding(5);
            this.StopWatch_Button.Name = "StopWatch_Button";
            this.StopWatch_Button.Size = new System.Drawing.Size(272, 73);
            this.StopWatch_Button.TabIndex = 1;
            this.StopWatch_Button.Text = "Timer";
            this.StopWatch_Button.UseVisualStyleBackColor = true;
            this.StopWatch_Button.Click += new System.EventHandler(this.StopWatch_Button_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.timeLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.listAlarms, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 288);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(564, 209);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(285, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(276, 209);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "00:00:00";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listAlarms
            // 
            this.listAlarms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listAlarms.HideSelection = false;
            this.listAlarms.Location = new System.Drawing.Point(3, 3);
            this.listAlarms.Name = "listAlarms";
            this.listAlarms.Size = new System.Drawing.Size(276, 203);
            this.listAlarms.TabIndex = 1;
            this.listAlarms.UseCompatibleStateImageBehavior = false;
            this.listAlarms.ContextMenuStripChanged += new System.EventHandler(this.MenuListBox);
            // 
            // timerclock
            // 
            this.timerclock.Enabled = true;
            this.timerclock.Tick += new System.EventHandler(this.timerclock_Tick);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MenuListBox
            // 
            this.MenuListBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.MenuListBox.Name = "MenuListBox";
            this.MenuListBox.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 500);
            this.Controls.Add(this.clockArea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "My Tiny Clock";
            this.clockArea.ResumeLayout(false);
            this.clockArea.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.MenuListBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel clockArea;
        private System.Windows.Forms.Label Clock;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Alarm;
        private System.Windows.Forms.Button StopWatch_Button;
        private System.Windows.Forms.Timer timerclock;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ContextMenuStrip MenuListBox;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ListView listAlarms;
    }
}

