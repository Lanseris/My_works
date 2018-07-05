using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSevenHW
{
    public partial class GuessNumber : Form
    {
        private MainMenu parentForm;

        public GuessNumber(MainMenu PF)
        {
            InitializeComponent();
            parentForm = PF;

        }

        private Random a = new Random();
        private int NumberToGuess;

        private bool Compare_(TextBox textBox)
        {
            return int.Parse(textBox.Text) == NumberToGuess;
        }

        private void NewGame()
        {
            NumberToGuess = a.Next(1, 100);
            MessageBox.Show("Старт!", "Число загадано, вводите значения...");
            label5.Text = NumberToGuess.ToString();
        }

        private void NewNumber_button_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void GuessNumber_Shown(object sender, EventArgs e)
        {
            NewGame();
        }

        private void TrueOrFalse_Button_Click(object sender, EventArgs e)
        {
            if (Compare_(textBox1))
            {
                NumberOfTrys_Label.Text = (int.Parse(NumberOfTrys_Label.Text) + 1).ToString();
                if (MessageBox.Show($"Количество попыток:{NumberOfTrys_Label.Text}\n Начать новую игру?", "Победа", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    NewGame();
            }
            else
            {
                NumberOfTrys_Label.Text = (int.Parse(NumberOfTrys_Label.Text) + 1).ToString();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (Compare_(textBox1))
                {
                    NumberOfTrys_Label.Text = (int.Parse(NumberOfTrys_Label.Text) + 1).ToString();
                    if (MessageBox.Show($"Количество попыток:{NumberOfTrys_Label.Text}\n Начать новую игру?", "Победа", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        NewGame();
                }
                else
                {
                    NumberOfTrys_Label.Text = (int.Parse(NumberOfTrys_Label.Text) + 1).ToString();
                }
            }else
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void GuessNumber_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.guessNumber_ = null;
        }
    }
}
