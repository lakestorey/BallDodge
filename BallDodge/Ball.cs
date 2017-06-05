using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallDodge
{
    public class Ball
    {
        public int x, y, size, xSpeed, ySpeed;
        public bool coloured;
        public Ball (int _x, int _y,int _size, int _xSpeed, int _ySpeed, bool _coloured)
        {
            x = _x;
            y = _y;
            size = _size;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            coloured = _coloured;
        }

        public void Move()
        {
            x = x + xSpeed;
            y = y + ySpeed;
        }

        //method to detect when the ball has collided with the wall
        public void WallCollision(UserControl US)
        {
            if (x <= 0)
            {
                xSpeed *= -1;
            }
            if (x >= US.Width - size - 15)
            {
                xSpeed *= -1;
            }
            if (y <= 0)
            {
                ySpeed *= -1;
            }
            if (y >= US.Height - size - 15)
            {
                ySpeed *= -1;
            }
        }

        //method to detect when the ball has collided with the paddle
        public int PaddleCollision(Paddle p, int ticks)
        {
            Rectangle ballRec = new Rectangle(x, y, size, size);
            Rectangle paddleRec = new Rectangle(p.x, p.y, p.width, p.height);

            //GameScreen.ticksSinceHit++;

            if (ballRec.IntersectsWith(paddleRec) && ticks >= 15)
            {
                if (coloured == false)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }

            return 0;
        }
    }
}
