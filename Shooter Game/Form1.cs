using System;
using System.Drawing;
using System.Windows.Forms;
namespace Shooter_Game
{
    public partial class ShooterGame : Form
    {
        Clouds clouds;
        Random random;
        public Player mainPlayer;
        PictureBox[] enemies;
        int enemiesSize;
        int enemiesSpeed;
        Image enemiesImage;
        PictureBox bullets;
        int bulletsSpeed;
        int score;
        int level;

        public ShooterGame() 
        {
            mainPlayer = new Player(50, 300);
            clouds = new Clouds();
            InitializeComponent();
            Invalidate();
        }

        private void ShooterGame_Load(object sender, EventArgs e)
        {
            score = 0;
            level = 1;
            random = new Random();

            enemies = new PictureBox[3];
            enemiesSize = random.Next(60, 80);
            enemiesSpeed = 3;
            enemiesImage = Properties.Resources.enemy2;
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = new PictureBox
                {
                    Size = new Size(enemiesSize, enemiesSize),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BackColor = Color.Transparent,
                    Image = enemiesImage,
                    Location = new Point((i + 1) * random.Next(60, 160) + 500, random.Next(400, 470)),
                };
                this.Controls.Add(enemies[i]);
            }
            clouds.MakeClouds(this);
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.DrawImage(mainPlayer.Image, mainPlayer.x, mainPlayer.y, mainPlayer.Width, mainPlayer.Height);
        }

        private void NewBullets()
        {
            bullets = new PictureBox();
            bullets.BackColor = Color.White;
            bullets.BorderStyle = BorderStyle.None;
            bullets.Height = 5;
            bullets.Width = 20;
            bullets.Location = new Point(mainPlayer.x + 70, mainPlayer.y + 35);
            bullets.Name = "Bullet";
            this.Controls.Add(bullets);
        }

        private void FireBullet(object sender, EventArgs e)
        {
            bulletsSpeed = 80;
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox && c.Name == "Bullet")
                {
                    bullets = (PictureBox)c;
                    bullets.Left += bulletsSpeed;
                    if (bullets.Location.Y > 1280)
                        this.Controls.Remove(bullets);
                    Intersect();
                }
            }
        }

        private void MoveBigTimer_Tick(object sender, EventArgs e)
        {
            clouds.MoveClouds();
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

        private void MoveEnemiesTimer_Tick(object sender, EventArgs e)
        {
            MoveEnemies(enemies, enemiesSpeed);
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
                NewBullets();
        }

        private void ShooterGame_KeyUp(object sender, KeyEventArgs e)
        {
            mainPlayer.Image = Properties.Resources.player_stands;
            Invalidate();
            MoveLeftTimer.Stop();
            MoveRightTimer.Stop();
            MoveUpTimer.Stop();
            MoveDownTimer.Stop();
        }
        
        private void MoveEnemies(PictureBox[] enemies, int speed)
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].Left -= speed + (int)(Math.Sin(enemies[i].Left * Math.PI / 180) + Math.Cos(enemies[i].Left * Math.PI / 180));
                if (CollidePlayerEnemies(mainPlayer, enemies[i]))
                {
                    GameOver("Game over");
                }
                if (enemies[i].Left < this.Left)
                {
                    int enemiesSize = random.Next(60, 90);
                    enemies[i].Size = new Size(enemiesSize, enemiesSize);
                    enemies[i].Location = new Point((i + 1) * random.Next(60, 100) + 500, random.Next(400, 500));
                }
            }
        }

        private void Intersect()
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                if(bullets.Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    score += 1;
                    labelScore.Text = (score < 10) ? "0" + score.ToString() : score.ToString();
                    if (score % 10 == 0)
                    {
                        level += 1;
                        labelLevel.Text = (level < 10) ? "0" + level.ToString() : level.ToString();
                        if (enemiesSpeed <= 10)
                            enemiesSpeed+=4;
                        if (level == 3)
                        {
                            MoveBulletsTimer.Stop();
                            GameOver("Epic power!");
                        }
                    }
                    enemies[i].Location = new Point((i + 1) * random.Next(60, 100) + 700, random.Next(370, 450));
                    bullets.Location = new Point(2000, mainPlayer.y + 50);
                }
            }
        }

        private bool CollidePlayerEnemies(Player mainPlayer, PictureBox enemies)
        {
            PointF delta = new PointF();
            delta.X = mainPlayer.x - enemies.Location.X;
            delta.Y = mainPlayer.y - enemies.Location.Y;
            if (Math.Abs(delta.X) <= mainPlayer.Height / 2 + enemiesSize/2)
            {
                if (Math.Abs(delta.Y) <= mainPlayer.Width / 2 + enemiesSize / 2)
                    return true;
            }
            return false;
        }

        private void GameOver(string str)
        {
            mainLabel.Text = str;
            mainLabel.Location = new Point(278, 48);
            mainLabel.Visible = true;
            MoveEnemiesTimer.Stop();
        }
    }
}
