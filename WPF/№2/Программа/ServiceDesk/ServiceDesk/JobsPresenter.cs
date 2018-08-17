using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Interfaces;
using Models;

namespace ServiceDesk
{
    class JobsPresenter
    {
        #region Initialisation

        private IJobsView view = null;
        private IJobsModel model = null;

        public JobsPresenter(IJobsView jobsView, IJobsModel jobsModel)
        {
            view = jobsView;
            view.JobUpdated += view_JobUpdated;
            view.SelectionChanged += view_SelectionChanged;
            view.DetailsUpdated += view_DetailsUpdated;
            model = jobsModel;
            model.JobUpdated += model_JobUpdated;
            view.LoadJobs(model.GetJobs());


        }

        #endregion

        #region Event handlers
        
        private void view_DetailsUpdated(object sender, JobEventArgs e)
        {
            //поидее не нужен
        }

        private void view_SelectionChanged(object sender, EventArgs e)
        {
            int selectedId = view.SelectedJobId;
            if(selectedId>view.NONE_SELECTED)
            {
                Job job = model.GetJob(selectedId);
                view.EnableControls(true);
                view.UpdateDetails(job);
            }
            else
            {
                view.EnableControls(false);
            }
        }

        private void model_JobUpdated(object sender,
            JobEventArgs e)
        {
            view.UpdateJob(e.Job);
        }

        private void view_JobUpdated(object sender,
            JobEventArgs e)
        {
            model.UpdateJob(e.Job);
        }
        #endregion


    }
}
