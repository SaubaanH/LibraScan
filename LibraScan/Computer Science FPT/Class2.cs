using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Science_FPT
{
    using System;
    using System.Collections.Generic;

    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public User()
        {
            // Default constructor
        }

        public User(string username, string password)
        {
            UserName = username;
            Password = password;
        }

    }

}
