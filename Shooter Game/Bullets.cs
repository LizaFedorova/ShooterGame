using System.Drawing;
using System.Windows.Forms;
namespace Shooter_Game
{
    class Bullets
    {
        Graphics g;
        int speed;
        Image image;
        Rectangle rect;
        PictureBox bullet;
        int healthpoint;
        public Bullets()
        {
            healthpoint = 3;
            image = Properties.Resources.player_stands;
            rect = new Rectangle(0, 50, 100, 54);
            speed = 10;
        }

        public void Draw(PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawImage(image, rect);
        }

        public void setRecUp()
        {
            rect.Y -= speed;
        }
        public void setRecDown()
        {
            rect.Y += speed;
        }

        PictureBox bullets;
        int bulletsSpeed;
        private void NewBullets(Form form)
        {
            bulletsSpeed = 80;
            bullets = new PictureBox
            {
                BorderStyle = BorderStyle.None,
                Height = 5,
                Width = 20,
                BackColor = Color.White,
                Tag = "bullet",
                Location = new Point(rect.X + 80, rect.Y + 54 / 2)
            };
            form.Controls.Add(bullets);
        }
        public Rectangle Rectangle()
        {
            return rect;
        }
        public PictureBox getbullet()
        {
            return bullet;
        }

        public int Healpoint()
        {
            return healthpoint;
        }
        public void Healpoint(int a)
        {
            healthpoint -= a;
        }

        public Graphics graphics()
        {
            return g;
        }

        private void ShooterGame_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                for (var i = 0; i < bullets.Width; i++)
                {
                    if (bullets.Left > 1280)
                        bullets.Location = new Point(rect.Location.X + 70 + i * 50, rect.Location.Y + 35);
                }
            }
        }
    }
}
