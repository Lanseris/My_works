using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GB_Support;

namespace LThreeHW
{
    class Fraction
    {
        int numerator;
        int denumerator;

        public Fraction(int a,int b)
        {
            FSet(a,b);
        }

        //Сумма дробей
        public static Fraction FSum(Fraction z, Fraction k)
        {
            Fraction result;
            if (z.denumerator == k.denumerator)
            {
                result = new Fraction(z.numerator + k.numerator, z.denumerator);
                result.FractionSimple();
                return result;
            }
            else
            {
                result = new Fraction(z.numerator * k.denumerator + k.numerator * z.denumerator, z.denumerator * k.denumerator);
                result.FractionSimple();
                return result;
            }
            
        }
        //Разность дробей
        public static Fraction FResidual(Fraction z, Fraction k)
        {
            Fraction result;
            if (z.denumerator == k.denumerator)
            {
                result = new Fraction(z.numerator - k.numerator, z.denumerator);
                result.FractionSimple();
                return result;
            }
            else
            {
                result = new Fraction(z.numerator * k.denumerator - k.numerator * z.denumerator, z.denumerator * k.denumerator);
                result.FractionSimple();
                return result;
            }
        }
        //Перемножение дробей
        public static Fraction FMult(Fraction z, Fraction k)
        {
            Fraction result;
            result = new Fraction(z.numerator * k.numerator, z.denumerator * k.denumerator);
            result.FractionSimple();
            return result;
        }
        //Деление дробей
        public static Fraction FSeg(Fraction z, Fraction k)
        {
            Fraction result;
            result = new Fraction(z.numerator * k.denumerator, k.numerator * z.denumerator);
            result.FractionSimple();
            return result;
        }
        // Метод упрощения дробей
        public void FractionSimple()
        {
            int nod = ConsoleExt.Nod(this.numerator, this.denumerator);
            this.numerator /= nod;
            this.denumerator /= nod;
        }
        //Вывод на консоль
        public void FGet()
        {
            Console.WriteLine("{0}/{1}",this.numerator,this.denumerator);
        }
        //Присваивание новых значений
        public void FSet(int a,int b)
        {
            if(a!=0 && b!=0)
            {
                this.numerator = a;
                this.denumerator = b;
            }else if (b==0)
            {
                Console.WriteLine("В знаминателе не может быть нуля!!!");
            }else
            {
                Console.WriteLine("Значение числителя равно нулю, а значит и вся дробь равна нулю.");
            }
        }
    }
}