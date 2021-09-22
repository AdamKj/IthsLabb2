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

            while (input != "exit")
            {
                switch (input)
                {
                    //Registrera ny kund
                    case "1":
                        NewCustomer newCustomer = new NewCustomer(username, password);
                        Console.Clear();
                        newCustomer.CustomerCreation();
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
                        ExistingCustomer exsitingCustomer = new ExistingCustomer();
                        exsitingCustomer.LogIn();
                        //exsitingCustomer.ToString();
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
