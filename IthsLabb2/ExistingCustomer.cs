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

        public void LogIn()
        {
            Console.Clear();
            Console.Write("Hej! Vänligen skriv in ditt användarnamn: ");
            Username = Console.ReadLine();
            Console.Write("Skriv nu in ditt lösenord: ");
            Password = Console.ReadLine();
            ToString();
        }

        public override string ToString()
        {
            if (Username == "Knatte" && Password == "123")
            {
                Console.WriteLine($"Välkommen {Username}!");
                Console.Write("Tryck på valfri tangent för att forsätta till butiken:");
                Console.ReadKey();
            }
            else if (Username == "Fnatte" && Password == "321")
            {
                Console.WriteLine($"Välkommen {Username}!");
                Console.Write("Tryck på valfri tangent för att forsätta till butiken:");
                Console.ReadKey();
            }
            else if (Username == "Tjatte" && Password == "213")
            {
                Console.WriteLine($"Välkommen {Username}!");
                Console.Write("Tryck på valfri tangent för att forsätta till butiken:");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Tyvärr finns inte {Username} registrerat. Vänligen registrera dig först.");
                NewCustomer newCustomer = new NewCustomer(Username, Password);
                newCustomer.CustomerCreation();
            }
            return "";
        }
    }
}
