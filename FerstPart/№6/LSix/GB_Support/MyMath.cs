using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Support
{
    class MyMath
    {
        #region Faktorial
        //метод вычисления факториала на основе функционального программирования
        static void Main(string[] args)
            {
                var fact = Y<int>(f => n => n == 0 ? 1 : n * f(n - 1));
                var y = fact(5);
                Console.WriteLine(y);
            }
            private static Func<T, T> Y<T>
            (
                Func<Func<T, T>, Func<T, T>> F
            )
            => t => F(Y(F))(t);
        #endregion 
    }
}
