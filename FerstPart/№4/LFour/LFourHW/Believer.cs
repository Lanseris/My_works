using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LFourHW
{
    class Believer
    {
        public int correctAnsv=0;
        public Dictionary<string, bool> a;
        Dictionary<string, bool> b;
        const string file_name = "yesno.txt";
        private int countOfQuestions = 0;
        
       
            

        public Believer()
        {
            string myString;
            a = new Dictionary<string, bool>();
            FileStream file_stream = new FileStream(file_name, FileMode.Open, FileAccess.Read);
            StreamReader file_reader = new StreamReader(file_stream);
            try
            {
                //Считывание значений из файла
                while (!file_reader.EndOfStream)
                {
                   myString=file_reader.ReadLine();
                    if (myString[myString.Length - 1] == '1')
                        a.Add(myString.Substring(0, myString.Length - 2),true );
                    else
                        a.Add(myString.Substring(0, myString.Length - 2), false);
                    this.countOfQuestions++;
                }
            }
            finally
            {
                file_reader.Close();
                file_stream.Close();
            }
            
            Random rnd = new Random((int)DateTime.Now.Ticks);
            int randomIndex;
            
            //Отбор вопросов
           var en =  a.GetEnumerator();
            b = new Dictionary<string, bool>();
            en.MoveNext();
            while (b.Count!=5)
            {
                randomIndex = rnd.Next(0, a.Count);
                for (int i = 0; i < randomIndex; i++)
                    en.MoveNext();
                b.Add(en.Current.Key, en.Current.Value);
                a.Remove(en.Current.Key);
                en = a.GetEnumerator();
                en.MoveNext();
            }
        }

        public void Menu()
        {
            string ansver;
            var en = b.GetEnumerator();

            int p = 0;
            do
            {
                en.MoveNext();
                Console.WriteLine(en.Current.Key + "\n да/нет");
                ansver = Console.ReadLine();
                if (ansver == "да"&& en.Current.Value==true)
                    correctAnsv++;
                else if(ansver == "нет" && en.Current.Value == false)
                    correctAnsv++;
                p++;
            } while (p != 5);
            

        }
    }
}
