using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class User
    {
        public User() { }

        public User(string name)
        {
            Username = name;
        }

        public User(string name, string password)
        {
            Username = name;
            Password = password;
        }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Status { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public DateTime? LastLogin { get; set; }
    }
}
