using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallDodge
{
    public partial class Form1 : Form
    {

        public static List<Ball> ballList = new List<Ball>();
        public static List<Paddle> paddleList = new List<Paddle>();

        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form Form = this.FindForm();

            GameScreen gs = new GameScreen();
            this.Controls.Add(gs);
            gs.Location = new Point((Form.Width - gs.Width) / 2, (Form.Height - gs.Height) / 2);
        }
    }
}
