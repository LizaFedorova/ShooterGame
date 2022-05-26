using System.Drawing;
namespace Shooter_Game
{
    public class Player
    {
        //public Point Location;
        public int Speed;
        public Rectangle Rect;
        public int Width;
        public int Height;
        public Image Image;
        public int x;
        public int y;

        public Player(int x, int y)
        {
            //Location.X = 50;
            //Location.Y = 300;
            Speed = 7;
            Image = Properties.Resources.player_stands;
            this.x = x;
            this.y = y;
            Width = 80;
            Height = 130;
        }
    }
}
