namespace _9.Pong
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
            this.player = new System.Windows.Forms.PictureBox();
            this.cpu = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.playerLabel = new System.Windows.Forms.Label();
            this.cpuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.RoyalBlue;
            this.player.Location = new System.Drawing.Point(12, 208);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(27, 127);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // cpu
            // 
            this.cpu.BackColor = System.Drawing.Color.RoyalBlue;
            this.cpu.Location = new System.Drawing.Point(889, 208);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(27, 127);
            this.cpu.TabIndex = 1;
            this.cpu.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ball.Location = new System.Drawing.Point(431, 260);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(27, 26);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 19;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.playerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.ForeColor = System.Drawing.Color.Chartreuse;
            this.playerLabel.Location = new System.Drawing.Point(198, 9);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(38, 25);
            this.playerLabel.TabIndex = 3;
            this.playerLabel.Text = "00";
            // 
            // cpuLabel
            // 
            this.cpuLabel.AutoSize = true;
            this.cpuLabel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.cpuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.cpuLabel.Location = new System.Drawing.Point(690, 9);
            this.cpuLabel.Name = "cpuLabel";
            this.cpuLabel.Size = new System.Drawing.Size(38, 25);
            this.cpuLabel.TabIndex = 4;
            this.cpuLabel.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(928, 574);
            this.Controls.Add(this.cpuLabel);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.cpu);
            this.Controls.Add(this.player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Pong Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox cpu;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label cpuLabel;
    }
}

