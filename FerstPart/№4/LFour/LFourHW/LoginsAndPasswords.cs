using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LFourHW
{
    class LoginsAndPasswords
    {
        List<string> a= new List<string>();
        const string file_name = "Log.txt";

        //Считывание из файла логинов и паролей
        public LoginsAndPasswords()
        {
            FileStream file_stream = new FileStream(file_name, FileMode.Open, FileAccess.Read);
            StreamReader file_reader = new StreamReader(file_stream);
            try
            {
                while(!file_reader.EndOfStream)
                {
                    a.Add(file_reader.ReadLine());
                }
            }
            finally
            {
                file_reader.Close();
                file_stream.Close();
            }
        }

        //Проверка логина и пароля
        public void Log()
        {
            string login, pas;
            bool h=false;
            int i = 0,j;
            Console.WriteLine("Приветствие...");
            do
            {
                Console.Write("Введите логин: ");
                login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                pas = Console.ReadLine();

                j = a.Count();
                for(int g=0;g< a.Count();g++)
                {
                    if (login == a[g] && pas == a[g+1])
                    {
                        h=true;
                        break;
                    }
                }
                if (h == true)
                {
                    Console.WriteLine("Авторизация прошла успешно.");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine("Не совпадает логин или пароль, у вас осталось {0} попыток", 3 - i);
                }
            } while (i < 3);
            if (i == 3)
                Console.WriteLine("Повторите попытку позже");
        }
    }
}
