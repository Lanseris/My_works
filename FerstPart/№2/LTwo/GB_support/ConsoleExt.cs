using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Support
{
    public class ConsoleExt
    {
        public static void Pause()
        {
            Console.WriteLine("Нажмите клавишу Enter для продолжения...");
            Console.ReadLine();
        }
        public static void ClearScr()
        {
            Console.WriteLine("Очистить экран? да/нет");
            string answer;
            answer = Console.ReadLine();
            if (answer == "да" || answer == "lf")
                Console.Clear();
        }
    }
}
