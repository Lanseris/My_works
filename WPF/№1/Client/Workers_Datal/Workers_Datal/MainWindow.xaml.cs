using DataCorel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Workers_Datal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window , INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public DataCore DataCore_ { get; set; }

       public ObservableCollection<Department> DepList { get; set; }

        public List<Employee> empList;
        public List<Employee> EmpList
        {
            get
            {
                return empList;
            }
            set
            {
                this.empList = value;
                PropertyChanged?.
                    Invoke(this,
                    new PropertyChangedEventArgs(nameof(this.EmpList)));
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            DataCore_ = new DataCore();

            DepList = new ObservableCollection<Department>(DataCore_.DepartmentStore_.Departments);

            #region ViewAvents
            
            //описания событий на форме

            DepListView.SelectionChanged += delegate
            {
                ChangeEmplList();
            };

            RemDepBtn.Click += delegate
            {
                if (DataCore_.DepartmentStore_.RemoveDepartment(DepListView.SelectedIndex))
                {
                    DepList.RemoveAt(DepListView.SelectedIndex);
                }
            };

            AddDepBtn.Click += delegate
            {
                new AddDepartmentWindow(this).ShowDialog();
            };

            AddEmpBtn.Click += delegate
            {
                new AddExistingEmployeeWindow(this).ShowDialog();
            };

            AddNewEmpBtn.Click += delegate
            {
                new AddEmployeeWindow(this).ShowDialog();
            };

            RemEmpBtn.Click += delegate
            {
                if (DataCore_.DepartmentStore_.EmployeeRemove(DepListView.SelectedIndex, EmplListView.SelectedIndex))
                {
                    EmpList=new List<Employee>(DataCore_.DepartmentStore_.Departments[DepListView.SelectedIndex].Employees);
                }
            };

            #endregion

        }

        public void ChangeEmplList()
        {
            if (DepListView.SelectedIndex!=-1)
            {
                 EmpList= DataCore_.DepartmentStore_.Departments[DepListView.SelectedIndex].Employees;
            }
        }

        
    }
}
