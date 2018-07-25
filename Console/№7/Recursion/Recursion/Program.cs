using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static List<int> a = new List<int> { 1, 2, 5, 10, 20, 4 };

        //рекурсивная функция подсчёта суммы всех элементов
        static int Sum(List<int> a)
        {
            //Базовый случай 
            #region Base
            if (!a.Any())
                return 0;
            #endregion

            //Рекурсивный случай
            #region Recurse
            else
            {
                int b = a.ElementAt(0);    //Рекурсивный случай
                return b + Sum(a.GetRange(1, a.Count - 1));
            }
            #endregion
        }

        //рекурсивная функция для подсчёта элементов
        static int NumberOfItems(List<int>a)
        {
            //Базовый случай
            #region Base
            if (!a.Any())
                return 0;
            #endregion

            //Рекурсивный случай
            #region Recurse
            else
            {
                return 1 + NumberOfItems(a.GetRange(1, a.Count - 1));  
            }
            #endregion
        }

        //рекурсивная функция нахождеиня максимального элемента
        static int Max(List<int> a)
        {
            //Базовый случай
            #region Base

            if (a.Count == 2)
                return a.First() > a.Last() ? a.First() : a.Last();
            #endregion

            //Рекурсивный случай
            #region Recurse
            else
            {
                List<int> b = new List<int>();
                b = a;
                if (b.First() > b.ElementAt(1))
                    b.RemoveAt(1);
                else
                    b.RemoveAt(0);

                return Max(b);
            }
            #endregion
        }

        //Розочка на торте, бинарный поиск используя тот же принцип 
        static bool BinarySearch(List<int> SortedList, int SearchingNumber)
        {
            //Базовый случай
            #region Base
            int midleIndex = SortedList.Count / 2;
            if (SortedList.ElementAt(midleIndex) == SearchingNumber)
                return true;
            if (SortedList.Count == 1)
                return false;
            #endregion

            //Рекурсивный случай
            #region Recurse
            if (SortedList.ElementAt(midleIndex)>SearchingNumber)
                    return BinarySearch(SortedList.GetRange(0,midleIndex),SearchingNumber);
                else
                    return BinarySearch(SortedList.GetRange(midleIndex,SortedList.Count - midleIndex), SearchingNumber);
            #endregion
        }


        static void Main(string[] args)
        {

            foreach(var item in a)
                Console.Write("{0} ",item);
            Console.WriteLine();

            Console.WriteLine("Сумма всех элементов {0}",Sum(a));

            Console.WriteLine("Количество элементов {0}",NumberOfItems(a));

            Console.WriteLine("Максимальное значение {0}",Max(a));

            //Проверка бинарного поиска

            a = new List<int> { 1, 2, 5, 10, 20, 4, 15, 25, 6, 11, 21, 42, 86, 29, 3 };

            a.Sort();

            foreach (var item in a)
                Console.Write("{0} ", item);
            Console.WriteLine();

            string ansver;
            int searchingNumber;
            Console.WriteLine("Если хотите закончить тестирование бинарного поиска введите exit.");
            while (true)
            {
                Console.WriteLine("Введите число для поиска: ");
                ansver = Console.ReadLine();
                if (ansver == "exit"||ansver=="Exit")
                    break;
                searchingNumber = Int32.Parse(ansver);

                Console.WriteLine("Найдено ли число: {0}", BinarySearch(a, searchingNumber));
            }
            Console.ReadLine();
        }
    }
}
