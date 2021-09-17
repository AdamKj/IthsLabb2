using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IthsLabb2
{
    class ExistingCustomer
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public void Knatte(string username = "Knatte", string password = "123")
        {
            Username = username;
            Password = password;
        }
        public void Fnatte(string username = "Fnatte", string password = "321")
        {
            Username = username;
            Password = password;
        }
        public void Tjatte(string username = "Tjatte", string password = "213")
        {
            Username = username;
            Password = password;
        }

        public override string ToString()
        {
            return $"Välkommen {Username}!";
        }
    }
}
