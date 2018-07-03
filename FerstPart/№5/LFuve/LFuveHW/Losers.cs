using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFuveHW
{
    class Losers
    {
        private Learner[] learners;

        public Losers(string[] lists)
        {
            this.learners = new Learner[lists.Length];
            for(int i=0;i<learners.Length;i++)
                learners[i] = new Learner(lists[i]);
        }

        public Learner[] LosersOfLosers()
        {
            this.learners = this.learners.OrderBy(l => l.meedle).ToArray();
            return learners.Where(l => l.meedle <= learners[2].meedle).ToArray();
        }
    }
}
