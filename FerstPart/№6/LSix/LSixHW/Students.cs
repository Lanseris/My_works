using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace LSixHW
{
    class Students
    {
        public static void Students_1()
        {
            Dictionary<string, int> z = new Dictionary<string, int>()
            {{"1",0},
            {"2",0},
            {"3",0},
            {"4",0},
            {"5",0},
            {"6",0}
            };
        
            ArrayList list = new ArrayList();

            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("students_1.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    list.Add(s[1] + " " + s[0]);
                    if (s[2] == "18" || s[2] == "19" || s[2] == "20")
                        z[s[3]]++;
                }
                catch
                {
                }
            }
            sr.Close();
            list.Sort();
            Console.WriteLine("Всего студентов:{0}", list.Count);
            foreach (var c in z)
                Console.WriteLine("{0} курс, учащихся в возрасте от 18 до 20: {1}",c.Key,c.Value);
            Console.WriteLine(DateTime.Now - dt);


        }
    }
}
