using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallDodge
{
    public partial class HighScoreScreen : UserControl
    {

        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, spaceDown, escapeDown;

        public HighScoreScreen()
        {
            InitializeComponent();
        }

        private void HighScoreScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MainMenuScreen ms = new MainMenuScreen();
                Form form = this.FindForm();

                form.Controls.Add(ms);
                form.Controls.Remove(this);

                ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);
            }
            else if (e.KeyCode == Keys.Space)
            {
                MainMenuScreen ms = new MainMenuScreen();
                Form form = this.FindForm();

                form.Controls.Add(ms);
                form.Controls.Remove(this);

                ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);
            }
        }

        private void HighScoreScreen_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.highscoreList.Count; i++)
            {
                if ((i + 1) >= 10)
                {
                    highscoreDisplay.Text += (i + 1) + ".  " + Form1.highscoreList[i].name + "   level " + Form1.highscoreList[i].level + "   ";
                }
                else
                {
                    highscoreDisplay.Text += (i + 1) + ".   " + Form1.highscoreList[i].name + "   level " + Form1.highscoreList[i].level + "   ";
                }
            }
        }
    }
}
