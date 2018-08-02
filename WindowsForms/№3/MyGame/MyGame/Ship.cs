using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
    class Ship:BaseObject
    {
        protected static Image newImage = Image.FromFile("Ship.png");

        protected int HP = 5;
        protected int MaxHp = 10;

        public int hp { get { return HP; }protected set { } }

        public Ship(MainScreen screen, Point pos, Size size) : base(screen, pos, size) { }

        public override void Drow()
        {
            Screen.Buffer.Graphics.DrawImage(newImage, Pos.X, Pos.Y, Size.Width, Size.Height);
        }
        public override void Update()
        {
            base.Update();

            foreach (Asteroid asteroid in Screen.Asteroids)
            {
                if (this.Collision(asteroid))
                {
                    if (!asteroid.IsDestroed)
                    {
                        asteroid.Destroing();
                        Screen.Destroided += asteroid.Destroing_;

                        Screen.score--;
                        HP--;
                        if (HP==0)
                        {
                            Screen.timer.Stop();
                            MessageBox.Show($"Game Over \n Score: {Screen.score}");
                            Screen._form.Close();
                        }
                    }
                    
                }
            }
           
        }

    }
}
