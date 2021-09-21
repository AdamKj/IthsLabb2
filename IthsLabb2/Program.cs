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
            Store store = new Store();
            Cart cart = new Cart();
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
                        meny.StoreDrawBox();
                        input = Console.ReadLine();
                        switch (input)
                        {
                            case "1":
                                store.Products();
                                input = Console.ReadLine();
                                break;
                            case "2":
                                cart.ShowCart();
                                break;
                            case "0":
                                meny.DrawBoxMeny1();
                                break;
                        }
                        break;
                    //Logga in kund    
                    case "2":
                        ExistingCustomer exsitingCustomer = new ExistingCustomer();
                        exsitingCustomer.LogIn();
                        exsitingCustomer.ToString();
                        meny.StoreDrawBox();
                        input = Console.ReadLine();
                        switch (input)
                        {
                            case "1":
                                store.Products();
                                input = Console.ReadLine();
                                break;
                            case "2":
                                cart.ShowCart();
                                break;
                            case "0":
                                meny.DrawBoxMeny1();
                                break;
                        }
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
            Console.WriteLine("Hejdå!");
            



            Console.ReadKey();

        }
    }
}
