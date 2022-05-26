using System.Drawing;
using System.Windows.Forms;

namespace Shooter_Game
{
    public class Player
    {
        public Point Location;
        public int Speed;
        public Rectangle Rect;
        public int width;
        public int height;
        public Image Image;
        public Player()
        {
            Location.X = 50;
            Location.Y = 300;
            Speed = 5;
            width = 80;
            height = 130;
            Image = Properties.Resources.player_stands;
            Rect = new Rectangle(Location.X, Location.Y, width, height);
        }

        public Rectangle Rectangle()
        {
            return Rect;
        }
    }

}
