using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IthsLabb2
{
    class Cart
    {
        public void CartAction()
        {
            Console.WriteLine("Tryck 1 för att Betala och lämna butiken");
            Console.WriteLine("Tryck 2 för att Handla mer");
            Console.WriteLine("Tryck 3 för att Logga ut");

            string input = Console.ReadLine();
            string s = "";
            string n = "";
            Customer customer = new Customer(s,n);
            DrawBoxes meny = new DrawBoxes();

            while (input != "1" || input != "2" || input != "3")
            {
                switch (input)
                {
                    case "1":
                        CheckOut();
                        break;
                    case "2":
                        customer.Products();
                        customer.ShowCart();
                        CartAction();
                        break;
                    case "3":
                        meny.DrawBoxMeny1();
                        input = Console.ReadLine();
                        switch (input)
                        {
                            case "1":
                                customer.CustomerCreation();
                                meny.StoreDrawBox();
                                input = Console.ReadLine();
                                switch (input)
                                {
                                    case "1":
                                        customer.Products();
                                        customer.ShowCart();
                                        CartAction();
                                        break;
                                    case "2":
                                        customer.ShowCart();
                                        CartAction();
                                        break;
                                    case "9":
                                        Console.Clear();
                                        meny.DrawBoxMeny1();
                                        input = Console.ReadLine();
                                        break;
                                    default:
                                        while (input != "1" || input != "2" || input != "9")
                                        {
                                            Console.WriteLine("Vänligen välj ett av de ovanstående alternativen");
                                            input = Console.ReadLine();
                                        }
                                        break;
                                }
                                break;
                            case "2":
                                customer.LogIn();
                                meny.StoreDrawBox();
                                input = Console.ReadLine();
                                switch (input)
                                {
                                    case "1":
                                        customer.Products();
                                        customer.ShowCart();
                                        CartAction();
                                        break;
                                    case "2":
                                        customer.ShowCart();
                                        CartAction();
                                        break;
                                    case "9":
                                        Console.Clear();
                                        meny.DrawBoxMeny1();
                                        input = Console.ReadLine();
                                        break;
                                    default:
                                        while (input != "1" || input != "2" || input != "9")
                                        {
                                            Console.WriteLine("Vänligen välj ett av de ovanstående alternativen");
                                            input = Console.ReadLine();
                                        }
                                        break;
                                }
                                break;
                        }

                        break;
                    default:
                        Console.WriteLine("Vänligen välj en av de ovanstående alternativen");
                        input = Console.ReadLine();
                        break;
                }
            }
            
        }

        public void CheckOut()
        {
            Console.Clear();
            Console.Write("Tack för besöket! Tryck på valfri knapp för att lämna butiken: ");
            Console.ReadKey();
            Environment.Exit(0);
        }

    }
}
