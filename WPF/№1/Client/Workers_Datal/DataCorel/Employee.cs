using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCorel
{
    public class Employee
    {
        public int ID { get; set; }
        public string FerstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }

        public Employee()
        {

        }

        public Employee(string FName, string SName, int age, string mail, string phoneNumber, int id)
        {
            ID = id;
            FerstName = FName;
            SecondName = SName;
            Age = age;
            Mail = mail;
            PhoneNumber = phoneNumber;
        }

        public Employee(string FName, string SName, int age, string mail, string phoneNumber)
        {
            FerstName = FName;
            SecondName = SName;
            Age = age;
            Mail = mail;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return string.Format("ID:{5} FerstName:{0} SecondName:{1} Age:{2} \nMail:{3} PhoneNumber:{4}", FerstName, SecondName, Age, Mail, PhoneNumber, ID);
        }
    }
}
