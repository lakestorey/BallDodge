namespace BallDodge
{
    partial class HighScoreScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.highscoreLabel = new System.Windows.Forms.Label();
            this.highscoreDisplay = new System.Windows.Forms.Label();
            this.mainMenuLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // highscoreLabel
            // 
            this.highscoreLabel.AutoSize = true;
            this.highscoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.highscoreLabel.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.highscoreLabel.ForeColor = System.Drawing.Color.White;
            this.highscoreLabel.Location = new System.Drawing.Point(112, 37);
            this.highscoreLabel.Name = "highscoreLabel";
            this.highscoreLabel.Size = new System.Drawing.Size(577, 136);
            this.highscoreLabel.TabIndex = 0;
            this.highscoreLabel.Text = "High Scores";
            // 
            // highscoreDisplay
            // 
            this.highscoreDisplay.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highscoreDisplay.Location = new System.Drawing.Point(159, 201);
            this.highscoreDisplay.Name = "highscoreDisplay";
            this.highscoreDisplay.Size = new System.Drawing.Size(483, 242);
            this.highscoreDisplay.TabIndex = 1;
            this.highscoreDisplay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mainMenuLabel
            // 
            this.mainMenuLabel.AutoSize = true;
            this.mainMenuLabel.BackColor = System.Drawing.Color.Black;
            this.mainMenuLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainMenuLabel.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuLabel.ForeColor = System.Drawing.Color.White;
            this.mainMenuLabel.Location = new System.Drawing.Point(612, 491);
            this.mainMenuLabel.Name = "mainMenuLabel";
            this.mainMenuLabel.Size = new System.Drawing.Size(187, 47);
            this.mainMenuLabel.TabIndex = 2;
            this.mainMenuLabel.Text = "Main Menu";
            // 
            // HighScoreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BallDodge.Properties.Resources.dodgeball_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.mainMenuLabel);
            this.Controls.Add(this.highscoreDisplay);
            this.Controls.Add(this.highscoreLabel);
            this.DoubleBuffered = true;
            this.Name = "HighScoreScreen";
            this.Size = new System.Drawing.Size(800, 550);
            this.Load += new System.EventHandler(this.HighScoreScreen_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.HighScoreScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label highscoreLabel;
        private System.Windows.Forms.Label highscoreDisplay;
        private System.Windows.Forms.Label mainMenuLabel;
    }
}
