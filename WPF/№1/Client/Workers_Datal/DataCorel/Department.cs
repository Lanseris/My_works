using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCorel
{
    public class Department //: IEnumerable
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public List< Employee> Employees { get; set; }

        //private int count;

        public int Count => Employees.Count;

        public Department()
        {

        }

        public Department(string DepName)
        {
            DepartmentName = DepName;
            //count = 0;
            Employees = new List<Employee>();
        }

        #region Убрано для корректной десериализации объекта с апи сервера, даже не помню зачем я это сюда воткнул...
        /*
        /// <summary>
        /// Реализация интерфейса IEnumerable
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Employees.Count; i++)
            {
                yield return Employees[i];
            }
        }
        */
        #endregion

        public void EmployeeAdd(string FName, string SName, int age, string mail, string phoneNumber)
        {
            if (Employees.Count!=0)
            Employees.Add( new Employee(FName, SName, age, mail, phoneNumber, Employees.LastOrDefault().ID + 1));
            else
            Employees.Add( new Employee(FName, SName, age, mail, phoneNumber,0));
        }

        public void EmployeeAdd(Employee emp)
        {
            Employees.Add(emp);
            //this.count++;
        }

        public bool EmployeeRemuve(int id)
        {
            if (Employees.Any(e=>e.ID==id))
            {
               Employees.RemoveAt(Employees.FindIndex(e => e.ID == id));
               // this.count--;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
