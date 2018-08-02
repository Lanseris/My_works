using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class Planet:BaseObject
    {
        protected Brush colour;
        protected static Random rnd = new Random();
        static Brush[] a = new Brush[]
           {
                Brushes.AliceBlue,
                Brushes.DarkGoldenrod,
                Brushes.Firebrick,
                Brushes.Khaki,
                Brushes.IndianRed,
                Brushes.Gray,
                Brushes.MediumPurple,
                Brushes.Pink
           };

        /// <summary>
        /// конмтруктор с 3-мя параметрами
        /// + рандомно заполняется поле цвета
        /// </summary>
        /// <param ссылка на объект типа MainScreen="screen"="screen"></param>
        /// <param позиция="pos"></param>
        /// <param размер="size"></param>
        public Planet(MainScreen screen, Point pos, Size size) : base(screen, pos, size)
        {
            colour = a[rnd.Next(0, a.Length)];
        }

        /// <summary>
        /// конструктор с 4-мя параметрами
        /// + рандомно заполняется поле цвета 
        /// </summary>
        /// <param ссылка на объект типа MainScreen="screen"="screen"></param>
        /// <param позиция="pos"></param>
        /// <param размер="size"></param>
        /// <param направление движения="dir"></param>
        public Planet(MainScreen screen, Point pos, Size size,Point dir) : base(screen, pos, size,dir)
        {
            colour = a[rnd.Next(0, a.Length)];
        }

        /// <summary>
        /// Переопределённый метод базовогог класса
        /// (рисует залитую цветом окружность)
        /// </summary>
        public override void Drow()
        {
            Screen.Buffer.Graphics.FillEllipse(colour,new Rectangle(Pos.X, Pos.Y, Size.Width, Size.Height));
        }

        /// <summary>
        /// переопределённый метод базового класса
        /// после того как выполняется метод базового класса происходит дополниетльная проверка на то,
        /// является ли размер (ширина) объекта больше 20 и находится ли объект за пределами игрового поля,
        /// если да, то заново генерируются следующие параметры:
        /// размер, цвет, направление (скорость) движения, посиция по оси Y
        /// </summary>
        public override void Update()
        {
            base.Update();

            if (IsOutOfScreen() && Size.Width>20)
            {
                Size.Width = Size.Height = rnd.Next(20, 200);
                colour = a[rnd.Next(0, a.Length)];
                Dir = new Point(-rnd.Next(10, 20), 0);
                Pos.Y = rnd.Next(50, Screen.Width - 50);
            }
        }

    }
}
