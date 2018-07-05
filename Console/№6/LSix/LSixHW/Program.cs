

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GB_Support;

namespace LSixHW
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //первое задание
            delegatEexploit.Table(delegatEexploit.AX2, -2, 2,0.5, 2);
            delegatEexploit.Table(delegatEexploit.A_SINX, 0, 360, 30, 2);
            
            MyHelp.ClearScr();
            //второе задание
            fewMethods.mainMenu();
            MyHelp.ClearScr();
            //третье задание
            Students.Students_1();
            //сортировку по двум параметрам можно сделать путём IEnumerable<T> result = nonSorted.OrderBy(x => x.value1).ThenBy(x => x.value2);
            MyHelp.ClearScr();
           
            //четвёртое задане
            Reg h = new Reg();
            h.Message("Ку.txt");
            foreach(string c in h.Reg_())
            {
                Console.WriteLine(c);
            }
            
            MyHelp.ClearScr();


            difficultTask a = new difficultTask();
            Console.WriteLine("Ожидаиние поиска чисел (меньше минуты)");
            a.Save("data.bin", 10000000);
            a.Load("data.bin");
            a.TwoMax();
            MyHelp.ClearScr();

            MyHelp.Pause();
        }
    }
}
