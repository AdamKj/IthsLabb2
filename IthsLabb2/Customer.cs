using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IthsLabb2
{
    class Customer
    {
        public string Username { get; set; }
        public string Password { get; private set; }

        private List<Products> _cart;
        public List<Products> cart { get { return _cart; } set { _cart = value; } }

        public static List<string> existingCustomer = new() { "Knatte", "123", "Fnatte", "321", "Tjatte", "213" };

        public Customer(string username, string password)
        {
            Username = username;
            Password = password;
            _cart = new List<Products>();
        }

        public void LogIn()
        {
            Console.Clear();
            Console.Write("Hej! Vänligen skriv in ditt användarnamn: ");
            Username = Console.ReadLine();
            Console.Write("Skriv nu in ditt lösenord: ");
            Password = Console.ReadLine();

            foreach (var customer in existingCustomer)
            {
                if (existingCustomer.Contains(Username))
                {
                    //if (existingCustomer.Password == Password)
                    //{
                    //    Console.WriteLine($"Välkommen {Username}!");
                    //    break;
                    //}
                    //else if (customer.Password != Password)
                    //{
                    //    while (customer.Password != Password)
                    //    {
                    //        Console.WriteLine("Tyvärr var det fel lösenord, försök igen: ");
                    //        Password = Console.ReadLine();
                    //    }
                    //    break;
                    //}
                }
                else if (customer.Username != Username)
                {
                    Console.Write($"Tyvärr finns inte {Username} registrerat. Vänligen tryck på valfri knapp för att registrera dig: ");
                    Console.ReadKey();
                    CustomerCreation();
                }
            }
            Console.Write($"Välkommen {Username}! Tryck på valfri knapp för att forsätta till butiken: ");
            Console.ReadKey();
        }

        public void CustomerCreation()
        {
            Console.Clear();
            Console.Write("Vänligen skriv in ett användarnamn: ");
            Username = Console.ReadLine();
            Console.Write("Skriv nu in ett lösenord: ");
            Password = Console.ReadLine();
            WelcomeMessageToCreation();
        }

        public void WelcomeMessageToCreation()
        {
            Console.WriteLine($"Välkommen {Username}! Din profil är nu skapad!");
            Console.Write("Tryck på valfri tangent för att forsätta till butiken: ");
            Console.ReadKey();
        }
    }
}
