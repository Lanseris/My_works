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

namespace Game
{
    public partial class GameForm : Form
    {
        private QuestionList f_QuestionList;
        private List<Question> ListOfQuestions;
        private List<Question>.Enumerator ListOfQuestionsEn;
        public int RightAnsver { get; set; }

        public GameForm()
        {
            InitializeComponent();
        }

        //загрузка вопросов из файла и старт игры
        private void Menu_OpenNew_Click(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            var dialog = new OpenFileDialog();
            dialog.Title = "Выберите файл проекта";
            dialog.Filter = "Файлы xml (*.xml)|*.xml|Все файлы (*.*)|*.*";
            if (dialog.ShowDialog() != DialogResult.OK) return;
            f_QuestionList = new QuestionList(dialog.FileName);
            f_QuestionList.Load();

            ListOfQuestions = f_QuestionList.f_QuestionsGet;
            Start();
        }

        //Метод для старта игры
        private void Start()
        {
            ListOfQuestionsEn = f_QuestionList.f_QuestionsGet.GetEnumerator();
            RightAnsver = 0;
            ListOfQuestionsEn.MoveNext();
            label1.Text = ListOfQuestionsEn.Current.Text;
            label2.Text = "1";
            panel1.Visible = true;
        }
        //Кнопка для утверждения ответа на вопрос
        private void Ansver_But_Click(object sender, EventArgs e)
        {
            if (ListOfQuestionsEn.Current.IsTrue && True_RB.Checked || !ListOfQuestionsEn.Current.IsTrue && False_RB.Checked)
            {
                RightAnsver += 1;
            }

            if (int.Parse(label2.Text)< ListOfQuestions.Count)
            {
                label2.Text=(int.Parse(label2.Text)+1).ToString();
                ListOfQuestionsEn.MoveNext();
                label1.Text = ListOfQuestionsEn.Current.Text;
            }
            else
            {
                panel1.Visible = false;
                label1.Text = "";
                label2.Text = "";
                MessageBox.Show($"Количество верных ответов: {RightAnsver.ToString()}","Конец игры");
            }
        }

        //кнопка начала новой игры с тем же файлом, что и был загружен ранее
        private void Menu_NewGame_Click(object sender, EventArgs e)
        {
            if(f_QuestionList!=null)
            {
                Start();
            }
            else
            {
                LoadList();
            }

        }
    }
}
