using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Media;
using System.Xml;


namespace BallDodge
{
    public partial class Form1 : Form
    {
        public static SoundPlayer bounceSound = new SoundPlayer(Properties.Resources.Cartoon_Hop_SoundBible_com_553158131);
        public static SoundPlayer tadaSound = new SoundPlayer(Properties.Resources.Ta_Da_SoundBible_com_1884170640);
        public static SoundPlayer slipSound = new SoundPlayer(Properties.Resources.Banana_Peel_Slip_SoundBible_com_580403617);
        public static SoundPlayer clickSound = new SoundPlayer(Properties.Resources.Click2_Sebastian_759472264);

        public static List<Ball> ballList = new List<Ball>();
        public static List<Paddle> paddleList = new List<Paddle>();

        public static List<Highscore> highscoreList = new List<Highscore>();
        public static int playerScore, score;


        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            loadHighscores();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            MainMenuScreen ms = new MainMenuScreen();
            this.Controls.Add(ms);

            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);

        }

        private void loadHighscores() //method for loading any saved highscores in the highscoreDB xml file
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("highscoreDB.xml");

            XmlNode parent;
            parent = doc.DocumentElement;
            foreach (XmlNode child in parent.ChildNodes)
            {
                Highscore hs = new Highscore(null, null);
                foreach (XmlNode grandChild in child.ChildNodes)
                {
                    if (grandChild.Name == "name")
                    {
                        hs.name = grandChild.InnerText;
                    }
                    if (grandChild.Name == "level")
                    {
                        hs.level = grandChild.InnerText;
                    }
                }
                highscoreList.Add(hs);
            }
        }
    }
}
