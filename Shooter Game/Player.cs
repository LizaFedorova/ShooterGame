using System.Drawing;
namespace Shooter_Game
{
    public class Player
    {
        public Point Location;
        public int speed;
        public Player()
        {
            Location.X = 300;
            Location.Y = 50;
            speed = 5;
        }
    }
}
