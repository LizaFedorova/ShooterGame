﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter_Game
{
    public class Player
    {
        public Point point;
        public Size size;
        public Region reg;
        public void New_player(ShooterGame F)
        {
            size = F.imageP.Size;
            point.X = 0;
            point.Y = 0;
            Rectangle rec = new Rectangle(point, size);
        }
        public void Show_player(ShooterGame F, int x, int y)
        {
            F.g.ResetClip();
            point.X = x - size.Width / 2;
            point.Y = y;
            Rectangle rec = new Rectangle(point, size);
            F.g.DrawImage(F.imageP, point);
            //F.g.ExcludeClip(reg);
        }
    }
}
