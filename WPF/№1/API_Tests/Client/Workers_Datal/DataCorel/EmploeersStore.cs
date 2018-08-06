using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DataCorel
{
    public class EmploeersStore
    {
        public List<Employee> Employeers { get; set; }

        private Hashtable IdVsEmployeers { get; set; }

        #region SecondWay
        // const string Str = "EmploeersData.txt";
        #endregion

        #region TherdEay
        public HttpClient client = new HttpClient();
        #endregion

        const string StrConnection = @"
Data Source=(localDB)\MSSQLLocalDB;
Initial Catalog = coppanyData;
Integrated Security=True;";
      
        public int mID { get; set; }
        public string mFerstName { get; set; }
        public string mSecondName { get; set; }
        public int mAge { get; set; }
        public string mMail { get; set; }
        public string mPhone { get; set; }


        public EmploeersStore()
        {
            Employeers = new List<Employee>();
            //CreateEmployeersData();
            ReadEmployeersData(StrConnection);
        }

        /// <summary>
        /// Метод, считывающий список работников из соответствующей таблицы
        /// </summary>
        /// <param name="connectionString"></param>
        public void ReadEmployeersData(string connectionString)
        {
            #region TherdWay

            client.BaseAddress = new Uri("http://localhost:49427/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new
            MediaTypeWithQualityHeaderValue("application/json"));

            var Empl =  client.GetAsync(client.BaseAddress + "api/Employees").Result;
            Employeers = Empl.Content.ReadAsAsync<IEnumerable<Employee>>().Result.ToList();

            IdVsEmployeers = new Hashtable();

            foreach (var Employeer in Employeers)
            {
                IdVsEmployeers.Add(Employeer.ID, Employeer);
            }

            #endregion

            #region SecondWay
            //try
            //{
            //    using (SqlConnection connection = new SqlConnection(StrConnection))
            //    {
            //        connection.Open();
            //        var sql = @"SELECT id, FerstName, SecondName, Age, Mail,Phone FROM [dbo].[Employeers];";

            //        SqlCommand command = new SqlCommand(sql, connection);
            //        SqlDataReader readerE = command.ExecuteReader();
            //        while (readerE.Read())
            //        {
            //            ReadEmployeeRow((IDataRecord)readerE);
            //        }
            //        readerE.Close();
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

            #region FerstWay
            //using (StreamReader sr = new StreamReader(connectionString, encoding:Encoding.UTF8))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        string fname = sr.ReadLine();
            //        string sname = sr.ReadLine();
            //        int  age = Int32.Parse(sr.ReadLine());
            //        string mail = sr.ReadLine();
            //        string phone = sr.ReadLine();
            //        int id = Int32.Parse(sr.ReadLine());
            //        sr.ReadLine();
            //        this.Employeers.Add(new Employee(fname,sname,age,mail,phone,id));
            //    }
            //}
            #endregion
        }

        /// <summary>
        /// метод, обрабатывающий строку из таблицы
        /// </summary>
        /// <param name="record"></param>
        public void ReadEmployeeRow(IDataRecord record)
        {
            mID = Convert.ToInt32(record[0]);
            mFerstName = String.Format("{0}", record[1]);
            mSecondName = String.Format("{0}", record[2]);
            mAge = Convert.ToInt32(record[3]);
            mMail = String.Format("{0}", record[4]);
            mPhone = String.Format("{0}", record[5]);
            Employeers.Add(new Employee(mFerstName,mSecondName,mAge,mMail,mPhone, mID));
        }

        /// <summary>
        /// Метод, создающий 10 записей в таблице работников
        /// </summary>
        public void CreateEmployeersData()
        {
            try
            {
                var random = new Random();
                for (int i = 0; i < 10; i++)
                {
                    var Employee = new Employee
                        (
                        $"Name_{random.Next(0, 100)}",
                        $"SName_{random.Next(0, 100)}",
                        random.Next(20, 60),
                        $"email__{random.Next(0, 100)}_domen@mail.ru",
                        $"8(80{random.Next(0, 10)})555-35-3{random.Next(0, 10)}"
                        );
                    var sql = $@"INSERT INTO Employeers (FerstName,SecondName,Age,Mail,Phone)
                                VALUES (N'{Employee.FerstName}','{Employee.SecondName}','{Employee.Age}','{Employee.Mail}','{Employee.PhoneNumber}')";


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

        /// <summary>
        /// не актуален
        /// </summary>
        public void SaveEmployeersData()
        {

            //using (StreamWriter sw = new StreamWriter(Str))
            //{
            //    foreach (Employee employeer in Employeers)
            //    {
            //        sw.WriteLine(employeer.FerstName);
            //        sw.WriteLine(employeer.SecondName);
            //        sw.WriteLine(employeer.Age);
            //        sw.WriteLine(employeer.Mail);
            //        sw.WriteLine(employeer.PhoneNumber);
            //        sw.WriteLine(employeer.ID);
            //        sw.WriteLine();

            //    }
            //}
        }
    }
}
