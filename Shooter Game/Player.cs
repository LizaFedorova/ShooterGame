using System.Drawing;
namespace Shooter_Game
{
    public class Player
    {
        public int Speed;
        public int Width;
        public int Height;
        public Image Image;
        public int x;
        public int y;
        public Player(int x, int y)
        {
            Speed = 10;
            Image = Properties.Resources.player_stands;
            this.x = x;
            this.y = y;
            Width = 80;
            Height = 130;
        }
    }
}
