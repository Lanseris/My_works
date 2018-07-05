using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOne
{
   public class Class1
    {

        #region Задание 4
        public void Swap()
        {
            int a = 1, b = 5;
            Console.WriteLine("ДО");
            Console.WriteLine("a = {0}\nb = {1}",a,b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine();
            Console.WriteLine("ПОСЛЕ");
            Console.WriteLine("a = {0}\nb = {1}", a, b);
            Console.WriteLine("Ожидание...");
            Console.ReadLine();
        }
        #endregion
        #region Задание 3
        public void Distance()
        {
            int x1, x2, y1, y2;
            Console.WriteLine("Вводить только целые числа (в предалах типа Int)");
            Console.WriteLine("Введите координаты первой точки:");
            Console.Write("X: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты второй точки:");
            Console.Write("X: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y: ");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Расчёты произведены, расстояние между указанными точками: {0:F2}",Distance(x1,y1,x2,y2));
            Console.WriteLine("Ожидание...");
            Console.ReadLine();
        }
        double Distance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        #endregion
    }
}
