using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class JobEventArgs : EventArgs
    {
        public Job Job { get; set; }
        public JobEventArgs(Job job)
        {
            Job = job;
        }
    }
}
