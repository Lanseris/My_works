using System;
using System.Collections.Generic;
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
using Models.Interfaces;
using Models;

namespace ServiceDesk
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private IJobsModel model = null;

        public LoginWindow()
        {
            InitializeComponent();
            model = new JobsModel();
        }

        private void showJobsButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow view = new MainWindow();
            JobsPresenter presenter = new JobsPresenter(view, model);
            view.Owner = this;
            view.Show();
        }
    }
}
