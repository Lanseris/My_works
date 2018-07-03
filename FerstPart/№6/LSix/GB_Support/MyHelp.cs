using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Support
{

    public class MyHelp
    {
        static string logo =
     @"
______                            _                            _               
|  _  \                          | |                          | |              
| | | |__ _  __ _  __ _  ___ _ __| |     __ _ _   _ _ __   ___| |__   ___ _ __ 
| | | / _` |/ _` |/ _` |/ _ \ '__| |    / _` | | | | '_ \ / __| '_ \ / _ \ '__|
| |/ / (_| | (_| | (_| |  __/ |  | |___| (_| | |_| | | | | (__| | | |  __/ |   
|___/ \__,_|\__, |\__, |\___|_|  \_____/\__,_|\__,_|_| |_|\___|_| |_|\___|_|   
             __/ | __/ |                                                       
            |___/ |___/                                               2018
";


        public static void ShowLogo(string taskName)
        {
            Console.WriteLine(logo);
            string mess = $"= Welcome to excercise: {taskName} =";
            Console.WriteLine(new string('=', mess.Length));
            Console.WriteLine(mess);
            Console.WriteLine(new string('=', mess.Length));
        }

        //Пауза
        public static void Pause()
        {
            Console.WriteLine("Нажмите клавишу Enter для продолжения...");
            Console.ReadLine();
        }

        //Очистка консоли
        public static void ClearScr()
        {
            string answer;
            Console.WriteLine("\n Очичтить экран? да/нет");
            answer = Console.ReadLine();
            if (answer == "да" || answer == "lf")
                Console.Clear();
        }

        //Наибольший общий делитель двух ЦЕЛЫХ чисел
        public static int Nod(int n, int d)
        {
            n = Math.Abs(n);
            d = Math.Abs(d);
            while (d != 0 && n != 0)
            {
                if (n % d > 0)
                {
                    var temp = n;
                    n = d;
                    d = temp % d;
                }
                else break;
            }
            if (d != 0 && n != 0) return d;
            return 0;
        }

        //Рандомное число (не работает нормально если вызвать при заполнении массива...)
        public static int Rnd(int x, int y)
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            return rnd.Next(x, y);
        }
    }
}

