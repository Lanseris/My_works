using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LogicLib
{
    [Serializable]
    public class Question
    {
        [XmlElement("QuestionText")]
        public string Text { get; set; }

        [XmlElement("is_true")]
        public bool IsTrue { get; set; }

        public Question() { }

        public Question (string text, bool is_true)
        {
            Text = text;
            IsTrue = is_true;
        }

    }
}
