using System;
using System.Collections.Generic;

namespace IthsLabb2
{
    class Program
    {

        static void Main(string[] args)
        {
            DrawBoxes meny = new();
            Cart cart = new();
            Customer customer = new();

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
                        while (input != "1" || input != "2" || input != "9")
                        {
                            switch (input)
                            {
                                case "1":
                                    customer.Products();
                                    customer.ShowCart();
                                    cart.CartAction();
                                    break;
                                case "2":
                                    customer.ShowCart();
                                    cart.CartAction();
                                    break;
                                case "9":
                                    meny.DrawBoxMeny1();
                                    input = Console.ReadLine();
                                    break;
                                default:
                                    DefaultMessage();
                                    input = Console.ReadLine();
                                    break;
                            }
                        }
                        break;
                        
                    //Logga in kund    
                    case "2":
                        customer.LogIn();
                        meny.StoreDrawBox();
                        input = Console.ReadLine();
                        while (input != "1" || input != "2" || input != "9")
                        {
                            switch (input)
                            {
                                case "1":
                                    customer.Products();
                                    customer.ShowCart();
                                    cart.CartAction();
                                    break;
                                case "2":
                                    customer.ShowCart();
                                    cart.CartAction();
                                    break;
                                case "9":
                                    meny.DrawBoxMeny1();
                                    input = Console.ReadLine();
                                    break;
                                default:
                                    DefaultMessage();
                                    input = Console.ReadLine();
                                    break;
                            }
                        }
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
