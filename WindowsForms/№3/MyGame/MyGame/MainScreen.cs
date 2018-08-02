using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
    class MainScreen
    {
        public BufferedGraphicsContext _context;
        public BufferedGraphics Buffer;

        public int Width { get; set; }
        public int Heigth { get; set; }
        public int Speed { get; set; }
        public string ScreenMode { get; set; }

        public int CountShipAster { get; set; }
        public int ObjectNumber { get; set; }
        public int NumOfBull { get; set; }
        public int MaxBulletNum { get; set; }

        public int score { get; set; }

        public BaseObject[] _objs;

        public Timer timer;
        public Timer shootTimer;

        public Form _form;

        #region Objects

        public BaseObject[] GameFont;
        public List<Asteroid> Asteroids;
        public Ship MainShip;

        public Bullet[] Bullets;

        #endregion

        #region DelegateLog

        public Action<BaseObject> Destroided;

        #endregion

        /// <summary>
        /// Метод инициализации объекта (похож на конструктор)
        /// </summary>
        /// <param форма, на которой он вызывается="form"></param>
        /// <param режим отображения="screenMode"></param>
        public void Init(Form form, string screenMode)
        {
            _form = form;
            score = 0;
            NumOfBull = 0;
            ScreenMode = screenMode;
            Speed = 50;
            Graphics g;
            _context = BufferedGraphicsManager.Current;
            g = form.CreateGraphics();

            Width = form.Width;
            Heigth = form.Height;

            Buffer = _context.Allocate(g, new Rectangle(0, 0, Width, Heigth));
            Load(30);

            StartNewTimer();
        }

        /// <summary>
        /// метод загрузки массива объектов базового типа
        /// при вызове указывается количество объектов
        /// после чего создаётся массив объектов, соответствующий количеству
        /// количество объектов каждого типа в массиве вычисляется исходя из общего количества объектов
        /// 
        /// за следующий заход распихаю нормально по массивам
        /// </summary>
        /// <param указанное количество объектов="objNumber"></param>
        public void Load(int objNumber)
        {
            shootTimer = new Timer { Interval = 30 };
            shootTimer.Tick += Timer_Tick1;

            MaxBulletNum = 100;
            Random rnd = new Random();
            int _size;
            ObjectNumber = objNumber;

            switch (ScreenMode)
            {
                case "MainMenu":
                    CountShipAster = 0;
                    break;
                case "Game":
                    CountShipAster = 4;
                    break;
                default:
                    CountShipAster = 0;
                    break;
            }

            #region Font
            GameFont=new BaseObject[objNumber];
           
            for (int i = 0; i < objNumber / 10; i++)
            {
                _size = rnd.Next(20, 200);
                GameFont[i] = new Planet(this, new Point(rnd.Next(50, Width - 50), rnd.Next(0, Heigth - 50)), new Size(_size, _size), new Point(-rnd.Next(10, 20), 0));
            }
            for (int i = objNumber / 10; i < objNumber / 10 + objNumber / 5; i++)
            {
                _size = rnd.Next(40, 70);
                GameFont[i] = new Star(this, new Point(rnd.Next(50, Width - 50), rnd.Next(0, Heigth - 50)), new Size(_size + 10, _size), new Point(-rnd.Next(1, 5), 0));
            }
            for (int i = objNumber / 10 + objNumber / 5; i < objNumber; i++)
            {
                _size = rnd.Next(5, 10);
                GameFont[i] = new Planet(this, new Point(rnd.Next(50, Width - 50), rnd.Next(0, Heigth - 50)), new Size(_size, _size), new Point(-rnd.Next(1, 10), 0));
            }
            #endregion

            #region GameObjects

            if (CountShipAster!=0)
            {
                MainShip = new Ship(this, new Point(30, this.Heigth / 2), new Size(50, 50));

                #region standart spavn of asteroids

                // Asteroids = new Asteroid[CountShipAster-1];//вернуть в случае нормального спавна
                //for (int i = 0; i < Asteroids.Length; i++)
                //{
                //    Asteroids[i] = new Asteroid(this, new Point(rnd.Next(50, Width - 50) + this.Width, rnd.Next(0, Heigth - 50)), new Size(40, 40), new Point(-10, 0));
                //}

                #endregion

                Asteroids=new List<Asteroid>();
                for (int i = 0; i < CountShipAster - 1; i++)
                {
                    Asteroids.Add(new Asteroid(this, new Point(rnd.Next(50, Width - 50) + this.Width, rnd.Next(0, Heigth - 50)), new Size(40, 40), new Point(-10, 0)));
                }

                Bullets =new Bullet[MaxBulletNum];   
            }

            #endregion
        }

        /// <summary>
        /// Метод, останавливающий текущий таймер, отвечающий за процесс обновления фона
        /// </summary>
        public void StopTimer()
        {
            timer.Stop();
        }

        /// <summary>
        /// Метод, создающий новый таймер, отвечающий за процесс обновления фона
        /// </summary>
        public void StartNewTimer()
        {
            timer = new Timer { Interval = Speed };
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        /// <summary>
        /// Метод, запускающий текущий таймер, отвечающий за процесс обновления фона
        /// </summary>
        public void StartTimer()
        {
            timer.Start();
        }

        /// <summary>
        /// Метод, описывающий действия во время каждого "тика" таймера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            Drow();
            Update();
            //запись в файл при помощи делегата
            Destroided?.Invoke(this.MainShip);
            Destroided = null;
        }

        /// <summary>
        /// Метод, изменяющий частоту "тиков" текущего таймера
        /// </summary>
        /// <param name="speed"></param>
        public void ChangeTimeScale(int speed)
        {
            Speed = speed;
            timer = new Timer { Interval = Speed };
            timer.Start();
            timer.Tick += Timer_Tick;

        }

        /// <summary>
        /// Метод, очищающий буфер и вызывающий одноимённый метод для каждого объекта в массиве
        /// </summary>
        public void Drow()
        {
            Buffer.Graphics.Clear(Color.Black);
            for (int i = 0; i < ObjectNumber; i++)
            {
                GameFont[i].Drow();
            }
            if (ScreenMode=="Game")
            {
                for (int i = 0; i < Asteroids.Count; i++)
                {
                    Asteroids[i].Drow();
                }
                MainShip.Drow();

                for(int i=0;i<NumOfBull;i++)
                {
                    Bullets[i].Drow();
                }
            }
            Buffer.Render();
        }

        /// <summary>
        /// Метод, вызывающий одноимённый метод для каждого объекта в массиве
        /// </summary>
        public void Update()
        {
            for (int i = 0; i < ObjectNumber;i++)
            {
                GameFont[i].Update();
            }
            if (ScreenMode == "Game")
            {

                var groupeByIsDestroided = Asteroids.GroupBy(e => e.IsDestroed);

                if (groupeByIsDestroided.Count()==1 && groupeByIsDestroided.First().Key==true)
                {
                    Random rnd = new Random();
                    foreach (var asteroid in Asteroids)
                    {
                        asteroid.pos = new Point(rnd.Next(50, Width - 50) + this.Width, rnd.Next(0, Heigth - 50));
                        asteroid.IsDestroed = !true;
                    }
                    Asteroids.Add(new Asteroid(this, new Point(this.Width, rnd.Next(0, Heigth - 50)), new Size(40, 40), new Point(-10, 0)));
                }


                for (int i = 0; i < Asteroids.Count; i++)
                {
                    Asteroids[i].Update();
                }
                MainShip.Update();

                for (int i = 0; i < NumOfBull; i++)
                {
                    Bullets[i].Update();
                }
            }
        }
        
        /// <summary>
        /// Метод, создающий, и добавляющий в общий массив (пока) пули
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Timer_Tick1(object sender, EventArgs e)
        {
           
           // BulletsL.Add(new Bullet(this, new Point(MainShip.pos.X + 42, MainShip.pos.Y + 20), new Size(20, 10), new Point(25, 0)));
            
            if (NumOfBull != 0)
                {
                    for (int i = NumOfBull; i > 0; i--)
                    {
                    Bullets[i] = Bullets[i - 1];
                    }
                Bullets[0] = new Bullet(this, new Point(MainShip.pos.X + 42, MainShip.pos.Y + 20), new Size(20, 10), new Point(25, 0));
                NumOfBull++;

                }
                else
                {
                    Bullets[0] = new Bullet(this, new Point(MainShip.pos.X + 42, MainShip.pos.Y + 20), new Size(20, 10), new Point(25, 0));
                    NumOfBull++;

                }
                
        }

    }
}
