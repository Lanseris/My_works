using Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ServiceDesk
{

    public interface IJobsView
    {
        int NONE_SELECTED { get; }
        int SelectedJobId { get; }
        void UpdateJob(Job job);
        void LoadJobs(IEnumerable<Job> jobs);
        void UpdateDetails(Job job);
        void EnableControls(bool isEnabled);
       // void SetEstimatedColor(Color? color);
        event EventHandler<JobEventArgs> JobUpdated;
        event EventHandler<JobEventArgs> DetailsUpdated;
        event EventHandler SelectionChanged;
    }

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window , IJobsView
    {
        #region Initialization
        public int NONE_SELECTED { get { return -1; } }
        public int SelectedJobId { get; private set; }

    
        public event EventHandler<JobEventArgs>
           JobUpdated = delegate { };
           

        public event EventHandler  //делегат для собитий изменения выделения задания
            SelectionChanged = delegate { };

        public event EventHandler<JobEventArgs> //делегат для событий обновления деталей задания
            DetailsUpdated = delegate { };

        public MainWindow()
        {
            InitializeComponent();
            SelectedJobId = NONE_SELECTED;
        }
        #endregion

        #region Event handlers
        private void jobsDataGrid_SelectionCellsChanged(
            object sender, SelectedCellsChangedEventArgs e)
        {
            SelectedJobId = (DGJobs.SelectedItem == null)
                ? NONE_SELECTED
                : (DGJobs.SelectedItem as Job).JobId;
            SelectionChanged(this, new EventArgs()); // события выделения другого задания
            
            
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            Job job = new Job();

            job.Name = jobNameTextBox.Text;
            job.Descr = jobDescrTextBox.Text;
            job.JobId = (DGJobs.SelectedItem as Job).JobId;

            JobUpdated(this, new JobEventArgs(job));
        }

        private void jobStatusComboBox_SelectionChanged()
        {
            //изменение статуса задания
        }

        #endregion

        #region Public Methods

        public void UpdateJob(Job job)
        {
            IEnumerable<Job> jobs= DGJobs.ItemsSource as IEnumerable<Job>;
            Job jobToUpdate = 
                jobs.Where(p => p.JobId == job.JobId)
                    .First() as Job;

            jobToUpdate.Name = job.Name;
            jobToUpdate.Descr = job.Descr;

            if (job.JobId == SelectedJobId)
                UpdateDetails(job);
        }

        public void UpdateDetails(Job job)
        {
            jobNameTextBox.Text = job.Name;
            jobDescrTextBox.Text = job.Descr;

            DetailsUpdated(this,new JobEventArgs(job));
        }

        public void LoadJobs(IEnumerable<Job> jobs)
        {
            DGJobs.ItemsSource = jobs; 
        }

        public void EnableControls(bool isEnabled)
        {
            updateButton.IsEnabled = isEnabled;
            jobDescrTextBox.IsEnabled = isEnabled;
            jobNameTextBox.IsEnabled = IsEnabled;
        }
        #endregion

    }
}
