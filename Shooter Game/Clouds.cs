using System;
using System.Drawing;
using System.Windows.Forms;
namespace Shooter_Game
{
    class Clouds
    {
        PictureBox[] clouds = new PictureBox[6];
        Random random = new Random();
        int backgroundSpeed = 5;

        public void MoveClouds()
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

        public void MakeClouds(Form form)
        {
            for (var i = 0; i < clouds.Length; i++)
            {
                clouds[i] = new PictureBox
                {
                    BorderStyle = BorderStyle.None,
                    Location = new Point(random.Next(-1000, 1280), random.Next(10, 80)),
                    Size = new Size(random.Next(80, 200), random.Next(30, 70)),
                    BackColor = Color.FromArgb(random.Next(50, 125), 255, 200, 200)
                };
                form.Controls.Add(clouds[i]);
            }
        }
    }
}
