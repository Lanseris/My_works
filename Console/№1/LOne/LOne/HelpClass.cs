using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOne
{
    #region Задание 6
    public class HelpClass
    {
       public static void Paus()
        {
            Console.WriteLine("Метод Print я уже фактически сделал в пятом задании\n + в конструкции case использовался вспомогательный метод для очистки консоли");
            Console.ReadLine();
        }
        public static void ClearSkreen()
        {
            Console.WriteLine("Очистить экран? да/нет");
            string answer;
            answer = Console.ReadLine();
            if (answer == "да" || answer == "lf")
                Console.Clear();

        }
    }
    #endregion
}
