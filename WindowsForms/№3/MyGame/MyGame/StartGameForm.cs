using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
    public partial class StartGameForm : Form
    {
        private MainScreen gameScreen;

        public StartGameForm()
        {
            InitializeComponent();
            gameScreen = new MainScreen();
            gameScreen.Init(this, "Game");
        }

        /// <summary>
        /// Инициализация MainScreen с игровым параметром (добавляет астероиды и корабль помимо основного фона)
        /// запуск таймера обновления счёта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartGameForm_Shown(object sender, EventArgs e)
        {
            this.timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        /// <summary>
        /// выводит счёт в лэйбл (розовеньким)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Score: " + gameScreen.score.ToString();
            label2.Text = "HP: " + gameScreen.MainShip.hp;
        }

        private void StartGameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            gameScreen.StopTimer();
        }

        private void StartGameForm_Deactivate(object sender, EventArgs e)
        {
            gameScreen.StopTimer();
        }

        private void StartGameForm_Activated(object sender, EventArgs e)
        {
            gameScreen.StartTimer();
        }

        /// <summary>
        /// основное управление
        /// пробел-стрельба
        /// стрелочки вверх и вниз изменение положения корабля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartGameForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 32:
                    gameScreen.shootTimer.Start();
                    break;
                case 38:
                    gameScreen.MainShip.dir = new Point(0, -10);
                    break;
                case 40:
                    gameScreen.MainShip.dir = new Point(0, 10);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// тоже относится к управлению
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartGameForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 32:
                    gameScreen.shootTimer.Stop();
                    break;
                case 38:
                    gameScreen.MainShip.dir = new Point(0, 0);
                    break;
                case 40:
                    gameScreen.MainShip.dir = new Point(0, 0);
                    break;
                default:
                    break;
            }
        }
    }
}
