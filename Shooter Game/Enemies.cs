using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Shooter_Game
{
    class Enemies
    {
        public int Size;
        public int Speed;
        public Image Image;
        Random random;
        public Enemies()
        {
            random = new Random();
            Size = random.Next(60, 80);
            Speed = 3;
            Image = Properties.Resources.enemy2;
        }
    }
}
