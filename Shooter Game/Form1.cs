using System;
using System.Drawing;
using System.Windows.Forms;
namespace Shooter_Game
{
    public partial class ShooterGame : Form
    {
        //Bullets bullets;
        PictureBox[] clouds;
        Random random;
        int backgroundSpeed;
        public Player mainPlayer;
        PictureBox[] bullets;
        int bulletsSpeed;
        public Rectangle rectangle;
        Enemies enemies;
        public ShooterGame() 
        {
            //bullets = new Bullets(Program.form);
            //bulletsSpeed = bullets.speed;
            mainPlayer = new Player(50, 300);
            enemies = new Enemies();
            InitializeComponent();
            Invalidate();
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
            backgroundSpeed = 5;
            clouds = new PictureBox[20];
            random = new Random();
            bullets = new PictureBox[1];
            bulletsSpeed = 80;
            for (var i = 0; i < bullets.Length; i++)
            {
                bullets[i] = new PictureBox
                {
                    BorderStyle = BorderStyle.None,
                    Size = new Size(20, 5),
                    BackColor = Color.White
                };
                this.Controls.Add(bullets[i]);
            }
            for (var i = 0; i < clouds.Length; i++)
            {
                clouds[i] = new PictureBox
                {
                    BorderStyle = BorderStyle.None,
                    Location = new Point(random.Next(-1000, 1280), random.Next(10, 80)),
                    Size = new Size(random.Next(80, 200), random.Next(30, 70)),
                    BackColor = Color.FromArgb(random.Next(50, 125), 255, 200, 200)
                };
                this.Controls.Add(clouds[i]);
            }
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.DrawImage(mainPlayer.Image, mainPlayer.x, mainPlayer.y, mainPlayer.Width, mainPlayer.Height);

        }

        private void MoveLeftTimer_Tick(object sender, EventArgs e)
        {
            if (mainPlayer.x > 10)
                mainPlayer.x -= mainPlayer.Speed;
            Invalidate();
        }

        private void MoveRightTimer_Tick(object sender, EventArgs e)
        {
            if (mainPlayer.x < 1150)
                mainPlayer.x += mainPlayer.Speed;
            Invalidate();
        }

        private void MoveUpTimer_Tick(object sender, EventArgs e)
        {
            mainPlayer.y -= mainPlayer.Speed;
            Invalidate();
        }

        private void MoveDownTimer_Tick(object sender, EventArgs e)
        {
            mainPlayer.y += mainPlayer.Speed;
            Invalidate();
        }

        private void ShooterGame_KeyDown(object sender, KeyEventArgs e)
        {
            mainPlayer.Image = Properties.Resources.player_run;
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
                        bullets[i].Location = new Point(mainPlayer.x + 70 + i * 50, mainPlayer.y + 35);
                }
            }
        }

        private void ShooterGame_KeyUp(object sender, KeyEventArgs e)
        {
            mainPlayer.Image = Properties.Resources.player_stands;
            MoveLeftTimer.Stop();
            MoveRightTimer.Stop();
            MoveUpTimer.Stop();
            MoveDownTimer.Stop();
        }

        private void MoveBulletsTimer_Tick(object sender, EventArgs e)
        {
            for (var i = 0; i < bullets.Length; i++)
                bullets[i].Left += bulletsSpeed;
            Invalidate();
        }

        private void GameOver(string str)
        {
            label1.Text = str;
            label1.Location = new Point(464, 518);
            label1.Visible = true;
            //MoveEnemiesTimer.Stop();
        }
    }
}
