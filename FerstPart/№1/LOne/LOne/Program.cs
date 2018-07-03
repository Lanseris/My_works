using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOne
{
    class Program
    {

        static void Main(string[] args)
        {
            int l;
            do
            {
                Console.WriteLine(" ВНИМАНИЕ!!!\n Проверки на неверный формат введённых данных в программе не предусмотрено.\n\nПроверка заданий, введите номер класса для теста \n 1 класс (1,2,5 задания)\n 2 класс (3,4 задания)\n 3 класс (6 задание)\n для выхода введите 10\n");
                l = Convert.ToInt32(Console.ReadLine());
                
                switch (l)
                {
                    case 1:
                        Worksheet a = new Worksheet();
                        a.IMT();

                        a.Print(a.formPrint, 2, 7);
                        HelpClass.ClearSkreen();
                        break;
                    case 2:
                        Class1 b = new Class1();
                        b.Swap();
                        b.Distance();
                        HelpClass.ClearSkreen();
                        break;
                    case 3:
                        HelpClass.Paus();
                        HelpClass.ClearSkreen();
                        break;
                    default:
                        break;
                }

            } while (l != 10);

            Console.WriteLine("Вроде выполнил все пункты, буду рад критике");
            Console.WriteLine("Ожидание...");
            Console.ReadLine();
        }
    }
}
