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
            ExistingUser();
        }

        public void ExistingUser()
        {
            while (Username == "Knatte" || Username == "Fnatte" || Username == "Tjatte")
            {
                Console.Write("Det här användarnamnet finns redan, vänligen skriv in ett nytt: ");
                Username = Console.ReadLine();
                Console.Write("Skriv nu in ditt lösenord: ");
                Password = Console.ReadLine();

                if (Username == "Knatte" || Username == "Fnatte" || Username == "Tjatte")
                {
                    Console.Write("Det här användarnamnet finns redan, vänligen skriv in ett nytt: ");
                    Username = Console.ReadLine();
                    Console.Write("Skriv nu in ditt lösenord: ");
                    Password = Console.ReadLine();
                }
                else if (Username == "Knatte" || Username == "Fnatte" || Username == "Tjatte")
                {
                    Console.Write("Det här användarnamnet finns redan, vänligen skriv in ett nytt: ");
                    Username = Console.ReadLine();
                    Console.Write("Skriv nu in ditt lösenord: ");
                    Password = Console.ReadLine();
                }
                else if (Username == "Knatte" || Username == "Fnatte" || Username == "Tjatte")
                {
                    Console.Write("Det här användarnamnet finns redan, vänligen skriv in ett nytt: ");
                    Username = Console.ReadLine();
                    Console.Write("Skriv nu in ditt lösenord: ");
                    Password = Console.ReadLine();
                } 
                else
                {

                }
            }
            
        }
        
        public void WelcomeMessage()
        {
            Console.WriteLine($"Välkommen {Username}!");
            Console.Write("Din profil är nu skapad och du kommer nu att forsätta till butiken! Tryck på valfri knapp för att fortsätta:");
            Console.ReadKey();
        }   

    }
}
