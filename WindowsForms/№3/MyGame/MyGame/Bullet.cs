using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class Bullet:BaseObject
    {
        protected static Image newImage = Image.FromFile("laser_bullet.png");
        protected bool usingRN=!true;

        public Bullet(MainScreen screen, Point pos, Size size,Point dir) : base(screen, pos, size,dir) { }

        public override void Drow()
        {
            Screen.Buffer.Graphics.DrawImage(newImage, Pos.X, Pos.Y, Size.Width, Size.Height);
        }

        /// <summary>
        /// после пересечения границы игрового поля ссылка на пулю в массиве обнуляется
        /// </summary>
        public override void Update()
        {
            base.Update();
            if (this.pos.X>Screen.Width)
             {
              //  Screen.BulletsL.Remove(this);
                Screen.Bullets[Screen.NumOfBull-1] = null;
                Screen.NumOfBull--;
            }
        }
    }
}
