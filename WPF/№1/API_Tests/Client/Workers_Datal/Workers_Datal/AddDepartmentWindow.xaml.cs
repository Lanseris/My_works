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
    /// Interaction logic for AddDepartmentWindow.xaml
    /// </summary>
    public partial class AddDepartmentWindow : Window
    {
        public ObservableCollection<Department> DepList { get; set; }

        public MainWindow Par { get; set; }

        public AddDepartmentWindow(MainWindow par)
        {
            InitializeComponent();
            Par = par;


            
            AddBt.Click += delegate
            {
                if (Par.DataCore_.DepartmentStore_.AddDepartment(DepNameTb.Text))
                {
                    Par.DepList.Add(new Department(DepNameTb.Text));
                    MessageBox.Show("Отдел успешно создан.");
                }
                else
                {
                    MessageBox.Show("Отдел с таким именем уже существует.");
                }

            };
            
        }

    }
}
