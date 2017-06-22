namespace BallDodge
{
    partial class EndGameScreen
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
            this.replayLabel = new System.Windows.Forms.Label();
            this.mainmenuLabel = new System.Windows.Forms.Label();
            this.nameText1 = new System.Windows.Forms.Label();
            this.nameText3 = new System.Windows.Forms.Label();
            this.nameText2 = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // replayLabel
            // 
            this.replayLabel.AutoSize = true;
            this.replayLabel.BackColor = System.Drawing.Color.Transparent;
            this.replayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replayLabel.ForeColor = System.Drawing.Color.White;
            this.replayLabel.Location = new System.Drawing.Point(110, 441);
            this.replayLabel.Name = "replayLabel";
            this.replayLabel.Size = new System.Drawing.Size(262, 68);

            this.replayLabel.TabIndex = 3;
            this.replayLabel.Text = "Play Again";
            // 
            // mainmenuLabel
            // 
            this.mainmenuLabel.AutoSize = true;
            this.mainmenuLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainmenuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainmenuLabel.ForeColor = System.Drawing.Color.White;
            this.mainmenuLabel.Location = new System.Drawing.Point(416, 441);
            this.mainmenuLabel.Name = "mainmenuLabel";
            this.mainmenuLabel.Size = new System.Drawing.Size(271, 55);
            this.mainmenuLabel.TabIndex = 4;
            this.mainmenuLabel.Text = "Main Menu";
            // 
            // nameText1
            // 
            this.nameText1.BackColor = System.Drawing.Color.Black;
            this.nameText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nameText1.ForeColor = System.Drawing.Color.White;
            this.nameText1.Location = new System.Drawing.Point(174, 91);
            this.nameText1.Name = "nameText1";
            this.nameText1.Size = new System.Drawing.Size(150, 150);
            this.nameText1.TabIndex = 0;
            this.nameText1.Text = "A";
            this.nameText1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameText3
            // 
            this.nameText3.BackColor = System.Drawing.Color.Transparent;
            this.nameText3.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText3.ForeColor = System.Drawing.Color.White;
            this.nameText3.Location = new System.Drawing.Point(476, 91);
            this.nameText3.Name = "nameText3";
            this.nameText3.Size = new System.Drawing.Size(150, 150);
            this.nameText3.TabIndex = 2;
            this.nameText3.Text = "A";
            this.nameText3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameText2
            // 
            this.nameText2.BackColor = System.Drawing.Color.Transparent;
            this.nameText2.Font = new System.Drawing.Font("Kozuka Gothic Pro B", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nameText2.ForeColor = System.Drawing.Color.White;
            this.nameText2.Location = new System.Drawing.Point(325, 91);
            this.nameText2.Name = "nameText2";
            this.nameText2.Size = new System.Drawing.Size(150, 150);
            this.nameText2.TabIndex = 1;
            this.nameText2.Text = "A";
            this.nameText2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputBox
            // 
            this.outputBox.AutoSize = true;
            this.outputBox.BackColor = System.Drawing.Color.Transparent;
            this.outputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.outputBox.ForeColor = System.Drawing.Color.White;
            this.outputBox.Location = new System.Drawing.Point(286, 260);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(232, 31);
            this.outputBox.TabIndex = 5;
            this.outputBox.Text = "Your Score Was 6";
            // 
            // EndGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BallDodge.Properties.Resources.dodgeball_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.nameText2);
            this.Controls.Add(this.nameText3);
            this.Controls.Add(this.nameText1);
            this.Controls.Add(this.mainmenuLabel);
            this.Controls.Add(this.replayLabel);
            this.DoubleBuffered = true;
            this.Name = "EndGameScreen";
            this.Size = new System.Drawing.Size(800, 550);
            this.Load += new System.EventHandler(this.EndGameScreen_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LoseScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EndGameScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label replayLabel;
        private System.Windows.Forms.Label mainmenuLabel;
        private System.Windows.Forms.Label nameText1;
        private System.Windows.Forms.Label nameText3;
        private System.Windows.Forms.Label nameText2;
        private System.Windows.Forms.Label outputBox;
    }
}
