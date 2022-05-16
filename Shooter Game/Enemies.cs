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
        int speed;
        Image image;
        Rectangle rect;
        int index;
        int healthpoint;
        public Enemies()
        {
            healthpoint = 3;
            //image = Properties.Resources.heli1;
            rect = new Rectangle(0, 50, 100, 54);
            speed = 10;
            index = 0;
        }

    }
}
