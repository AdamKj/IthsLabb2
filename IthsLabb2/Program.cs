using System;
using System.Collections.Generic;

namespace IthsLabb2
{
    class Program
    {

        static void Main(string[] args)
        {
            //Första menyn när man startar applikationen
            DrawBoxes meny = new DrawBoxes();
            meny.DrawBoxMeny1();
            string mainMenyInput = Console.ReadLine();
            string username = "";
            string password = "";

            switch (mainMenyInput)
            {
                //Registrera ny kund
                case "1":
                    NewCustomer newCustomer = new NewCustomer(username, password);
                    Console.Clear();
                    newCustomer.CustomerCreation();
                    newCustomer.WelcomeMessage();
                    break;
                //Logga in kund    
                case "2":
                    ExistingCustomer exsitingCustomer = new ExistingCustomer();
                    var exsistingCustomers = new List<ExistingCustomer>();
                    Console.Clear();
                    Console.Write("Vänligen skriv in ditt användarnamn: ");
                    string usernameInput2 = Console.ReadLine();
                    exsitingCustomer.Username = usernameInput2;
                    Console.Clear();

                    Console.Write("Skriv in ditt lösenord: ");
                    string passwordInput2 = Console.ReadLine();
                    exsitingCustomer.Password = passwordInput2;
                    break;
                //Avsluta programmet
                case "0":
                    break;
                default:
                    Console.WriteLine("Vänligen välj ett av de ovanstående alternativen");
                    mainMenyInput = Console.ReadLine();
                    break;
            }

            meny.StoreDrawBox();




            Console.ReadKey();

        }
    }
}
