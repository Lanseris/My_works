
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Support;

namespace LTwo
{
    class Program
    {
        // (задание 1) Метод, возвращающий минимальное из трёх чисел
        static int MinX3(int a,int b, int c)
        {
            return a < b && a < c ? a : b < c && b < a ? b : c;
            /*
            if (a < b && a < c)
                return a;
            else if (b < c && b < a)
                return b;
            else
                return c;
            */
        }


        //(задание 2) Метод подсчета количества цифр числа
        static int NumberLength(int a)
        {
            return Convert.ToString(a).Length;
        }

        //(задание 3) Подсчёт суммы нечётных положительных чисел
        static void SumU0()
        {
            int a,sum=0;
            Console.WriteLine(" (для завершения ввода чисел введите 0)");
            do
            {
                Console.WriteLine("Введите число : ");
                a = Convert.ToInt32(Console.ReadLine());
                if (a % 2 != 0)
                    sum += a;
            } while (a!=0);
            Console.WriteLine("Сумма всех нечётных чисел: {0}",sum);
        }


        //(задание 4) Проверка логина и пароля
        static bool Login()
        {
            string trueLog = "root", truePas="password", log, pas;
            int i = 0;
            Console.WriteLine("Приветствие...");
            do
            {
                Console.Write("Введите логин: ");
                log = Console.ReadLine();
                Console.Write("Введите пароль: ");
                pas = Console.ReadLine();
                if (log == trueLog && pas == truePas)
                { 
                    Console.WriteLine("Авторизация прошла успешно.\n");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine("Неверный логин или пароль, у вас осталось {0} попыток.\n",3-i);
                }
            } while (i<3);
            if (i != 3)
                return true;
            else
                return false;
        }


        //(Задание 5) Расчёт индекса массы и рекомендации
        static void IMT()
        {
            double mass, rost,imt,sbros;
            Console.WriteLine("Введите Вес (кг):");
            mass = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Рост (см):");
            rost = Convert.ToDouble(Console.ReadLine());

            imt = mass / (rost * rost / 10000);

            Console.WriteLine("Ваш индекс массы тела: {0:N2}", imt);



            if (imt > 18.5 && imt < 24.99)
            {
                Console.WriteLine("Ваш вес в норме, поздравляю!!!");
            }else if(imt < 18.5)
            {
                sbros = (18.5 - imt) * (rost * rost / 10000);
                Console.WriteLine("Недобор массы, рекомендуем набрать: {0:N2} кг.", sbros);
            }else if (imt > 25 && imt < 30)
            {
                sbros = (imt - 24.99) * (rost * rost / 10000);
                Console.WriteLine("Избыточная масса тела, рекомендуем сбросить: {0:N2} кг.", sbros);
            }
            else if (imt > 30 && imt < 35)
            {
                sbros = (imt - 24.99) * (rost * rost / 10000);
                Console.WriteLine("Ожирение первой степени! Настоятельно рекомендуем сбросить: {0:N2} кг.", sbros);
            }
            else if (imt > 35 && imt < 40)
            {
                sbros = (imt - 24.99) * (rost * rost / 10000);
                Console.WriteLine("Ожирение второй степени!!! НАСТОЯТЕЛЬНО РЕКОМЕНДУЕМ СБРОСИТЬ: {0:N2} кг.", sbros);
            }
        }


        //(Задание 6) "Хорошие числа"
        // 7 минут (первый вариант в лоб, помимо вычислений вставлял различные выводы информации)
        static void GoodNumbers()
        {
            int sum, kolvo = 0, t1, t2 = 0, max = 0, n = 0;
            DateTime date_time = DateTime.Now;
            DateTime end;

            for (int i= 1; i<1000000000;i++)
            {
                sum = 0;
                //отслеживание момента увеличения порядка для получения первых десяти чисел нового порядка
                //и времени данного события
                if (Convert.ToString(i).Length > max)
                {
                    Console.WriteLine();
                    end = DateTime.Now;
                    Console.WriteLine(end - date_time);

                    Console.WriteLine("Порядок: {0}",Convert.ToString(i).Length);
                    Console.WriteLine();
                    max = Convert.ToString(i).Length;
                    n = 1;
                }
                //-----------------------------------------
                // ОСНОВНОЙ цикл для проверки каждого числа на то, делится ли оно на сумму своих цифр или нет
                foreach(var j in Convert.ToString(i))
                {
                    sum += (int)Char.GetNumericValue(j);
                }
                if (i % sum == 0)
                {
                    //t1 = t2;
                    //t2 = i;
                    kolvo++;
                //вывод первых десяти чисел каждого нового опрядка (внутри основного цикла)
                    if (n != 0)
                    {
                        Console.WriteLine("{0:N}   {0}/{1}", i, sum);
                        n--;
                    }
                    // { Console.WriteLine("{0}   {0}/{1}    {2}-{3}={4}", i, sum, t2, t1, t2 - t1); n--; }
                }
            }
            Console.WriteLine("Количество таких чисел: {0}", kolvo);
            end = DateTime.Now;
            Console.WriteLine(end-date_time);
        }
        // 11 секунд (второй вариант спустя полтора часа^^)
        static void GoodNumbers2()
        {
            int sum = 0, number = 0, kolvo = 0;
            int i, a, b, c, d, e, f, g, h;
            DateTime date_time = DateTime.Now;
            DateTime end;
            
 
                for ( i = 0; i < 10; i++)
                {
                    for ( a = 0; a < 10; a++)
                    {
                        for ( b = 0; b < 10; b++)
                        {
                            for ( c = 0; c < 10; c++)
                            {
                                for ( d = 0; d < 10; d++)
                                {
                                    for ( e = 0; e < 10; e++)
                                    {
                                        for ( f = 0; f < 10; f++)
                                        {
                                             for ( g = 0; g < 10; g++)
                                             {
                                                  for ( h = 0; h < 10; h++)
                                                  {
                                                      sum = i + a + b + c + d + e + f + g + h;
                                                      if (sum == 0)
                                                      continue;
                                                      number++; 
                                                      if (number % sum == 0)
                                                      { kolvo++; }
                                                  }
                                             }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            end = DateTime.Now;
            Console.WriteLine("Количество таких чисел: {0:N1}", kolvo);
            Console.WriteLine(end - date_time);
        }



       
        //(Задание 7) Вывод и сумма чисел от a до b используя рекурсивный метод
        static int FromAtoB(int a,int b)
        {
            if (a == b) return a;
            return FromAtoB(a, b - 1)+b;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("В программе не проверок на ввод неверного формата.");

            //Проверка медода подсчёта количества цифр в числе
            Console.WriteLine("Введите число для определения количества цифр в нём (int): ");
            Console.WriteLine("Количество цифр: {0}", NumberLength(Convert.ToInt32(Console.ReadLine())));
            ConsoleExt.ClearScr();

            // Проверка нахождения минимального из трёх чисел
            int a, b, c;
            Console.WriteLine("Нахождение минимального числа из 3-ёх (int).");
            Console.Write("первое: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("второе: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("третье: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Минимальное число: {0}", MinX3(a, b, c));
            ConsoleExt.ClearScr();

            // Проверка подсчёта суммы нечётных чисел
            Console.WriteLine("Подсчёт суммы нечётных чисел (int)");
            SumU0();
            ConsoleExt.ClearScr();

            //Проверка ввода логина и пароля
            Console.WriteLine("Ввод логина и пароля");
            Login();
            ConsoleExt.ClearScr();

            //Проверка расчёта индекса массы тела
            Console.WriteLine("Расчёт IMT и рекомендации");
            IMT();
            ConsoleExt.ClearScr();

            //Проверка метода поиска хороших чисел
            //   GoodNumbers();
            Console.WriteLine("Ожидание нахождения всех хороших чисел в числе 1 000 000 000... \n(самый быстрый способ придуманный мнойприерно 11 секунд)");
            GoodNumbers2();
            ConsoleExt.ClearScr();

            //Проверка рекурсивного метода подсчёта суммы чисел от a до b
            Console.WriteLine("Рекурсивный метод нахождения суммы целых чисел от a до b");

            Console.WriteLine("Введите первое число для рекурсивной функции: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число для рекурсивной функции: (первое должно быть меньше второго)");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( FromAtoB(a,b));
            ConsoleExt.ClearScr();

        }
    }
}
