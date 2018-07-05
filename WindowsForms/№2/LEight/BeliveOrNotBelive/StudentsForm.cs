using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLib;

namespace BeliveOrNotBelive
{
    public partial class StudentsForm : Form
    {
        private StudentsList f_studemts;
        public StudentsForm()
        {
            InitializeComponent();
        }

        private void Load_CSV_But_Click(object sender, EventArgs e)
        {
            try
            {
                f_studemts = new StudentsList();
                MessageBox.Show("Студенты загружены из CSV", "Успех");
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так...", "Error!!!");
            }
            
        }

        private void Ser_But_Click(object sender, EventArgs e)
        {
            try
            {
                f_studemts.Save();
                MessageBox.Show("Студенты загружены в XML (советую проверить файл после завершения работы программы, т к когда я проверял в процессе работы, у меня упал комп^^)", "Успех");
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так...", "Error!!!");

            }

        }

        private void DeSer_But_Click(object sender, EventArgs e)
        {
            try
            {
                f_studemts.Load();
                MessageBox.Show("Студенты загружены из XML", "Успех");
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так...", "Error!!!");

            }

        }
    }
}
