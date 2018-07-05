using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOne
{
    public class Worksheet
    {
        String name, famil, otch,city;
        public String formPrint;
        double mass, rost,imt;

        public Worksheet()
        {           
            Console.WriteLine("Заполнение анкеты");
            Console.WriteLine("Введите Фамилию :");
            famil = Console.ReadLine();
            Console.WriteLine("Введите Имя :");
            name = Console.ReadLine();
            Console.WriteLine("Введите Отчество :");
            otch = Console.ReadLine();
            Console.WriteLine("Введите Город проживания :");
            city = Console.ReadLine();
            Console.WriteLine("Введите Вес (кг):");
            mass = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Рост (см):");
            rost = Convert.ToDouble(Console.ReadLine());
            formPrint = " Фамилия: " + famil + " Имя: " + name + " Город:" + city; 
            Console.Clear();
            Console.WriteLine("Анкета заполнена успешно: \n Фамилия: {1}\n Имя: {0}\n Отчество: {2}\n Вес и рост: {3}/{4}", name, famil, otch, mass, rost);
            Console.WriteLine("Ожидание...");
            Console.ReadLine();
        }
        public void Print(String a,int x, int y)
        {
            int g;
            Console.WriteLine("Демонстрация вывода информации на экран 2-мя способами");
            Console.WriteLine("Каким методом вывода вы бы хотели воспользоваться:\n через костыль используя введённые координаты (ввести 1)\n используя метод, созданный умными людьми (ввести 2)");
            g = Convert.ToInt32(Console.ReadLine());
            if (g==1)
            {
                Console.WriteLine("Костыли - это плохо, и для вашей же бозопасности координаты были определены заранее");
                String KostbIl = " ";
                for (int i = 0; i < y; i++)
                {
                    KostbIl = KostbIl + "\n";
                }
                for (int i =0;i<x;i++)
                {
                    KostbIl=KostbIl+"\t";
                }
               
                KostbIl = KostbIl + a;
                Console.WriteLine(KostbIl);
            }
            else
            {
                Console.SetCursorPosition((Console.WindowWidth - a.Length) / 2, Console.CursorTop);
                Console.WriteLine(a);
            }
            
            Console.WriteLine("Ожидание...");
            Console.ReadLine();
        }
        public void IMT()
        {
            imt = mass / (rost * rost/10000);
            Console.WriteLine("Ваш индекс массы тела: {0:N2}",imt);
            Console.WriteLine("Ожидание...");
            Console.ReadLine();
        }
    }
}
