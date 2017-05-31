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

        Graphics g;

        Pen pen = new Pen(Color.White, 3);

        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, spaceDown, escapeDown;

        public MainMenuScreen()
        {
            InitializeComponent();
            g = this.CreateGraphics();
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
                            //sent right to the game screen(gs)

                            //gs.Location = new Point((form.Width - gs.Width) / 2, (form.Height - gs.Height) / 2);

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
                            InstructionScreen si = new InstructionScreen();
                            si.Location = new Point((form.Width - si.Width) / 2, (form.Height - si.Height) / 2);

                            form.Controls.Add(si);
                            form.Controls.Remove(this);

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
                    playLabel.BorderStyle = BorderStyle.None;
                    playLabel.BackColor = Color.Transparent;
                    break;
                case 1:
                    highscoreLabel.BorderStyle = BorderStyle.None;
                    highscoreLabel.BackColor = Color.Transparent;
                    break;
                case 2:
                    optionLabel.BorderStyle = BorderStyle.None;
                    optionLabel.BackColor = Color.Transparent;
                    break;
                case 3:
                    exitLabel.BorderStyle = BorderStyle.None;
                    exitLabel.BackColor = Color.Transparent;
                    break;
            }

            //set selected button to red
            switch (index)
            {
                case 0:
                    playLabel.BorderStyle = BorderStyle.Fixed3D;
                    playLabel.BackColor = Color.Black;
                    break;
                case 1:
                    highscoreLabel.BorderStyle = BorderStyle.Fixed3D;
                    highscoreLabel.BackColor = Color.Black;
                    break;
                case 2:
                    optionLabel.BorderStyle = BorderStyle.Fixed3D;
                    optionLabel.BackColor = Color.Black;
                    break;
                case 3:
                    exitLabel.BorderStyle = BorderStyle.Fixed3D;
                    exitLabel.BackColor = Color.Black;
                    break;
            }
        }
    }
}
