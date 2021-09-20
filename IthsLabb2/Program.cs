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
            string input = Console.ReadLine();
            string username = "";
            string password = "";

            while (input != "0")
            {
                switch (input)
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
                        exsitingCustomer.LogIn();
                        exsitingCustomer.ToString();
                        Console.Clear();

                        break;
                    //Avsluta programmet
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Vänligen välj ett av de ovanstående alternativen");
                        input = Console.ReadLine();
                        break;
                }
            }
            

            Store store = new Store();
            meny.StoreDrawBox();
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    store.Products();
                    break;
                case "2":

                    break;
                case "3":

                    break;
            }




            Console.ReadKey();

        }
    }
}
