using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MutkiWhithStudents
{
    [Serializable]
    public class Student
    {
        [XmlElement("StudentName")]
        public string name { get; set; }

        [XmlElement("StudentSecondName")]
        public string secondName { get; set; }

        [XmlElement("StudentAge")]
        public int age { get; set; }

        [XmlElement("StudentKurs")]
        public int kurs { get; set; }

        public Student() { }

        public Student(string n,string sn, int a, int k)
        {
            name = n;
            secondName = sn;
            age = a;
            kurs = k;
        }
    }
}
