using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFuveHW
{
    class Learner
    {
        public string name;
        public string secondName;
        private int[] ocenki;
        public double meedle;

        public Learner(string info)
        {
            string[] a = info.Split(' ');
            name = a[1];
            secondName = a[0];
            ocenki = new int[3];
            for(int i =0;i<3;i++)
            ocenki[i] = Convert.ToInt32(a[i + 2]);
            meedle= ocenki.Average();
        }
    }
}
