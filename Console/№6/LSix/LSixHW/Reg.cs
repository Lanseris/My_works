using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LSixHW
{
    //класс для поиска номеров телефонов через регулярные выражения
    class Reg
    {
        private string message;

        public void Message(string file_name)
        {
            var file_stream = new FileStream(file_name, FileMode.OpenOrCreate, FileAccess.Read);
            var stream_reader = new StreamReader(file_stream);
            try
            {
                message = stream_reader.ReadToEnd();
            }
            finally
            {
                stream_reader.Close();
                file_stream.Close();
            }

        }

        public string[] Reg_()
        {
            string regString = @"\b\d{2}[-]\d{2}[-]\d{2}\b|\b\d{3}[-]\d{3}\b|\b\d{3}[-]\d{2}[-]\d{2}\b";
            Regex expression = new Regex(regString);
            var matches = expression.Matches(this.message);
            return matches.Cast<Match>().Select(h=>h.ToString()).ToArray();
        }
       
    }
}
