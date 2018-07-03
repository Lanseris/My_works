using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace LogicLib
{
    //класс списка студентов для сериализации
    public class StudentsList
    {
        private List<Student> student_list;
        public List<Student> student_listGet { get => student_list; }
        private string file_Name = "students_1.csv";
        private string file_NameSer = "students_1.xml";

        //заполнение списка из CSV
        public StudentsList()
        {

            using (var g = new System.IO.StreamReader(file_Name))
            {
                student_list = new List<Student>();
                while (!g.EndOfStream)
                {
                    try
                    {
                        string[] s = g.ReadLine().Split(';');
                        student_list.Add(new Student(s[1], s[0], int.Parse(s[2]), int.Parse(s[2])));
                    }
                    catch
                    {
                    }
                }
            }

        }
        //сериализация списка студентов
        public void Save()
        {
            var serializer = new XmlSerializer(typeof(List<Student>));
            using (var file = System.IO.File.Create(file_NameSer))
            {
                serializer.Serialize(file, student_list);
            }
        }

        //десериализация списка студентв
        public void Load()
        {
            student_list.Clear();
            var serializer = new XmlSerializer(typeof(List<Student>));
            using (var file = System.IO.File.OpenRead(file_NameSer))
            {
                var new_list = (List<Student>)serializer.Deserialize(file);
                student_list.AddRange(new_list);
            }
        }
    }
}
