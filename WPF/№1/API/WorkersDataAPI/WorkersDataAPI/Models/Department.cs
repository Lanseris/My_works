using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkersDataAPI.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public List<Employee> Employees { get; set; }

        public Department() { }

        public Department(int id)
        {
            Id = id;
        }
    }
}