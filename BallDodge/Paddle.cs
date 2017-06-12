using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallDodge
{
    public class Paddle
    {
        public int x, y, xSpeed, ySpeed, width, height;
        public Paddle (int _x, int _y, int _xSpeed, int _ySpeed, int _width, int _height)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            width = _width;
            height = _height;
        }

        public void Move (string direction, UserControl US)
        {
            if (direction == "up" && y >= 0)
            {
                y -= ySpeed;
            }
            if (direction == "down" && y <= US.Height - height)
            {
                y += ySpeed;
            }
            if (direction == "left" && x >= 0)
            {
                x -= xSpeed;
            }
            if (direction == "right" && x <= US.Width - width)
            {
                x += xSpeed;
            }
        }
    }
}
