using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Support
{
    public class ConsoleExt
    {
        //Пауза
        public static void Pause()
        {
            Console.WriteLine("Нажмите клавишу Enter для продолжения...");
            Console.ReadLine();
        }
        
        //Очистка консоли
        public static void ClearScr()
        {
            string answer;
            Console.WriteLine("\n Очичтить экран? да/нет");
            answer = Console.ReadLine();
            if (answer=="да"||answer=="lf")
                Console.Clear();
        }
        
        //Наибольший общий делитель двух ЦЕЛЫХ чисел
        public static int Nod(int n, int d)
        {
            n = Math.Abs(n);
            d = Math.Abs(d);
            while (d != 0 && n != 0)
            {
                if (n % d > 0)
                {
                    var temp = n;
                    n = d;
                    d = temp % d;
                }
                else break;
            }
            if (d != 0 && n != 0) return d;
            return 0;
        }
    }
}
