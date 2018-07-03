using Game;
using LogicLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeliveOrNotBelive
{
    public partial class MainMenu : Form
    {
        private QuestionList f_QuestionList;
        private bool Changed=false;
        private GameForm Game_;
        private StudentsForm Student_;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Menu_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Обновление текст бокса с вопросами после каких либо изменений списка вопросов
        private void RefreshTextBox()
        {
            textBox1.Text = "";
            foreach (var c in f_QuestionList.f_QuestionsGet)
            {
                textBox1.Text +=c.Text+ Environment.NewLine;
            }
        }
        
        //Загрузка существующего файла
        private void Menu_Open_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Title = "Выберите файл проекта";
            dialog.Filter = "Файлы xml (*.xml)|*.xml|Все файлы (*.*)|*.*";
            if (dialog.ShowDialog() != DialogResult.OK) return;
            f_QuestionList = new QuestionList(dialog.FileName);
            f_QuestionList.Load();
            RefreshTextBox();
        }
        
        //Сохранение текущего списка вопросов в файл с новым названием
        private void Menu_SaveAs_Click(object sender, EventArgs e)
        {
            if (f_QuestionList == null) return;
            var dialog = new SaveFileDialog();
            dialog.Title = "Сохранить текущий проект";
            dialog.Filter = "Файлы xml (*.xml)|*.xml|Все файлы (*.*)|*.*";
            if (dialog.ShowDialog() != DialogResult.OK) return;
            f_QuestionList.SaveAs(dialog.FileName);
            Changed = false;
        }
            //сохранение с тем же названием
        private void Menu_Save_Click(object sender, EventArgs e)
        {
            //if (f_QuestionList != null) f_QuestionList.Save();
            f_QuestionList?.Save();
            Changed = false;
        }

        //Создание файла (с проверкой сохранени ли изменения текущего открытого списка)
        private void Menu_Create_Click(object sender, EventArgs e)
        {
            if (f_QuestionList != null && Changed==true)
            {
                if (MessageBox.Show("Сохранить изменения в текущем файле??", "Внимание!!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    f_QuestionList?.Save();
                }
            }
            var dialog = new SaveFileDialog();
            dialog.Title = "Выберите название нового проекта";
            dialog.Filter = "Файлы xml (*.xml)|*.xml|Все файлы (*.*)|*.*";
            if (dialog.ShowDialog() != DialogResult.OK) return;
            f_QuestionList = new QuestionList(dialog.FileName);
            RefreshTextBox();
            MessageBox.Show("Файл успешно создан, можете добавлять вопросы.", "Оповещение");
        }

        //кнопка интерфейса добавления вопроса
        private void Add_But_Click(object sender, EventArgs e)
        {
            if (f_QuestionList != null)
            {
                panel1.Visible = true;
                comboBox1.SelectedIndex = 0;
                Add_But.Visible = false;
                Add_But.Enabled = false;
            }
            else
            {
                MessageBox.Show("Если хотите создать новый список, то необходимо выбрать соответствующий пункт меню.");
            }
        }

        //кнопка добавления вопроса
        private void Add2_But_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text))
            {

                f_QuestionList.AddQustion(textBox2.Text, comboBox1.SelectedIndex==0 ? true :false);
            }
            panel1.Visible = false;
            RefreshTextBox();
            Add_But.Visible = true;
            Add_But.Enabled = true;
            Changed = true;
        }

        //кнопка удаления вопроса
        private void Del_But_Click(object sender, EventArgs e)
        {
            if(f_QuestionList.f_QuestionsGet.Count>0 && numericUpDown1.Value<= f_QuestionList.f_QuestionsGet.Count-1 && numericUpDown1.Value >= 0)
            {
                f_QuestionList.RemuveQustion((int)numericUpDown1.Value);
            }
            Changed = true;
            RefreshTextBox();
        }
        //Открытие формы с игрой
        private void Menu_PlayGame_Click(object sender, EventArgs e)
        {
            if (Game_ == null)
            {
                Game_ = new GameForm();
                Game_.Show();
            }
            else
            {
                Game_.Activate();
            }
        }

        private void Menu_Look_Click(object sender, EventArgs e)
        {
            if (Student_ == null)
            {
                Student_ = new StudentsForm();
                Student_.Show();
            }
            else
            {
                Student_.Activate();
            }
        }
    }
}
