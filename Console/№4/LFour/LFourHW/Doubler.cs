using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GB_Support;

namespace LFourHW
{
    class Doubler
    {
        private int current=1;
        private int finish;
        private int trys = 0;
        private int numberOfAction = 0;

        public Doubler()
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            finish = rnd.Next(2, 20);
        }

        //увеличение на один
        public void CurrentUP()
        {
            this.current++;
        }

        //умножение числа
        public void CurrentMult()
        {
            this.current *= 2;
        }

        //сброс
        public void ToStart()
        {
            this.current = 1;
            this.trys++;
        }

        //(СВОЙСТВО) возвращающее текущее значение
        public int Current
        {
            get { return this.current; }
        }

        //(СВОЙСТВО) возвращающее конечное значение
        public int Finish
        {
            get
            {
                return this.finish;
            }
        }

        //Меню игры
        public void Menu()
        {
            int action;
            Console.WriteLine("Игра закончится тогда, когда текущее значение превысит необходимое,\n либо при достижении цели.");
            Console.WriteLine("Текущее значение: {0} Необходимое значение: {1} Попыток: {2} Количество действий: {3}", this.Current, this.Finish,this.trys,this.numberOfAction);
            Console.WriteLine("Команды умножителя: ");
            Console.WriteLine("1 - Увеличить на один");
            Console.WriteLine("2 - Умножить на два");
            Console.WriteLine("3 - Сбросить до единицы");
            Console.WriteLine("Ожидание команды: ");
            
                if (int.TryParse(Console.ReadLine(), out action))
                {
                    switch (action)
                    {
                        case 1:
                            this.CurrentUP();
                        this.numberOfAction++;
                        Console.Clear();
                            break;
                        case 2:
                            this.CurrentMult();
                        this.numberOfAction++;
                        Console.Clear();
                        break;
                        case 3:
                            this.ToStart();
                        this.numberOfAction=0;
                        this.trys++;
                        Console.Clear();
                        break;
                        default:
                            Console.WriteLine("Неверная команда, повторите ввод... ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                
                }
                else
                Console.Clear();
        }
    }
}
