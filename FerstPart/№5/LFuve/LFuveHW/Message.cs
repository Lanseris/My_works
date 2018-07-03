using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


namespace LFuveHW
{
    class Message
    {
        public string message;
        private static char[] wordBoundariesSymbols = new char[] { ' ', '\t', '\n', '.', ',' };


        //заполнение из файла
        public Message(string file_name)
        {
            var file_stream = new FileStream(file_name, FileMode.OpenOrCreate, FileAccess.Read);
            var stream_reader = new StreamReader(file_stream);
            try
            {
                message = stream_reader.ReadToEnd();
            } finally
            {
                stream_reader.Close();
                file_stream.Close();
            }

        }

        
        //поиск всех слов, количество символов которых меньше или равно переданному (регулярки)
        public string[] FindWords(int n)
        {
            string regString = $@"\b\w{{0,{n}}}\b";
            Regex expression = new Regex(regString);
            var matches = expression.Matches(this.message);

            return matches.Cast<Match>().Where(b=>b.Length!=0).Select(b=>b.ToString()).ToArray();
        }
        //поиск всех слов, количество символов которых меньше или равно переданному (split)
        public string[] CleanFindWords(int n)
        {
            return message.Split(wordBoundariesSymbols, StringSplitOptions.RemoveEmptyEntries).Where(el => el.Length <= n).ToArray();
        }


        //поиск и удаление всех слов, заканчивающийся на переданный символ
        public string FindAndDestr(char symbol)
        {
            string regString = $@"\b\w*[{symbol}]\b";
            Regex expression = new Regex(regString);
            this.message= expression.Replace(this.message,"ЗАМЕНЕНО ");
            return this.message;
        }


        //поиск самого длинного слова сообщения
        public string[] FindLongWord()
        {
            int max = int.MinValue;
            string regString = $@"\b\w*\b";
            Regex expression = new Regex(regString);
            var matches = expression.Matches(this.message);

            foreach (var c in matches)
            {
                if(c.ToString().Length>max)
                {
                    max = c.ToString().Length;
                }
            }
            return matches.Cast<Match>().Where(l => l.ToString().Length == max).Select(l=>l.ToString()).ToArray();
        }


        //Проверка на анограмму
        public bool TwoStringsEqual(string str_1, string str_2)
        {
            char[] str1 = str_1.ToCharArray();
            char[] str2 = str_2.ToCharArray();
            Array.Sort(str1);
            Array.Sort(str2);
            str_1 = new string(str1);
            str_2 = new string(str2);
            if (Equals(str_1, str_2))
            {
                return true;
            }
            else
                return false;
        }
        public bool TwoStringsEqualLyambda(string str_1,string str_2)
        {
            return str_1.OrderBy(c => c).Zip(str_2.OrderBy(c => c), (c1, c2) => c1 == c2).All(b => b);
        }



        
    }
}
