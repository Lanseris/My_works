using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LThreeHW
{
    class Complex
    {
        public double re;
        public double im;

        public Complex()
        {
            this.re = 0;
            this.im = 0;
        }

        public Complex(int a, int b)
        {
            this.re = a;
            this.im = b;
        }

        //Сложение комплексных чисел
        public Complex Add(Complex z)
        {
            Complex result = new Complex();
                result.re = this.re + z.re;
                result.im = this.im + z.im;
            return result;
        }

        //Получение абсолютного значения комплексного числа
        public double Abs()
        {
            return Math.Sqrt(re * re + im + im);
        }

        //Вычитание комплексных чисел
        public Complex CSub(Complex z)
        {
            Complex result = new Complex();
            result.re = this.re - z.re;
            result.im = this.im - z.im;
            return result;
        }

        //Перемножение комплексных чисел
        public Complex CMult(Complex z)
        {
            Complex result = new Complex();
            result.re = this.re * z.re-this.im*z.im;
            result.im = this.im * z.re + this.re * z.im;
            return result;
        }

        //Деление комплексных чисел
        public Complex CSeg(Complex z)
        {
            Complex result = new Complex();
            result.re = (this.re*z.re+this.im*z.im)/(Math.Pow(z.re,2)*Math.Pow(z.im,2));
            result.im = (this.im*z.re-this.re*z.im)/(Math.Pow(z.re, 2) * Math.Pow(z.im, 2));
            return result;
        }

        //Вывод значений на консоль
        public void GetC()
        {   
            Console.SetCursorPosition((Console.WindowWidth) / 2, Console.CursorTop);
            Console.WriteLine("{0:N}+{1:N}i", this.re, this.im);
        }


    }
}
