using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSixHW
{
     class difficultTask
    {
        public int[] a;

       public void Save(string fileName, int n)
        {
            Random rnd = new Random();
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            for (long i = 1; i < n; i++)
            {
                bw.Write(rnd.Next(0, 100000));
            }
            fs.Close();
            bw.Close();
        }
        public void Load(string fileName)
        {
            DateTime d = DateTime.Now;
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            a = new int[fs.Length / 4]; //int - 4 байта
            for (int i = 0; i < fs.Length / 4; i++) 
            {
                a[i] = br.ReadInt32();
            }
            br.Close();
            fs.Close();
        }
       
        public void TwoMax()
        {
            ulong max = 0;
            int maxf;
            int INDmaxf, INDmaxs;

            DateTime dt = DateTime.Now;


            INDmaxf = Array.IndexOf(a, a.Max());
            maxf = a[INDmaxf];
            a[INDmaxf] = 0;

            for (int l = 0; l < 100000; l++)
            {
                INDmaxs = Array.IndexOf(a, a.Max());
                if (Math.Abs(INDmaxs - INDmaxf) >= 8)
                {
                    max = (ulong)maxf * (ulong)a[INDmaxs];
                    break;
                }
                else
                    a[INDmaxs] = 0;
            }
            Console.WriteLine(DateTime.Now - dt);
            Console.WriteLine();
            Console.WriteLine(max);
        }
    }
}
