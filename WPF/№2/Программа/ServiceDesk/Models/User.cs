using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class User
    {
        public int UserId { get; private set; }
        [MaxLength (20)]
        public string Password { get; set; }
        [MaxLength(15)]
        public string Name { get; set; }
        public Role UserRole { get; set; }
        /*
        public User(int id)
        {
            UserId = id;
        }
        */
        public override string ToString()
        {
            return string.Format("ID:{0} Name:{1} Password:{2} Role:{3}", UserId, Name, Password, UserRole);
        }
    }
}
