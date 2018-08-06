using DataCorel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using MessageBox = System.Windows.Forms.MessageBox;


namespace Workers_Datal
{
    /// <summary>
    /// Interaction logic for AddEmployeeWindow.xaml
    /// </summary>
    public partial class AddEmployeeWindow : Window
    {
        public MainWindow Par { get; set; }
        public AddEmployeeWindow(MainWindow par)
        {
            Par = par;
            InitializeComponent();
        }

        private void AddEmpBt_Click(object sender, RoutedEventArgs e)
        {
            if (EmpNameTb.Text.Trim()!="" && EmpSNameTb.Text.Trim() != "" && EmpAgeTb.Text.Trim() != "" && EmpMailTb.Text.Trim() != "" && EmpPhonTb.Text.Trim() != "")
            {
                Par.EmpList.Add(new Employee(
                    EmpNameTb.Text.Trim(),
                    EmpSNameTb.Text.Trim(), 
                    Int32.Parse(EmpAgeTb.Text.Trim()), 
                    EmpMailTb.Text.Trim(), 
                    EmpPhonTb.Text.Trim(),
                     Par.EmpList.Count==0?0:Par.EmpList.Last().ID+1
                    ));

                Par.DataCore_.DepartmentStore_.EmployeeAdd(Par.DepListView.SelectedIndex,Par.EmpList.Last());
                MessageBox.Show("Работник успешно добавлен");
                Close();
            }
        }
    }
}
