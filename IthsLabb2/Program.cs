﻿using System;
using System.Collections.Generic;

namespace IthsLabb2
{
    class Program
    {

        static void Main(string[] args)
        {
            var customerKnatte = new Customer("Knatte", "123");
            var customerFnatte = new Customer("Fnatte", "321");
            var customerTjatte = new Customer("Tjatte", "231");
            CheckCustomer addCustomer = new();
            addCustomer.exsistingCustomer.Add(customerKnatte);
            addCustomer.exsistingCustomer.Add(customerFnatte);
            addCustomer.exsistingCustomer.Add(customerTjatte);
            DrawBoxes meny = new();
            Store store = new();
            Cart cart = new();
            string username = "";
            string password = "";
            Customer customer = new(username, password);

            //Första menyn när man startar applikationen
            meny.DrawBoxMeny1();
            string input = Console.ReadLine();

            while (input != "exit")
            {
                switch (input)
                {
                    //Registrera ny kund
                    case "1":
                        customer.CustomerCreation();
                        meny.StoreDrawBox();
                        input = Console.ReadLine();
                        switch (input)
                        {
                            case "1":
                                store.Products();
                                cart.ShowCart();
                                break;
                            case "2":
                                cart.ShowCart();
                                break;
                            case "9":
                                Console.Clear();
                                meny.DrawBoxMeny1();
                                input = Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("Vänligen välj ett av de ovanstående alternativen");
                                input = Console.ReadLine();
                                break;
                        }
                        break;

                    //Logga in kund    
                    case "2":
                        Customer exsistingCustomer = new(username, password);
                        exsistingCustomer.LogIn();
                        meny.StoreDrawBox();
                        input = Console.ReadLine();
                        switch (input)
                        {
                            case "1":
                                store.Products();
                                cart.ShowCart();
                                break;
                            case "2":
                                cart.ShowCart();
                                break;
                            case "9":
                                Console.Clear();
                                meny.DrawBoxMeny1();
                                input = Console.ReadLine();
                                break;
                            default:
                                DefaultMessage();
                                input = Console.ReadLine();
                                break;
                        }
                        Console.Clear();
                        break;
                    case "9":
                        input = Console.ReadLine();
                        break;
                    default:
                        DefaultMessage();
                        input = Console.ReadLine();
                        break;
                }
            }
            //Avsluta programmet
            Console.Clear();
            Console.WriteLine("Hejdå!");
            



            Console.ReadKey();

        }

        public static void DefaultMessage()
        {
            Console.Write("Vänligen välj något av de ovanstående alternativen: ");
        }
    }
}
