using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Interfaces;

namespace Models
{
    public class JobsModel:IJobsModel
    {
        public IEnumerable<Job> jobs = null;

        private IEnumerable<Job> jobsQ;

        public event EventHandler<JobEventArgs> JobUpdated = delegate { };

        private DbServiceDeskModel mContext;
        
        public JobsModel()
        {
            mContext = new DbServiceDeskModel();
            IQueryable<Job> query = mContext.Jobs;
            jobsQ = query.AsEnumerable();
        }
      
        public IEnumerable<Job> GetJobs()
        {
            return jobs ?? (jobs = jobsQ.ToList()); 
        }

        public Job GetJob(int jobId)
        {
            return mContext.Jobs.Find(jobId);
            // Что лучше, то что сверху или
            //return jobs.Where(c => c.JobId == jobId).First();
        }

        public void UpdateJob(Job job)
        {
            JobUpdated(this, new JobEventArgs(job));
        }
    }
}
