using System.Drawing;
using System.Windows.Forms;
namespace Shooter_Game
{
    class Bullets
    {
        public int Speed;
        public int width;
        public int height;
        public int x;
        public int y;
        PictureBox bullets;
        public Bullets()
        {
            Speed = 80;
            height = 5;
            width = 20;
        }

        public void NewBullets(Form form, int x, int y)
        {
            bullets = new PictureBox();
            bullets.BackColor = Color.White;
            bullets.BorderStyle = BorderStyle.None;
            bullets.Height = height;
            bullets.Width = width;
            bullets.Location = new Point(x, y);
            bullets.Name = "Bullet";
            form.Controls.Add(bullets);
        }
    }
}
