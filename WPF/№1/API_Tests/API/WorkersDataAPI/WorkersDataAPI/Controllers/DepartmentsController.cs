using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using System.Web.Http.Results;
using WorkersDataAPI.Models;

namespace WorkersDataAPI.Controllers
{
    public class DepartmentsController : ApiController
    {
        public List<Department> Departments { get; set; }
        public int DId { get; private set; }
        public string DName { get; private set; }

        public IEnumerable<Department> GetReadDepartmentsData()
        {
            if (Departments!=null)
            {
                return Departments;
            }
            else
            {
                Departments = new List<Department>();
                string ConnectionString =
                @"Data Source=VASILIY-PC\SQLEXPRESS;
                    Initial Catalog=CompanyDataBase;
                    Integrated Security=true";
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();
                        var sql = @"SELECT Id, Name FROM [dbo].[Departments];";

                        SqlCommand command = new SqlCommand(sql, connection);
                        SqlDataReader readerD = command.ExecuteReader();
                        while (readerD.Read())
                        {
                            ReadDepartmentRow((IDataRecord)readerD);
                        }
                        readerD.Close();


                        var LinkController = new DepVsEmplLinkController();
                        var EmplController = new EmployeesController();
                        EmplController.GetAllEmployees();

                        foreach (var department in Departments)
                        {
                            var Empls = LinkController.GetDepVsEmplLink(department.Id);
                            department.Employees = new List<Employee>();

                            foreach (int emplId in Empls)
                            {
                                department.Employees.Add((EmplController.GetEmployee(emplId) as OkNegotiatedContentResult<Employee>).Content);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    //Console.WriteLine(e.Message);
                    return Departments;
                }
                finally
                {
                    //Console.WriteLine("Exit");
                }
                return Departments;
            }
        }

        /// <summary>
        /// Метод, обрабатывающий строку из таблицы Departments
        /// </summary>
        /// <param name="record"></param>
        public void ReadDepartmentRow(IDataRecord record)
        {
            DId = Convert.ToInt32(record[0]);
            DName = String.Format("{0}", record[1]);
            Departments.Add(new Department(DId) { DepartmentName=DName, Employees = new List<Employee>() });
        }

    }
}
