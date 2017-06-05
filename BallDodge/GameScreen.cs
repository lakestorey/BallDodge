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
        SolidBrush redBrush = new SolidBrush(Color.Red);
        Pen whitePen = new Pen(Color.White, 3);
        Pen bluePen = new Pen(Color.Blue, 3);
        Font kgpb20 = new Font("Kozuka Gothic Pro B", 20);

        //counter values
        bool countDownOver = false;
        int counter = 3;
        int counterX;
        int counterY;

        //ball values
        int ballX = 0;
        int ballY = 0;
        int ballSpeed = 4;
        int ballSize = 20;
        bool initialLoaded = false;
        bool ballColoured = false;
        int colouredBallIndex = 0;

        //paddle values
        int paddleX = 0;
        int paddleY = 0;
        int paddleSpeed = 5;
        int paddleHeight = 20;
        int paddleWidth = 35;
        string paddleVertical = "";
        string paddleHorizontal = "";
        public static int playerLives = 3;
        public static bool targetHit = false;
        int collisionValue = 0;

        //controls
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool leftArrowDown = false;
        bool rightArrowDown = false;
        public static int ticksSinceHit = 0;
        #endregion

        public GameScreen()
        {
            InitializeComponent();
            counterX = this.Width / 2 -20;
            counterY = this.Height / 2 - 20;
            gameTimer.Enabled = true;
        }

        #region keyup and keydown events
        //key down event
        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    upArrowDown = true;
                    break;
                case Keys.S:
                    downArrowDown = true;
                    break;
                case Keys.A:
                    leftArrowDown = true;
                    break;
                case Keys.D:
                    rightArrowDown = true;
                    break;
            }
        }

        //key up event
        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    upArrowDown = false;
                    break;
                case Keys.S:
                    downArrowDown = false;
                    break;
                case Keys.A:
                    leftArrowDown = false;
                    break;
                case Keys.D:
                    rightArrowDown = false;
                    break;
            }
        }
        #endregion

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
                if (initialLoaded == false)
                {
                    loadBalls();
                    loadPaddle();
                    initialLoaded = true;
                }

                #region move paddle
                if (upArrowDown == true)
                {
                    paddleVertical = "up";
                }
                if (downArrowDown == true)
                {
                    paddleVertical = "down";
                }
                if (leftArrowDown == true)
                {
                    paddleHorizontal = "left";
                }
                if (rightArrowDown == true)
                {
                    paddleHorizontal = "right";
                }

                if (upArrowDown == true || downArrowDown == true)
                {
                    foreach (Paddle p in Form1.paddleList)
                    {
                        p.Move(paddleVertical, this);
                    }
                }
                if (leftArrowDown == true || rightArrowDown == true)
                {
                    foreach (Paddle p in Form1.paddleList)
                    {
                        p.Move(paddleHorizontal, this);
                    }
                }
                #endregion

                #region collision
                //move balls
                foreach (Ball b in Form1.ballList)
                {
                    b.Move();
                }

                //detect wall collision
                foreach (Ball b in Form1.ballList)
                {
                    b.WallCollision(this);
                }

                //detect paddle collision
                foreach (Ball b in Form1.ballList)
                {
                    collisionValue = b.PaddleCollision(Form1.paddleList[0], ticksSinceHit);

                    if (collisionValue == 0)
                    {
                    }
                    else if (collisionValue == 1)
                    {
                        playerLives--;
                        ticksSinceHit = 0;

                        b.ySpeed *= -1;
                        b.xSpeed *= -1;
                        break;
                    }
                    else if (collisionValue == 2)
                    {
                        reassignTarget();
                        ticksSinceHit = 0;

                        b.ySpeed *= -1;
                        b.xSpeed *= -1;
                        break;
                    }
                }
                #endregion

                //detect if dead
                if (playerLives <= 0)
                {
                    gameTimer.Stop();
                    Thread.Sleep(500);
                    Application.Exit();
                }
            }
            ticksSinceHit++;
            Refresh();
        }

        #region initial loading methods
        private void loadBalls ()
        {
            for (int i = 0; i < 3; i++)
            {
                ballX = randgen.Next(0, this.Width - ballSize);
                ballY = randgen.Next(0, this.Height - ballSize);

                Ball newBall = new Ball(ballX, ballY, ballSize, ballSpeed, ballSpeed, ballColoured);
                Form1.ballList.Add(newBall);
            }

            colouredBallIndex = randgen.Next(0, Form1.ballList.Count() - 1);
            Form1.ballList[colouredBallIndex].coloured = true;
        }

        private void loadPaddle()
        {
            paddleX = this.Width / 2 - paddleWidth;
            paddleY = this.Height / 2 - paddleHeight;
            Paddle newPaddle = new Paddle(paddleX, paddleY, paddleSpeed, paddleSpeed, paddleWidth, paddleHeight);
            Form1.paddleList.Add(newPaddle);
        }
        #endregion

        public void reassignTarget ()
        {
            //randomize spawning point
            ballX = randgen.Next(0, this.Width - ballSize);
            ballY = randgen.Next(0, this.Height - ballSize);

            //add new ball to list
            Ball newBall = new Ball(ballX, ballY, ballSize, ballSpeed, ballSpeed, ballColoured);
            Form1.ballList.Add(newBall);

            //pick new coloured ball
            foreach (Ball b in Form1.ballList)
            {
                b.coloured = false;
            }
            colouredBallIndex = randgen.Next(0, Form1.ballList.Count() - 1);
            Form1.ballList[colouredBallIndex].coloured = true;
            targetHit = false;
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
                e.Graphics.DrawString("Lives: " + playerLives, kgpb20, whiteBrush, 5, 5);
                foreach (Ball b in Form1.ballList)
                {
                    if (b.coloured == true)
                    {
                        e.Graphics.FillEllipse(redBrush, b.x, b.y, b.size, b.size);
                    }
                    e.Graphics.DrawEllipse(whitePen, b.x, b.y, b.size, b.size);
                }
                foreach (Paddle p in Form1.paddleList)
                {
                    e.Graphics.DrawRectangle(bluePen, p.x, p.y, p.width, p.height);
                }
            }
        }
    }
}
