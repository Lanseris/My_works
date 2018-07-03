using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GB_Support;
using System.IO;
//Класс для работы с одномерным массивом
namespace LFourHW
{
    class Arrays
    {
        private int[] a;
        const string file_name = "array_1.txt";

        //Инициализация одномерного массива
        public Arrays(int x)
        {
            this.a = new int[x];
        }

        //Инициализация и заполнение массива через файл
        public Arrays()
        {
            FileStream file_stream = new FileStream(file_name, FileMode.Open, FileAccess.Read);
            StreamReader file_reader = new StreamReader(file_stream);
            try
            {
                int numbersCount=0;
                string myArray,number="";
                myArray =file_reader.ReadLine();

                for (int j = 0; j < myArray.Length; j++)
                {
                    if (myArray[j] == ' ')
                    numbersCount++;
                }

                this.a = new int[numbersCount];
                int g=0,i = 0;
                while (i!= myArray.Length)
                {
                    if (myArray[i] != ' ')
                    {
                        number += myArray[i];
                    }
                    else
                    {
                        Int32.TryParse(number, out this.a[g]);
                        number = "";
                        g++;
                    }
                    i++;   
                }

            }
            finally
            {
                file_reader.Close();
                file_stream.Close();
            }
        }
        //Заполнение файла array_1 массивом
        public void FillFileByArray()
        {
            FileStream file_stream = new FileStream(file_name, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter file_writer = new StreamWriter(file_stream);
            try
            {
                file_writer.Write(string.Empty);
                for (int i = 0; i < this.a.Length; i++)
                {
                    file_writer.Write(this.a[i] + " ");
                }
            }
            finally
            {
                file_writer.Close();
                file_stream.Close();
            }
        }
        //Заполнение одномерного массива значекниями (x y- минимальное и максимальное значние для рандома)
        public void FillRandArr(int x,int y)
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < this.a.Length; i++)
                this.a[i] = rnd.Next(x, y);
        }

        //Заполнение массива начиная с начального значения и заданным шагом
        public void FillArrStartAndStep(int x, int y)
        {
            this.a[0] = x;
            for(int i=1;i< this.a.Length;i++)
            {
                this.a[i] = a[i-1] + y;
            }
        }

        //Поиск пар с числом, делящимся на 3,в одномерном массиве
        public int SearchPair()
        {
            int pairs=0;
            for(int i=0; i < this.a.Length ; i++)
            {
                if (this.a[i] == 0)
                    continue;
                if (i == 0 && this.a[i] % 3 == 0)
                {
                    pairs++;
                    continue;
                }
                else 
                if ((this.a[i] % 3 == 0 && this.a[i - 1] % 3 != 0 && i != this.a.Length - 1) || (this.a[i] % 3 == 0 && this.a[i - 1] == 0 && i != this.a.Length - 1))
                    pairs += 2;
                else if ((this.a[i] % 3 == 0 && this.a[i - 1] % 3 == 0) || (this.a[i] % 3 == 0 && i == this.a.Length - 1 && this.a[i-1]%3!=0))
                    pairs++;
            }
            return pairs;
        }

        //Вывод одномерного массива на консоль
        public void ArrayConsoleOutput()
        {
            for(int i=0;i<this.a.Length;i++)
            {
                Console.WriteLine("a[{1}] = {0}",this.a[i],i);
            }
        }

        //(СВОЙСТВО) Сумма всех элементов массива
        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < this.a.Length; i++)
                {
                    sum += this.a[i];
                }
                return sum;
            }
        }

        //Изменение знаков элементов массива на противоположные
        public void Invers()
        {
            for (int i = 0; i < this.a.Length; i++)
            {
                if (this.a[i] > 0)
                {
                    this.a[i] = -this.a[i];
                    continue;
                }
                if (this.a[i] < 0)
                    this.a[i] = Math.Abs(this.a[i]);
            }
        }

        //Метод, умножающий каждый элемент массива на определённое число
        public void Multi(int x)
        {
            for(int i=0;i<this.a.Length;i++)
            {
                a[i] = a[i] * x;
            }
        }

        //(СВОЙСТВО) Возвращающее количество максимальных элементов
        public int MaxCount
        {
            get
            {
                int max=-int.MaxValue,count=0;
                for(int i=0; i<this.a.Length;i++)
                {
                    if (this.a[i] > max)
                    {
                        max = this.a[i];
                        count = 1;
                        continue;
                    }
                    if (this.a[i] == max)
                        count++;
                }
                return count;
            }
        }
    }
}
