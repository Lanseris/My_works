using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class Star : BaseObject
    {
        protected bool groing = true;
        protected static Image newImage = Image.FromFile("Star.png");

        /// <summary>
        /// Конструктор с 4-мя параметрами
        /// </summary>
        /// <param ссылка на объект типа MainScreen="screen"></param>
        /// <param позиция="pos"></param>
        /// <param размер="size"></param>
        /// <param направление движения="dir"></param>
        public Star(MainScreen screen, Point pos,Size size,Point dir) :base (screen, pos,size,dir)
        {}

        /// <summary>
        /// Конструктор с 3-мя параметрами
        /// </summary>
        /// <param ссылка на объект типа MainScreen="screen"></param>
        /// <param позиция="pos"></param>
        /// <param размер="size"></param>
        public Star(MainScreen screen, Point pos, Size size) : base(screen, pos, size)
        {}

        /// <summary>
        /// Переопределённый метод базового класса
        /// (рисует картинку звёздочки)
        /// </summary>
        public override void Drow()
        {
            Screen.Buffer.Graphics.DrawImage(newImage, Pos.X, Pos.Y, Size.Width, Size.Height);
        }

        /// <summary>
        /// Переопределённый метод базового класса
        /// после того как выполняется метод базового класса 
        /// и выполняется часть кода, отвечающая за изменение размеров обекта
        /// </summary>
        public override void Update() 
        {
            base.Update();
            IsOutOfScreen();

            if(groing)
            {
                if (Size.Width < 70)
                {
                    Size.Width++;
                    Size.Height++;
                }
                else
                    groing = false;
            }
            else
            {
                if (Size.Width > 40)
                {
                    Size.Width--;
                    Size.Height--;
                }
                else
                    groing = true;
            }
        }
    }
}
