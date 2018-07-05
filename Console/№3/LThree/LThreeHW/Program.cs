using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GB_Support;
namespace LThreeHW
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Complex (первое задание)
            //Проверка класса Complex (первое задание)
            Complex c,b=new Complex(1,3),a = new Complex(5,6);

            Console.Write("Первое комплексное число: ");
            a.GetC();

            Console.Write("Второе комплексное число: ");
            b.GetC();

            Console.Write("Сумма первого и второго: ");
            c = a.Add(b);
            c.GetC();

            Console.Write("Разность первого и второго: ");
            c = a.CSub(b);
            c.GetC();

            Console.Write("Произведение первого и второго: ");
            c = a.CMult(b);
            c.GetC();

            Console.Write("Частное первого и второго: ");
            c = a.CSeg(b);
            c.GetC();

            #endregion
            
            ConsoleExt.ClearScr();

            #region Сумма нечётных положительных чисел
            string v;
            int g, sum = 0;
            Console.WriteLine(" (для завершения ввода чисел введите 0)");
            do
            {
                Console.WriteLine("Введите число : ");
                v = Console.ReadLine();

                if (Int32.TryParse(v, out g))
                {
                    if (g % 2 != 0 && g > 0)
                        sum += g;
                }
                else
                    Console.WriteLine("{0} вводить нужно число!!!", v);

            } while (v != "0");
            Console.WriteLine("Сумма всех нечётных чисел: {0}", sum);
            #endregion

            ConsoleExt.ClearScr();

            #region проверка класса Fraction 
            Fraction result,
            l = new Fraction(25,100),
            k = new Fraction(9,15);

            Console.Write("Первая дробь: ");
            l.FGet();

            Console.Write("Вторая дробь: ");
            k.FGet();

            Console.WriteLine("Сумма");
            result = Fraction.FSum(l, k);
            result.FGet();

            Console.WriteLine("Разность");
            result = Fraction.FResidual(l, k);
            result.FGet();

            Console.WriteLine("Перемножение");
            result = Fraction.FMult(l, k);
            result.FGet();

            Console.WriteLine("Частное");
            result = Fraction.FSeg(l, k);
            result.FGet();
            #endregion 

            ConsoleExt.Pause();
        }
    }
}
