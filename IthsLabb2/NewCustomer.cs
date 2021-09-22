using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IthsLabb2
{
    class NewCustomer
    {
        public string Username { get; set; }
        public string Password { get; private set; }

        private List<Products> _cart;
        public List<Products> cart { get { return _cart; } set { _cart = value; } }

        public NewCustomer(string username, string password)
        {
            Username = username;
            Password = password;
            _cart = new List<Products>();
        }

        public void CustomerCreation()
        {
            Console.Write("Vänligen skriv in ett användarnamn: ");
            Username = Console.ReadLine();
            Console.Write("Skriv nu in ett lösenord: ");
            Password = Console.ReadLine();
            ExistingUser();
        }

        public void ExistingUser()
        {
            while (Username == "Knatte" || Username == "Fnatte" || Username == "Tjatte")
            {
                if (Username == "Knatte" && Password == "123")
                {
                    break;
                }
                else if (Username == "Fnatte" && Password == "321")
                {
                    break;
                }
                else if (Username == "Tjatte" && Password == "213")
                {
                    break;
                }

                Console.Write("Det här användarnamnet finns redan, vänligen skriv in ett nytt: ");
                Username = Console.ReadLine();
                Console.Write("Skriv nu in ditt lösenord: ");
                Password = Console.ReadLine();
            }
            WelcomeMessage();
        }

        public void WelcomeMessage()
        {
            Console.WriteLine($"Välkommen {Username}!");
            Console.Write("Tryck på valfri tangent för att fortsätta till butiken: ");
            Console.ReadKey();
        }
    }
}
