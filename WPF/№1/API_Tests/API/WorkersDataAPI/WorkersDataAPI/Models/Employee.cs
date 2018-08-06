using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkersDataAPI.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string FerstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }

        public Employee(int id)
        {
            ID = id;
        }
    }
}