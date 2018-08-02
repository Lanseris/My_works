using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class Asteroid : BaseObject
    {
        protected static Image newImage = Image.FromFile("Asteroid.png");
        protected bool isDestroyed = !true;
        protected static Random rnd = new Random();

        #region LogsFileName

        protected const string FileName = "AsteroidsDestroingLoig.txt";
        
        #endregion

        public Asteroid(MainScreen screen, Point pos, Size size,Point dir) : base(screen, pos, size, dir) { }

        public override void Drow()
        {
            if (!isDestroyed)
            {
            Screen.Buffer.Graphics.DrawImage(newImage, Pos.X, Pos.Y, Size.Width, Size.Height);
            }
        }

        /// <summary>
        /// помимо Update базового класса проверяет, есть ли на игровом поле "пули"
        /// если есть, начинает по очереди проверять методом интерфейса ICollision на столкновения,
        /// если сталкивается, астероид считается уничтоженым (isDestroed= true)и увеличивает счёт на единицу
        /// визуальные изменения при столкновении пока не реализованы
        /// после ухода за край игрового поля, меняет свою позицию по высате иснова становится не уничтоженным
        /// </summary>
        public override void Update()
        {
            base.Update();

            if (Screen.NumOfBull != 0)
            {
                for (int i = 0; i <Screen.NumOfBull; i++)
                {
                    if (this.Collision(Screen.Bullets[i])&&!isDestroyed)
                    {
                        System.Media.SystemSounds.Hand.Play();
                        this.Destroing();
                        Screen.score++;

                        //делегат для логов
                        Screen.Destroided += this.Destroing_;
                    }
                }
            }

            if (IsOutOfScreen())
            {
               // isDestroyed = !true; //вернуть при обычном спавне астероидов
                Pos.Y = rnd.Next(50, Screen.Heigth - 50);
            }
        }

        public void Destroing() => isDestroyed = true;

        public bool IsDestroed
        {
            get { return isDestroyed; }
            set { isDestroyed = value; }
        }

        /// <summary>
        /// метод для делегата
        /// </summary>
        /// <param name="o"></param>
        public void Destroing_(BaseObject o)
        {
            using (var fileWriter = System.IO.File.AppendText(FileName))
            {
                fileWriter.WriteLine($"Asteroid was destroided by {o} in {pos.X}.{pos.Y} coordinates Date: {DateTime.Now}.");
            }
        }
    }
}
