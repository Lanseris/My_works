using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    abstract class BaseObject:ICollision
    {
        protected MainScreen Screen;
        protected Point Pos;
        protected Size Size;
        protected Point Dir;

        /// <summary>
        /// Конструктор класса с 4-мя параметрами
        /// </summary>
        /// <param Объект, содержащий в себе поле для отрисовки ="screen"></param>
        /// <param позиция объекта ="pos"></param>
        /// <param размеры объекта ="size"></param>
        /// <param направление движения объекта ="dir"></param>
        public BaseObject(MainScreen screen, Point pos, Size size, Point dir)
        {
            Screen = screen;
            Pos = pos;
            Size = size;
            Dir = dir;
        }

        /// <summary>
        /// Конструктор класса с 3-мя параметрами 
        /// (вызывающий конструктор с 3-мя параметрами, при этом направление движения задаётся точкой с координатами 0,0 - отсутствие направления движения)
        /// </summary>
        /// <param name ="screen"></param>
        /// <param name="pos"></param>
        /// <param name="size"></param>
        public BaseObject(MainScreen screen, Point pos, Size size) : this(screen ,pos, size, new Point(0, 0)) { }
        
        /// <summary>
        /// Виртуальный метод, позволяющий задать полям класса новые значения
        /// </summary>
        /// <param новая позиция ="pos"></param>
        /// <param новые размеры ="size"></param>
        /// <param новое направление движения ="dir"></param>
        public virtual void ChangeStats(Point pos, Size size, Point dir)
        {
            Pos = pos;
            Size = size;
            Dir = dir;
        }

        /// <summary>
        /// Абстрактных метод, отвечающий за отрисовку наследников данного класса
        /// </summary>
        public abstract void Drow();

        /// <summary>
        /// Проверка на то находится ли объект за пределами игрового поля
        /// и при необходимости перемещает его в противоположную часть игрового поля (относительно направления движения)
        /// </summary>
        /// <returns>перемещает и позвращает true если за пределыми, если в пределах, возвращает false</returns>
        public bool IsOutOfScreen()
        {
            if (Pos.X < -Size.Width && Math.Sign(Dir.X) < 0)
            {
                Pos.X = Screen.Width;
                return true;
            }
            else if (Pos.X > Screen.Width && Math.Sign(Dir.X) > 0)
            {
                Pos.X = -Size.Width;
                return true;
            }

            if (Pos.Y < -Size.Height && Math.Sign(Dir.Y) < 0)
            {
                Pos.Y = Screen.Heigth;
                return true;
            }
            else if (Pos.Y > Screen.Heigth && Math.Sign(Dir.Y) > 0)
            {
                Pos.Y = -Size.Height;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Метод обновляющий координаты объекта 
        /// (путём прибавления к текущим координатам,координат точки, отвечающей за направление движения Dir)
        /// </summary>
        public virtual void Update()
        {
            if (Dir.X!=0 || Dir.Y!=0)
            {
                Pos.X = Pos.X + Dir.X;
                Pos.Y = Pos.Y + Dir.Y;
            }
        }

        public Point dir
        {
            get { return Dir; }
            set {Dir = value;}
    }
        public Point pos
        {
            get { return Pos; }
            set { Pos = value; }
        }

        /// <summary>
        /// Реализация интерфейса ICollision
        /// </summary>
        /// <param другой объект, так же реализовавший этот интерфейс="o"></param>
        /// <returns></returns>
        public bool Collision(ICollision o) => o.Rect.IntersectsWith(this.Rect);


        public Rectangle Rect => new Rectangle(Pos, Size);
    }
}
