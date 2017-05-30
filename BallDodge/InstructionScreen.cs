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
    public partial class InstructionScreen : UserControl
    {
        int index = 0;
        int lastIndex = 0;

        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, spaceDown, escapeDown;

        public InstructionScreen()
        {
            InitializeComponent();
        }

        private void InstructionScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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
                        index = 1;
                    }
                    break;
                case Keys.Down:
                    if (index != 1)
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
                            //gamescreen gs = new //gamescreen();
                            //gs.Location = new Point((form.Width - gs.Width) / 2, (form.Height - gs.Height) / 2);

                            //form.Controls.Add(gs);
                            //form.Controls.Remove(this);

                            break;

                        //highscore button
                        case 1:
                            MainMenuScreen ms = new MainMenuScreen();
                            form.Controls.Add(ms);
                            form.Controls.Remove(this);

                            ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);

                            break;
                    }
                    break;
            }

            //set button to white if not clicked on
            switch (lastIndex)
            {
                case 0:
                    continueLabel.BorderStyle = BorderStyle.None;
                    continueLabel.BackColor = Color.Transparent;
                    break;
                case 1:
                    mainMenuLabel.BorderStyle = BorderStyle.None;
                    mainMenuLabel.BackColor = Color.Transparent;
                    break;
            }

            //set selected button to red
            switch (index)
            {
                case 0:
                    continueLabel.BorderStyle = BorderStyle.Fixed3D;
                    continueLabel.BackColor = Color.Black;
                    break;
                case 1:
                    mainMenuLabel.BorderStyle = BorderStyle.Fixed3D;
                    mainMenuLabel.BackColor = Color.Black;
                    break;
            }
        }
    }
}