using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BallDodge
{
    public partial class GameScreen : UserControl
    {
        #region global values
        //random number generator
        Random randgen = new Random();

        //pens, brushes, fonts and colours
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        Font kgpb20 = new Font("Kozuka Gothic Pro B", 20);

        //counter values
        bool countDownOver = false;
        int counter = 3;
        int counterX;
        int counterY;
        #endregion

        public GameScreen()
        {
            InitializeComponent();
            counterX = this.Width / 2 -20;
            counterY = this.Height / 2 - 20;
            gameTimer.Enabled = true;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (!countDownOver)
            {
                if (counter > 1)
                {
                    countDownOver = false;
                    counter--;
                    gameTimer.Interval = 1000;
                }
                else
                {
                    countDownOver = true;
                    gameTimer.Interval = 16;
                }
            }
            else
            {
                //game logic 
            }

            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            if (countDownOver == false)
            {
                e.Graphics.Clear(Color.Black);
                e.Graphics.DrawString(counter + "", kgpb20, whiteBrush, counterX, counterY);
            }


        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            //counterX = this.Width / 2 - 20;
            //counterY = this.Height / 2 - 20;
            //for (int i = 1; i < 4; i++)
            //{
            //    Thread.Sleep(1000);
            //    if (counter < 1)
            //    {
            //        countDownOver = true;
            //    }
            //    //Refresh();
            //    Graphics g = this.CreateGraphics();
            //    g.DrawString(counter + "", kgpb20, whiteBrush, counterX, counterY);
            //    counter--;
            //}
        }
    }
}
