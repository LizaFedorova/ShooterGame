using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Shooter_Game
{
    public partial class ShooterGame : Form
    {
        PictureBox[] clouds;
        Random random;
        int backgroundSpeed;
        int playerSpeed;
        PictureBox mainPlayer;
        PictureBox[] bullets;
        int bulletsSpeed;

        public ShooterGame()
        {
            InitializeComponent();
        }

        private void MoveBigTimer_Tick(object sender, EventArgs e)
        {
            for (var i = 0; i < clouds.Length; i++)
            {
                clouds[i].Left += backgroundSpeed;
                if (clouds[i].Left >= 1280)
                    clouds[i].Left = clouds[i].Height;
            }

            for (var i = clouds.Length; i < clouds.Length; i++)
            {
                clouds[i].Left += backgroundSpeed - 10;
                if (clouds[i].Left >= 1280)
                    clouds[i].Left = clouds[i].Left;
            }
        }

        private void ShooterGame_Load(object sender, EventArgs e)
        {
            playerSpeed = 5;
            backgroundSpeed = 5;
            clouds = new PictureBox[20];
            random = new Random();
            bullets = new PictureBox[1];
            bulletsSpeed = 80;
            for (var i = 0; i < bullets.Length; i++)
            {
                bullets[i] = new PictureBox();
                bullets[i].BorderStyle = BorderStyle.None;
                bullets[i].Size = new Size(20, 5);
                bullets[i].BackColor = Color.White;
                this.Controls.Add(bullets[i]);
            }

            for (var i = 0; i < clouds.Length; i++)
            {
                clouds[i] = new PictureBox();
                clouds[i].BorderStyle = BorderStyle.None;
                clouds[i].Location = new Point(random.Next(-1000, 1280), random.Next(10, 100));
                clouds[i].Size = new Size(random.Next(100, 255), random.Next(30, 70));
                clouds[i].BackColor = Color.FromArgb(random.Next(50, 125), 255, 200, 200);
                this.Controls.Add(clouds[i]);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            var playerImage = Properties.Resources.player_stands;
            var x = 50;
            var y = 300;
            var width = 75;
            var height = 125;
            g.DrawImage(playerImage, x, y, width, height);
        }

        private void MoveLeftTimer_Tick(object sender, EventArgs e)
        {
            if (mainPlayer.Left > 10)
                mainPlayer.Left -= playerSpeed;
        }

        private void MoveRightTimer_Tick(object sender, EventArgs e)
        {
            if (mainPlayer.Left < 1150)
                mainPlayer.Left += playerSpeed;
        }

        private void MoveUpTimer_Tick(object sender, EventArgs e)
        {
            mainPlayer.Top -= playerSpeed;
        }

        private void MoveDownTimer_Tick(object sender, EventArgs e)
        {
            mainPlayer.Top += playerSpeed;
        }

        private void ShooterGame_KeyDown(object sender, KeyEventArgs e)
        {
            //mainPlayer.Image = Properties.Resources.player_run;
            if (e.KeyCode == Keys.A)
                MoveLeftTimer.Start();
            if (e.KeyCode == Keys.D)
                MoveRightTimer.Start();
            if (e.KeyCode == Keys.W)
                MoveUpTimer.Start();
            if (e.KeyCode == Keys.S)
                MoveDownTimer.Start();
            if (e.KeyCode == Keys.Space)
            {
                for (var i = 0; i < bullets.Length; i++)
                {
                    if (bullets[i].Left > 1280)
                        bullets[i].Location = new Point(mainPlayer.Location.X + 70 + i * 50, mainPlayer.Location.Y + 35);
                }
            }
        }

        private void ShooterGame_KeyUp(object sender, KeyEventArgs e)
        {
            //mainPlayer.Image = Properties.Resources.player_stands;
            MoveLeftTimer.Stop();
            MoveRightTimer.Stop();
            MoveUpTimer.Stop();
            MoveDownTimer.Stop();
        }

        private void MoveBulletsTimer_Tick(object sender, EventArgs e)
        {
            for (var i = 0; i < bullets.Length; i++)
                bullets[i].Left += bulletsSpeed;
        }
    }
}
