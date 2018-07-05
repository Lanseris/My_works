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
    public partial class Doubler : Form
    {
        private MainMenu parentForm;
        private List<int> history = new List<int>();

        public Doubler(MainMenu PF)
        {
            InitializeComponent();
            parentForm = PF;
        }

        private void AddOne_Button_Click(object sender, EventArgs e)
        {
            var x = int.Parse(Value_Label.Text);
            NumberOfAction_Label.Text = (int.Parse(NumberOfAction_Label.Text) + 1).ToString();
            Value_Label.Text = (x+1).ToString();
            history.Add(1);
        }

        private void Double_Button_Click(object sender, EventArgs e)
        {
            var x = int.Parse(Value_Label.Text);
            NumberOfAction_Label.Text = (int.Parse(NumberOfAction_Label.Text) + 1).ToString();
            Value_Label.Text = (x * 2).ToString();
            history.Add(2);
        }

        private void ResetButtonClick(object sender, EventArgs e)
        {
            Value_Label.Text = "1";
            TryNumber_Label.Text = (int.Parse(TryNumber_Label.Text) + 1).ToString();
            NumberOfAction_Label.Text = "0";
        }

        private Random a = new Random();
        private void NewGame()
        {
            NeededValue_Label.Text = a.Next(2, 20).ToString();
            MessageBox.Show( NeededValue_Label.Text, "Необходимое значение.");
            Value_Label.Text = "1";
            NumberOfAction_Label.Text = "0";
            TryNumber_Label.Text = "1";
        }

        private void NewGame_Batton_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void Doubler_Shown(object sender, EventArgs e)
        {
            NewGame();
        }

        private void Value_Label_TextChanged(object sender, EventArgs e)
        {
            if(Value_Label.Text==NeededValue_Label.Text)
            {
                if (MessageBox.Show($"Количество действий:{NumberOfAction_Label.Text} Попыток:{TryNumber_Label.Text}\n Начать новую игру?", "Победа", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    NewGame();
            }else if(int.Parse(Value_Label.Text)> int.Parse(NeededValue_Label.Text))
            {
                MessageBox.Show($"Вы превысили необходимое значение", "Провал");
                Value_Label.Text = "1";
                TryNumber_Label.Text = (int.Parse(TryNumber_Label.Text) + 1).ToString();
                NumberOfAction_Label.Text = "0";
            }
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            Value_Label.Text = "1";
            NumberOfAction_Label.Text = "0";
            TryNumber_Label.Text = (int.Parse(TryNumber_Label.Text) + 1).ToString(); ;
        }

        private void Chit_batton_Click(object sender, EventArgs e)
        {
            var x = int.Parse(Value_Label.Text);
            if (history.Count==0)
            {

            }else if(history.Last() == 1)
            {
                Value_Label.Text = (x - 1).ToString();
                history.RemoveAt(history.Count - 1);
                NumberOfAction_Label.Text= (int.Parse(NumberOfAction_Label.Text) - 1).ToString();
            }
            else if(history.Last()==2)
            {
                Value_Label.Text = (x / 2).ToString();
                history.RemoveAt(history.Count - 1);
                NumberOfAction_Label.Text = (int.Parse(NumberOfAction_Label.Text) - 1).ToString();
            }
        }

        private void Doubler_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.doubler_ = null;
        }
    }
}
