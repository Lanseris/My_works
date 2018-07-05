using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LFourHW
{
    class ArraysTwo
    {
        public int[,] a;
        public int IdXMax,IdYMax;
        const string file_name = "array_2.txt";

        //Инициализация x y размеры, g z диапазон рандома
        public ArraysTwo(int x,int y,int g,int z)
        {
            this.a = new int[x,y];

            Random rnd = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < x; i++)
            {
                for(int j = 0; j < y; j++)
                {
                    this.a[i, j] = rnd.Next(g,z);
                }
            }
        }

        //Вывод массива на консоль
        public void ArraysTwoToConsole()
        {
            for (int i = 0; i <=this.a.GetUpperBound(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j <=this.a.GetUpperBound(1); j++)
                {
                    Console.Write("{0} ", this.a[i, j]);
                }
            }
            Console.WriteLine();
        }

        //Сумма всех элементов
        public int Sum()
        {
                int sum = 0;
                for (int i = 0; i <=this.a.GetUpperBound(0); i++)
                {
                    for (int j = 0; j <=this.a.GetUpperBound(1); j++)
                    {
                        sum += this.a[i,j];
                    }
                }
                return sum;
        }

        //Сумма элементов, которые больше заданного значения
        public int SunBiggerThen(int x)
        {
            int sum = 0;
            for (int i = 0; i <= this.a.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= this.a.GetUpperBound(1); j++)
                {
                    if(this.a[i, j]>x)
                    sum += this.a[i, j];
                }
            }
            return sum;
        }

        //(СВОЙСТВО) минимального элемента массива
        public int Min
        {
            get
            {
                int min = int.MaxValue;
                for (int i = 0; i <= this.a.GetUpperBound(0); i++)
                {
                    for (int j = 0; j <= this.a.GetUpperBound(1); j++)
                    {
                        if (this.a[i, j] < min)
                            min = this.a[i, j];
                    }
                }
                return min;
            }
        }

        //(СВОЙСТВО) Максимального элемента массива
        public int Max
        {
            get
            {
                int max = int.MinValue;
                for (int i = 0; i <= this.a.GetUpperBound(0); i++)
                {
                    for (int j = 0; j <= this.a.GetUpperBound(1); j++)
                    {
                        if (this.a[i, j] > max)
                            max = this.a[i, j];
                    }
                }
                return max;
            }
        }

        //Метод возвращающий индекс элемента с максимальным значением
        static public void IdMaxValue(ref int [,]b, out int idXMax, out int idYMax)
        {
            int max = int.MinValue;
            idXMax = 0;
            idYMax = 0;
            for (int i = 0; i <= b.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= b.GetUpperBound(1); j++)
                {
                    if (b[i, j] > max)
                    {
                        max = b[i, j];
                        idXMax = i;
                        idYMax = j;
                    }

                }
            }
        }

        //Конструктор заполнения из файла (массивы массивов не считает)
        public ArraysTwo()
        {
            FileStream file_stream = new FileStream(file_name, FileMode.Open, FileAccess.Read);
            StreamReader file_reader = new StreamReader(file_stream);
            try
            {
                int CountY = 1, CountX = 0;
                string myString, number = "";
                //Подсчёт количества элементов в строке
                myString = file_reader.ReadLine();
                for (int i = 0; i < myString.Length; i++)
                {
                    if (myString[i] == ' ')
                        CountX++;
                }
                //Подсчёт строк
                while(!file_reader.EndOfStream)
                {
                    myString = file_reader.ReadLine();
                    CountY++;
                }
                //Инициализация массива
                a = new int[CountY, CountX];
                int g = 0, h = 0, j = 0;


                file_reader.BaseStream.Position = 0;
                //Считывание значений из файла
                while (!file_reader.EndOfStream)
                {
                    myString = file_reader.ReadLine();
                    while (j != myString.Length)
                    {
                        if (myString[j] != ' ')
                        {
                            number += myString[j];
                        }
                        else
                        {
                            Int32.TryParse(number, out this.a[h, g]);
                            number = "";
                            g++;
                        }
                        j++;
                    }
                    g = 0;
                    j = 0;
                    h++;
                }
            }
            finally
            {
                file_reader.Close();
                file_stream.Close();
            }
        }

        //Заполнение файла
        public void FillFileByArrayTwo()
        {
            FileStream file_stream = new FileStream(file_name, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter file_writer = new StreamWriter(file_stream);
            try
            {
                for (int i = 0; i <= this.a.GetUpperBound(0); i++)
                {
                    for (int j = 0; j <= this.a.GetUpperBound(1); j++)
                    {
                        file_writer.Write(this.a[i, j] + " ");
                    }
                    file_writer.WriteLine();
                }
            }
            finally
            {
                file_writer.Close();
                file_stream.Close();
            }
        }
    }
}
