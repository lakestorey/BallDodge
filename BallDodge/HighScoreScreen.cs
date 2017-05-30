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
        int index = 0;
        int lastIndex = 0;

        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, spaceDown, escapeDown;

        public HighScoreScreen()
        {
            InitializeComponent();
        }

        private void HighScoreScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            index = lastIndex;
            Form form = this.FindForm();

            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (index != 0)
                        index--;
                    else
                    {
                        index = 0;
                    }
                    break;
                case Keys.Down:
                    if (index != 0)
                        index++;
                    else
                    {
                        index = 0;
                    }
                    break;

                case Keys.Space:
                    switch (index)
                    {
                        //start button
                        case 0:
                            MainMenuScreen ms = new MainMenuScreen();
                            ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);

                            form.Controls.Add(ms);
                            form.Controls.Remove(this);

                            break;
                    }
                    break;
            }
        }
    }
}
