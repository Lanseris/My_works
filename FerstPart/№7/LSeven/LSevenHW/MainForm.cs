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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        internal Doubler doubler_;
        internal GuessNumber guessNumber_;
        internal DocTemplate docTemplate_;
        

        private void Doubler_Button_Click(object sender, EventArgs e)
        {
            if (doubler_ == null)
            {
                doubler_ = new Doubler(this);
                doubler_.Show();
            }
            else
            {
                doubler_.Activate();
            }
        }

        private void GuessNumber_Button_Click(object sender, EventArgs e)
        {
            if (guessNumber_ == null)
            {
                guessNumber_ = new GuessNumber(this);
                guessNumber_.Show();
            }
            else
            {
                guessNumber_.Activate();
            }
        }

        private void documentTemplate_button_Click(object sender, EventArgs e)
        {
            if (docTemplate_ == null)
            {
                docTemplate_ = new DocTemplate(this);
                docTemplate_.Show();
            }
            else
            {
                docTemplate_.Activate();
            }
        }
    }
}
