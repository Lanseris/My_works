using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LogicLib
{
    public class QuestionList
    {
        private List<Question> f_Questions = new List<Question>();

        public List<Question> f_QuestionsGet { get => f_Questions; }

        private string f_FileName;

        public int QuestionCount => f_Questions.Count;

        public Question this[int index]=>f_Questions[index];

        public QuestionList(string file_name)
        {
            f_FileName = file_name;
        }

        public void AddQustion(string text,bool is_true)
        {
            f_Questions.Add(new Question(text, is_true));
        }

         public void RemuveQustion(int index)
        {
            f_Questions.RemoveAt(index);
        }


        public void Save()
        {
            var serializer = new XmlSerializer(typeof(List<Question>));
            using (var file = System.IO.File.Create(f_FileName))
            {
                serializer.Serialize(file, f_Questions);
            }
        }

        public void SaveAs(string file_Name_Enter)
        {
            f_FileName = file_Name_Enter;
            Save();
        }

        public void Load()
        {
            f_Questions.Clear();
            var serializer = new XmlSerializer(typeof(List<Question>));
            using (var file = System.IO.File.OpenRead(f_FileName))
            {
                var new_list = (List<Question>)serializer.Deserialize(file);
                f_Questions.AddRange(new_list);
            }
        }
    }
}
