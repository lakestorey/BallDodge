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
        Pen whitePen = new Pen(Color.White, 3);
        Font kgpb20 = new Font("Kozuka Gothic Pro B", 20);

        //counter values
        bool countDownOver = false;
        int counter = 3;
        int counterX;
        int counterY;

        //ball values
        int ballX = 0;
        int ballY = 0;
        int ballSpeed = 5;
        int ballSize = 20;
        bool ballsLoaded = false;
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

                //laod initial balls
                if (ballsLoaded == false)
                {
                    loadBalls();
                }

                //move balls and detect collision
                foreach (Ball b in Form1.ballList)
                {
                    b.Move();
                    b.WallCollision(this);
                }
            }
            Refresh();
        }

        private void loadBalls ()
        {
            for (int i = 0; i < 4; i++)
            {
                ballX = randgen.Next(0, this.Width - ballSize);
                ballY = randgen.Next(0, this.Height - ballSize);

                Ball newBall = new Ball(ballX, ballY, ballSize, ballSpeed, ballSpeed);
                Form1.ballList.Add(newBall);
                ballsLoaded = true;
            }
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            if (countDownOver == false)
            {
                e.Graphics.Clear(Color.Black);
                e.Graphics.DrawString(counter + "", kgpb20, whiteBrush, counterX, counterY);
            }
            else
            {
                foreach (Ball b in Form1.ballList)
                {
                    e.Graphics.DrawEllipse(whitePen, b.x, b.y, ballSize, ballSize);
                }
            }
        }
    }
}
