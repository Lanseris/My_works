using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GB_Support;

namespace LFourHW
{
    class Program
    {
        static void Main(string[] args)
        {
            //Проверка первого задания
            //Поиск пары
               Arrays a = new Arrays();// (через файл)
            //  a.FillRandArr(0, 20);

             a.ArrayConsoleOutput();
            Console.WriteLine("Количество пар: {0}",a.SearchPair());
            MyHelp.ClearScr();

            //Проверка второго задания
            //Sum
            Console.WriteLine("Заполнение с шагом с 2-ух, шаг 2");
            a.FillArrStartAndStep(2, 2);
            a.ArrayConsoleOutput();
            Console.WriteLine("Свойство Sum: {0}",a.Sum);
            MyHelp.ClearScr();
            
            
            //Invers
            a.FillRandArr(-10,10);
            Console.WriteLine("Изначальные значения");
            a.ArrayConsoleOutput();
            a.Invers();
            Console.WriteLine("После метоа Invers");
            a.ArrayConsoleOutput();
            MyHelp.ClearScr();
            
            
            //Multi
            Console.WriteLine("Изначальные значения");
            a.ArrayConsoleOutput();
            a.Multi(2);
            Console.WriteLine("После метоа Multi со значением 2");
            a.ArrayConsoleOutput();
            
            //MaxCount
            Console.WriteLine();
            Console.WriteLine("Количество максимальных элементов: {0}",a.MaxCount);
            MyHelp.ClearScr();

            //Запись массива в файл
            a.FillFileByArray();

            //Проверка логина и пароля
            LoginsAndPasswords b = new LoginsAndPasswords();
            b.Log();
            MyHelp.ClearScr();

            //Работа с двумерным массивом
            //Инициализация
            //ArraysTwo n = new ArraysTwo(4, 4, 0, 10); обычный конструктор
            ArraysTwo n = new ArraysTwo(); //через файл
            n.ArraysTwoToConsole();
            Console.WriteLine("Сумма всех чисел массива: {0}",n.Sum());
            Console.WriteLine("Сумма всех чисел, которые больше пяти: {0}", n.SunBiggerThen(5));
            Console.WriteLine("Минимальное значение: {0}", n.Min);
            Console.WriteLine("Максимальное значение: {0}", n.Max);
            ArraysTwo.IdMaxValue(ref n.a,out n.IdXMax,out n.IdYMax);
            Console.WriteLine("Индекс максимального значения:[{1},{0}]",n.IdXMax,n.IdYMax);
            n.FillFileByArrayTwo();
            MyHelp.ClearScr();


            //игра удвоитель
            #region game 1
            Doubler l = new Doubler();
            do
            {
                l.Menu();
            } while (l.Current < l.Finish);

            if (l.Current == l.Finish)
                Console.WriteLine("ВЫ ПОБЕДИЛИ!!!");
            else
                Console.WriteLine("Вы превисили значение...");
            #endregion
            MyHelp.ClearScr();

            //игра верю не верю
            Believer o = new Believer();
            o.Menu();
            Console.WriteLine("Правильных ответов: {0}",o.correctAnsv);


            MyHelp.Pause();
        }
    }
}
