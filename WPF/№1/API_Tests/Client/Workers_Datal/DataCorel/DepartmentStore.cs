using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataCorel
{
    public class DepartmentStore
    {
        public List<Department> Departments { get; set; }

        public int DId { get; set; }

        public string DName { get; set; }

        public EmploeersStore EmpStore { get; set; }

        //private const string ConnectionStr = "DepartmentData.txt"; SecondWay

        public HttpClient client = new HttpClient();

        const string StrConnection = @"
Data Source = (localDB)\MSSQLLocalDB;
Initial Catalog = coppanyData;
Integrated Security = True;";


        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="empStore"></param>
        public DepartmentStore(EmploeersStore empStore)
        {
           // CreateDepartmenssData();
            Departments = new List<Department>();

            #region SecondWay
            EmpStore = empStore;
            ReadDepartmentsData();
            //ReadDepartmentsData(ConnectionStr, EmpStore);
            //ReadLickData(ConnectionStr);
            #endregion

        }

        /// <summary>
        /// Метод, заполняющий списки работникв каждого отдела
        /// путём считывания данных из таблицы, с реализацией связи многие ко многим DepVsEmplLink
        /// </summary>
        /// <param name="connectionStr"></param>
        private void ReadLickData(string connectionStr)
        {
            string queryString = "SELECT DepID, EmplID FROM dbo.DepVsEmplLink;";
            using (SqlConnection connection = new SqlConnection(StrConnection))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader readerLK = command.ExecuteReader();
                while (readerLK.Read())
                {
                    ReadLinkRow((IDataRecord)readerLK);
                }
                readerLK.Close();
            }
        }

        /// <summary>
        /// Метод, обрабатывающий строку из таблицы DepVsEmplLink
        /// </summary>
        /// <param name="readerLK"></param>
        private void ReadLinkRow(IDataRecord readerLK)
        {
            foreach (Department department in Departments.Where(el => el.Id == Convert.ToInt32(readerLK[0])))
            {
                department.Employees.Add(EmpStore.Employeers.FirstOrDefault(e => e.ID == Convert.ToInt32(readerLK[1])));
            }
        }

        /// <summary>
        /// Метод, загружающий список отделов из таблицы
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="empStore"></param>
        public void ReadDepartmentsData() //string connectionString, EmploeersStore empStore
        {
            #region TherdWay
            client.BaseAddress = new Uri("http://localhost:49427/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new
            MediaTypeWithQualityHeaderValue("application/json"));

            var Dep = client.GetAsync(client.BaseAddress + "api/departments").Result;
            Departments = Dep.Content.ReadAsAsync<IEnumerable<Department>>().Result.ToList();
            #endregion

            #region SecondWay
            //try
            //{
            //    using (SqlConnection connection = new SqlConnection(StrConnection))
            //    {
            //        connection.Open();
            //        var sql = @"SELECT Id, Name FROM [dbo].[Departments];";

            //        SqlCommand command = new SqlCommand(sql, connection);
            //        SqlDataReader readerD = command.ExecuteReader();
            //        while (readerD.Read())
            //        {
            //            ReadDepartmentRow((IDataRecord)readerD);
            //        }
            //        readerD.Close();
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Exit");
            //}
            #endregion

        }

        /// <summary>
        /// Метод, обрабатывающий строку из таблицы Departments
        /// </summary>
        /// <param name="record"></param>
        public void ReadDepartmentRow(IDataRecord record)
        {
            DId = Convert.ToInt32(record[0]);
            DName = String.Format("{0}", record[1]);
            Departments.Add(new Department(DName) { Id=DId, Employees = new List<Employee>()});
        }

        /// <summary>
        /// Метод, создающий 10 записей департаментов
        /// </summary>
        public void CreateDepartmenssData()
        {
            try
            {
                var random = new Random();
                for (int i = 0; i < 10; i++)
                {
                    var Department = new Department
                        ($"DepName_{random.Next(0, 100)}");
                    var sql = $@"INSERT INTO Departments (Name)
                                VALUES (N'{Department.DepartmentName}')";

                    using (SqlConnection connection = new SqlConnection(StrConnection))
                    {
                        connection.Open();

                        SqlCommand command = new SqlCommand(sql, connection);
                        command.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Exit");
            }
        }


        //дальше методы, утратившие свою актуальность
        /// <summary>
        /// Метод, записывающий список отделов в файл
        /// </summary>
        public void SaveDepartmentsData()
        {
            //using (StreamWriter sw = new StreamWriter(ConnectionStr))
            //{
            //    foreach (Department department in Departments)
            //    {
            //        sw.WriteLine(department.DepartmentName);
            //        sw.WriteLine(department.Employeers?.Count ?? 0);
            //        foreach (Employee departmentEmployeer in department.Employeers)
            //        {
            //            sw.WriteLine(departmentEmployeer.ID);
            //        }
            //        sw.WriteLine();
            //    }
            //}
        }

        /// <summary>
        /// При удачном добавлении в коллекцию и записи в файл, фозвращает true
        /// </summary>
        /// <param Name of new department="DepName"></param>
        /// <returns></returns>
        public bool AddDepartment(string DepName)
        {
            if (DepName.Trim() != "" && !this.Find(DepName))
            {
                Departments.Add(new Department(DepName.Trim()));
                this.SaveDepartmentsData();
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// При удачном удалении из коллекции и записи в файл, фозвращает true
        /// </summary>
        /// <param index of removeble element="index"></param>
        /// <returns></returns>
        public bool RemoveDepartment(int index)
        {
            if (index < Departments.Count && index > -1)
            {
                Departments.RemoveAt(index);
                this.SaveDepartmentsData();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Метод поиска совпадения названия отдела
        /// </summary>
        /// <param name="DepName"></param>
        /// <returns></returns>
        public bool Find(string DepName)
        {
            return Departments.Any(e => e.DepartmentName == DepName.Trim());
        }

        public bool EmployeeAdd(int index, Employee NewEmployee)
        {
            if (index < Departments.Count && index > -1)
            {
                Departments[index].EmployeeAdd(NewEmployee);
                this.SaveDepartmentsData();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ExistingEmployeeAdd(int depIndex, int empIndex)
        {
            if (depIndex < Departments.Count && depIndex > -1)
            {
                if (empIndex < EmpStore.Employeers.Count && empIndex > -1)
                {
                    if (!Departments[depIndex].Employees.Any(e => e.ID == EmpStore.Employeers[empIndex].ID))
                    {
                        Departments[depIndex].EmployeeAdd(
                            EmpStore.Employeers.Find(e => e.ID == EmpStore.Employeers[empIndex].ID));
                        this.SaveDepartmentsData();
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        public bool EmployeeRemove(int depIndex, int empIndex)
        {
            if (depIndex < Departments.Count && depIndex > -1)
            {
                if (empIndex < EmpStore.Employeers.Count && empIndex > -1)
                {
                    if (EmpStore.Employeers.Any(e => e.ID == Departments[depIndex].Employees[empIndex].ID))
                        //Departments[depIndex].Employeers.Any(e => e.ID == EmpStore.Employeers[empIndex].ID)
                    {
                        Departments[depIndex].EmployeeRemuve(
                            (EmpStore.Employeers.Find(e => e.ID == Departments[depIndex].Employees[empIndex].ID)).ID);
                        this.SaveDepartmentsData();
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}