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
    public partial class Form1 : Form
    {
        private StartGameForm startGameForm;
        private MainScreen mainMenu;
        public Form1()
        {
            InitializeComponent();
            mainMenu = new MainScreen();
            mainMenu.Init(this, "MainMenu");
        }
       
        private void Form1_Shown(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
      
        /// <summary>
        /// больше чем в половине мест, в которые я пытался пихнуть Exception 
        /// прога у меня начинала творить какую-то дичь (скорее всего из-за таймеров)
        /// поэтому пихнул сюда)
        /// честно говоря, пока с этим механизмом на вы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Выкидывание своего Excrption-а");
                throw new MyException();
            }
            catch(MyException)
            {
                MessageBox.Show("Отловил свой же, просто так вызваный, Exception");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Start_But_Click(object sender, EventArgs e)
        {
            if (startGameForm == null)
            {
                startGameForm = new StartGameForm();
                startGameForm.Show();
            }
            else
            {
                startGameForm.Activate();
            }
        }

       


        private void Form1_Activated(object sender, EventArgs e)
        {
            mainMenu.StartTimer();
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            mainMenu.StopTimer();
        }
    }
}
