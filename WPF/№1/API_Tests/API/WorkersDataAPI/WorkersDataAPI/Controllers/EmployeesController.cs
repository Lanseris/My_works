using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WorkersDataAPI.Models;

namespace WorkersDataAPI.Controllers
{
    public class EmployeesController : ApiController
    {
        List<Employee> employees;

        public int mID { get; private set; }
        public string mFerstName { get; private set; }
        public string mSecondName { get; private set; }
        public int mAge { get; set; }
        public string mMail { get; private set; }
        public string mPhone { get; private set; }

        public IEnumerable<Employee> GetAllEmployees()
        {
            if (employees!=null)
            {
                return employees;
            }
            else
            {
                employees = new List<Employee>();
                string ConnectionString =
                @"Data Source=VASILIY-PC\SQLEXPRESS;
                    Initial Catalog=CompanyDataBase;
                    Integrated Security=true";
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();
                        var sql = @"SELECT id, FerstName, SecondName, Age, Mail,Phone FROM [dbo].[Employeers];";

                        SqlCommand command = new SqlCommand(sql, connection);
                        SqlDataReader readerE = command.ExecuteReader();
                        while (readerE.Read())
                        {
                            ReadEmployeeRow((IDataRecord)readerE);
                        }
                        readerE.Close();
                    }
                }
                catch (Exception e)
                {
                    //Console.WriteLine(e.Message);
                    return employees;
                }
                finally
                {
                    //Console.WriteLine("Exit");
                }
                return employees;
            }
        }


        public void ReadEmployeeRow(IDataRecord record)
        {
            mID = Convert.ToInt32(record[0]);
            mFerstName = String.Format("{0}", record[1]);
            mSecondName = String.Format("{0}", record[2]);
            mAge = Convert.ToInt32(record[3]);
            mMail = String.Format("{0}", record[4]);
            mPhone = String.Format("{0}", record[5]);
            employees.Add(new Employee(mID) { FerstName=mFerstName,SecondName= mSecondName,Age= mAge,Mail= mMail,PhoneNumber= mPhone});
        }

        public IHttpActionResult GetEmployee(int id)
        {
            var employee = employees.FirstOrDefault(p => p.ID == id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }
    }
}
