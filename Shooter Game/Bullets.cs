using System.Drawing;
using System.Windows.Forms;
namespace Shooter_Game
{
    class Bullets
    {
        public int Speed;
        public int Width;
        public int Height;
        public int x;
        public int y;
        public Bullets()
        {
            Speed = 80;
            Height = 5;
            Width = 20;
        }
    }
}
