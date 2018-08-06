using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DataCorel;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Workers_Datal
{
    /// <summary>
    /// Interaction logic for AddExistingEmployeeWindow.xaml
    /// </summary>
    public partial class AddExistingEmployeeWindow : Window
    {
        public MainWindow Par { get; set; }
        public AddExistingEmployeeWindow(MainWindow par)
        {
            Par = par;
            InitializeComponent();
            DataContext = this;

            AddEmpBt.Click += delegate
            {
                if (EmployeersCb.SelectedIndex!=-1)
                {
                    if (Par.DataCore_.DepartmentStore_.ExistingEmployeeAdd(Par.DepListView.SelectedIndex,
                        EmployeersCb.SelectedIndex))
                    {
                        MessageBox.Show("Работник успешно добавлен.");
                        Par.EmpList = new List<Employee>(Par.DataCore_.DepartmentStore_.Departments[Par.DepListView.SelectedIndex].Employees);
                    }
                    else
                   {
                    MessageBox.Show("Работьник не был добавлен.");
                    }
                }
                else
                {
                    MessageBox.Show("Работьник не был добавлен.");
                }
                Close();
            };
        }
    }
}
