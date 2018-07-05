using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GB_Support;

namespace LSixHW
{
    public class fewMethods
    {
        public static double[] b;

        public delegate double SomeMethods(double x);
        //Методы для списка делегатов
        public static double F_1(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static double F_2(double x)
        {
            return x * x * x;
        }

        public static double F_3(double x)
        {
            return Math.Sin(x*Math.PI/180);
        }

        public static Dictionary<string, SomeMethods> a = new Dictionary<string, SomeMethods>()
        {
            { "0", F_1 },
            { "1", F_2 },
            { "2", F_3 }
        };

        //Главное меню пункта
        public static void mainMenu()
        {
            string i,numbers;
            double start_,
                   end_,
                   step_;
            do
            {
                Console.WriteLine("Список методов издевательств над числами:\n (Введите 0) x*x-50*x+10\n (Введите 1) x^3\n (Введите 2) sin(x)\n(Введите Min) нахождение минимума \n для выхода введите exit ");
                i=Console.ReadLine();
                if (i=="Min")
                {
                    Console.WriteLine(Min("data.bin"));
                    MyHelp.Pause();
                   
                }else if(i=="exit"||i=="Exit")
                {

                }else
                {
                    if (a.ContainsKey(i))
                    {
                        Console.WriteLine("Введите начальное значение:");
                        numbers = Console.ReadLine();
                        if (!double.TryParse(numbers, out start_))
                        {
                            Console.WriteLine("Неверное значение, возврат к списку издевательств...");
                            MyHelp.ClearScr();
                            continue;
                        }
                        Console.WriteLine("Введите конечное значение:");
                        numbers = Console.ReadLine();
                        if (!double.TryParse(numbers, out end_))
                        {
                            Console.WriteLine("Неверное значение, возврат к списку издевательств...");
                            MyHelp.ClearScr();
                            continue;
                        }
                        else if (end_ < start_)
                        {
                            Console.WriteLine("Неверное значение, начальное значение не может быть больше конечного");
                            MyHelp.ClearScr();
                            continue;
                        }
                        Console.WriteLine("Введите шаг:");
                        numbers = Console.ReadLine();
                        if (!double.TryParse(numbers, out step_))
                        {
                            Console.WriteLine("Неверное значение, возврат к списку издевательств...");
                            MyHelp.ClearScr();
                            continue;
                        }
                        else if (step_ < 0)
                        {
                            Console.WriteLine("Вы хотите сломать прогу??? возврат в списку издевательств...");
                            MyHelp.ClearScr();
                            continue;
                        }
                        fewMethods.SaveFunc(fewMethods.a[i], "data.bin", start_, end_, step_);
                        Console.WriteLine("Запись прошла успешно");
                        Load("data.bin");
                        Show();
                        MyHelp.ClearScr();
                    }
                }
            } while (i!="exit");
        }

        //вызов функции и запись значений
        public static void SaveFunc(SomeMethods F, string fileName, double start_, double end_, double step_)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            while (start_ <= end_)
            {
                bw.Write(F(start_));
                start_ += step_;
            }
            bw.Close();
            fs.Close();
        }

        //нахождение минимального значения в файле
        public static double Min(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = br.ReadDouble();
                if (d < min) min = d;
            }
            br.Close();
            fs.Close();
            return min;
        }

        public static void Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            b = new double[fs.Length / 8]; 
            for (int i = 0; i < fs.Length / 8; i++)
            {
                b[i] = br.ReadDouble();
            }
            br.Close();
            fs.Close();
        }

        public static void Show()
        {
            Console.WriteLine("Результат:");
            foreach(double i in b)
                Console.WriteLine(" {0}",i);
            Console.WriteLine();
        }
    }
}
