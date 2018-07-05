
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GB_Support;

namespace LFuveHW
{
    class Program
    {

        static void Main(string[] args)
        {
             MyHelp.ShowLogo("Regexes 1.0.0");

            //Проверка логина
            User a = new User();
            MyHelp.ClearScr();

            //Проверка нахождения и замены слов заканчивающихся на 'е'
            Message b = new Message("Message.txt");
            Console.WriteLine("Замена слов с окончанием на Е");
            Console.WriteLine(b.message);
            Console.WriteLine(b.FindAndDestr('е'));
            MyHelp.ClearScr();

            //Проверка на анограмму
            Console.WriteLine("Проверка на анограмму двумя методами при вводе 123 и 312");
            Console.WriteLine(b.TwoStringsEqual("123", "312"));
            Console.WriteLine(b.TwoStringsEqualLyambda("123", "312"));
            MyHelp.ClearScr();


            //Проверка нахождения самых длинных слов
            Console.WriteLine("Нахождение длинных слов");
            Console.WriteLine();
            Console.WriteLine(b.message);
            Console.WriteLine("Длинные слова:");
            foreach (string h in b.FindLongWord())
            {
                Console.WriteLine(h);
            }
            MyHelp.ClearScr();

            //проверка быстродействия методов нахождения слов длиной, меньше указанной, через split и через регулярные выражения
            Console.WriteLine("Проверка быстродействия методов нахождения слов длиной,\n меньше указанной (5 символов)");
            Console.WriteLine("Подождите секунд 20... (алгоритмы проверяются в циклах\n с итерацией до 1е5)");
            int testSize = (int)1e5;
            var timer = Stopwatch.StartNew();
            for (int i = 0; i < testSize; i++)
            {
                b.FindWords(5);
            }
            timer.Stop();
            Console.WriteLine($"{"Через регулярки".PadRight(20)}: {timer.Elapsed.TotalSeconds:0.000}s");

            timer.Reset();
            timer.Start();
            for (int i = 0; i < testSize; i++)
            {
                b.CleanFindWords(5);
            }
            timer.Stop();
            Console.WriteLine($"{"Без регулярок".PadRight(20)}: {timer.Elapsed.TotalSeconds:0.000}s");
            Console.WriteLine();
            Console.WriteLine(b.message);
            Console.WriteLine();

            foreach (string c in b.FindWords(5))
                Console.Write(c+" ");

            MyHelp.ClearScr();

            //Проверка ЕГЭ
            Console.WriteLine("ЕГЭ");
            string[] learners = new string[] 
            {
            "Иванов_1 Петр 4 3 3",
            "Иванов_2 Петр 5 5 1",
            "Иванов_3 Петр 2 4 3",
            "Иванов_4 Петр 4 5 1",
            "Иванов_5 Петр 4 3 3",
            "Иванов_6 Петр 3 5 3",
            "Иванов_7 Петр 2 5 4",
            "Иванов_8 Петр 4 2 3",
            "Иванов_9 Петр 5 5 3",
            "Иванов_10 Петр 4 5 1",
            "Иванов_11 Петр 2 5 3",
            "Иванов_12 Петр 5 5 3",
            "Иванов_13 Петр 3 5 2",
            "Иванов_14 Петр 2 5 3",
            "Иванов_15 Петр 4 2 3",
            "Иванов_16 Петр 2 5 1",
            "Иванов_17 Петр 2 5 3",
            };
            Losers losers = new Losers(learners);

            foreach(Learner c in losers.LosersOfLosers())
            {
                Console.WriteLine($"{c.name} {c.secondName.PadRight(10)} Средняя оценка:{c.meedle:0.00}");
            }

            MyHelp.Pause();
        }
    }
}
