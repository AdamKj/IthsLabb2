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
        public string Password { get; set; }

        public NewCustomer(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public void CustomerCreation()
        {
            Console.Write("Vänligen skriv in ett användarnamn: ");
            Username = Console.ReadLine();
            Console.Write("Skriv nu in ett lösenord: ");
            Password = Console.ReadLine();
        }
        
        public void WelcomeMessage()
        {
            Console.WriteLine($"Välkommen {Username}!");
            Console.WriteLine("Din profil är nu skapad! Du kommer nu att forsätta till butiken! Tryck på valfri knapp: ");
            Console.ReadKey();
        }   

    }
}
