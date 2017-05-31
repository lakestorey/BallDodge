using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallDodge
{
    public class Ball
    {
        public int x, y, size, xSpeed, ySpeed;
        public Ball (int _x, int _y,int _size, int _xSpeed, int _ySpeed)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
        }

        public void Move()
        {
            x = x + xSpeed;
            y = y + ySpeed;
        }

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
    }
}
