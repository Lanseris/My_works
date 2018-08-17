using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
    public interface IJobsModel
    {
        void UpdateJob(Job job);
        IEnumerable<Job> GetJobs();
        Job GetJob(int Id);
        event EventHandler<JobEventArgs> JobUpdated;
    }
}
