using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

namespace Models
{
    public class UserStore
    {
        public List<User> Users { get; private set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int ID { get; set; }
        public int RoleID { get; set; }
      
        public UserStore()
        {
            Users = new List<User>();
            Users.AddRange(ReadUsersData());
        }
        
        public List<User> ReadUsersData()
        {
            var context = new DbServiceDeskModel();

            IQueryable<User> query = context.Users;

            return query.ToList();
        }
    }
}
