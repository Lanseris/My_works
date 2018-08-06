using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WorkersDataAPI.Controllers
{
    public class DepVsEmplLinkController : ApiController
    {
        public List<int> EmployeesId { get; set; }

        public IEnumerable<int> GetDepVsEmplLink(int id)
        {
               EmployeesId = new List<int>();
                string ConnectionString =
                @"Data Source=VASILIY-PC\SQLEXPRESS;
                    Initial Catalog=CompanyDataBase;
                    Integrated Security=true";
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();
                        var sql = $@"SELECT EmplID FROM dbo.[DepVsEmplLink] WHERE DepID = {id};";

                        SqlCommand command = new SqlCommand(sql, connection);
                        SqlDataReader readerL = command.ExecuteReader();
                        while (readerL.Read())
                        {
                            ReadLinkRow((IDataRecord)readerL);
                        }
                        readerL.Close();
                    }
                }
                catch (Exception e)
                {
                    //Console.WriteLine(e.Message);
                    return EmployeesId;
                }
                finally
                {
                    //Console.WriteLine("Exit");
                }
                return EmployeesId;
            
        }

        public void ReadLinkRow(IDataRecord record)
        {
            EmployeesId.Add(Convert.ToInt32(record[0]));
        }
    }
}
