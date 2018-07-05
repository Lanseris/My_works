using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSevenHW
{
    public partial class DocTemplate : Form
    {
        private MainMenu parentForm;

        public DocTemplate(MainMenu PF)
        {
            InitializeComponent();
            parentForm = PF;
        }
        private Element[] a;
        struct Element
        {
            public string tag;
            public string str;

            public Element(string tag, string newString)
            {
                this.tag = tag;
                str = newString;
            }
        }

        private bool CheckContent(TextBox a)
        {
            return String.IsNullOrEmpty(a.Text);
        }

        private void Request_Button_Click(object sender, EventArgs e)
        {
            if (CheckContent(OrgName_TB) || CheckContent(OrgFace_TB) || CheckContent(PersPost_TB) || CheckContent(FIO_TB))
            {
                MessageBox.Show("Вы не заполнили одно из тектовых полей!!!");
            }
            else if (Start_DTP.Value >= End_DTP.Value)
            {
                MessageBox.Show("Отрицательный отпуск?");
            }else
            {
                string s = File.ReadAllText("shablon.txt");
                // Заполним массив элементов, сопоставив тегам соответствующий текст
                a = new Element[8] {
            new Element ( "name1" , OrgName_TB.Text ),
            new Element ( "name2" , OrgFace_TB.Text ),
            new Element ( "name3" , PersPost_TB.Text ),
            new Element ( "name4" , FIO_TB.Text ),
            new Element ( "name5" , FIO_TB.Text),
            new Element ( "data1" , Start_DTP.Text ),
            new Element ( "data2" , End_DTP.Text ),
            new Element ( "data3" , DateTime.Now.Date.ToLongDateString() ),
                };
                // Пробежимся по массиву и поменяем все вхождения тегов на текст
                foreach (var el in a)
                {
                    Regex reg = new Regex("<" + el.tag + ">");
                    s = reg.Replace(s, el.str);
                }
                label8.Text = s;
                MessageBox.Show("Запрос сформирован", "Успех");
            }

           
        }

        private void DocTemplate_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.docTemplate_ = null;
        }
    }
}
