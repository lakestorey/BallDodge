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
    public partial class MainMenuScreen : UserControl
    {
        int index = 0;
        int lastIndex = 0;

        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, spaceDown, escapeDown;

        public MainMenuScreen()
        {
            InitializeComponent();
        }

        private void MenuScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            lastIndex = index;
            Form form = this.FindForm();
            //to make sure that if you click to the bottom or top you will go to the other end instead of just stopping
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (index != 0)
                        index--;
                    else
                    {
                        index = 3;
                    }
                    break;
                case Keys.Down:
                    if (index != 3)
                        index++;
                    else
                    {
                        index = 0;
                    }
                    break;

                //clicking on the screen with space key
                case Keys.Space:
                    switch (index)
                    {
                        //start button
                        case 0:
                            InstructionScreen si = new InstructionScreen();
                            si.Location = new Point((form.Width - si.Width) / 2, (form.Height - si.Height) / 2);

                            form.Controls.Add(si);
                            form.Controls.Remove(this);

                            break;

                        //highscore button
                        case 1:
                            HighScoreScreen hs = new HighScoreScreen();
                            form.Controls.Add(hs);
                            form.Controls.Remove(this);

                            hs.Location = new Point((form.Width - hs.Width) / 2, (form.Height - hs.Height) / 2);

                            break;

                        //option button
                        case 2:
                            OptionScreen os = new OptionScreen();

                            form.Controls.Add(os);
                            form.Controls.Remove(this);

                            os.Location = new Point((form.Width - os.Width) / 2, (form.Height - os.Height) / 2);
                            break;
                        case 3:
                        //exit button
                            Application.Exit();
                            break;
                    }
                    break;
            }

            //set button to white if not clicked on
            switch (lastIndex)
            {
                case 0:
                    playLabel.ForeColor = Color.White;
                    break;
                case 1:
                    highscoreLabel.ForeColor = Color.White;
                    break;
                case 2:
                    optionLabel.ForeColor = Color.White;
                    break;
                case 3:
                    exitLabel.ForeColor = Color.White;
                    break;
            }

            //set selected button to red
            switch (index)
            {
                case 0:
                    playLabel.ForeColor = Color.Black;
                    break;
                case 1:
                    highscoreLabel.ForeColor = Color.Black;
                    break;
                case 2:
                    optionLabel.ForeColor = Color.Black;
                    break;
                case 3:
                    exitLabel.ForeColor = Color.Black;
                    break;
            }
        }
    }
}
