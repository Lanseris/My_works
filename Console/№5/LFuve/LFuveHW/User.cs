using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GB_Support;
namespace LFuveHW
{
    class User
    {
        private string Login;
        private string Password;

        public User()
        {
            string str_1;

            Console.WriteLine("Регистрация аккаунта ");
            Console.WriteLine("Условия логина (от 2-ух до 10-ти символов, первый символ не должен быть цифрой)");
            Console.WriteLine("Введите логин:");

            while (string.IsNullOrEmpty(this.Login))
            {
                
                str_1 = Console.ReadLine();
                str_1.Trim();

                if (str_1 == string.Empty)
                {
                    Console.WriteLine("Вы ничего не ввели");
                    Console.WriteLine("Повторите попытку");
                }
                else if (char.IsDigit(str_1[0]))
                {
                   Console.WriteLine("Первый символ логина не может быть ЦИФРОЙ!");
                    Console.WriteLine("Повторите попытку");

                }
                else
                {
                   Regex expression = new Regex(@"\w{2,10}");
                   var matches = expression.Matches(str_1);
                   if (matches.Count != 1 || str_1.Length > 10)
                   {
                       Console.WriteLine("Неверное количество символов");
                        Console.WriteLine("Повторите попытку");

                    }
                    else
                    {
                        Console.WriteLine("Успешно");
                        Login = str_1;
                    }
                }
            }
            this.Password = "123";

        }
    }
}
