using System;

namespace IthsLabb2
{
    class Cart
    {
        /// <summary>
        /// Metod för att välja vad man vill göra härnäst när man är i kundvagnen
        /// </summary>
        public void CartAction()
        {
            Console.WriteLine("Tryck 1 för att Betala och lämna butiken");
            Console.WriteLine("Tryck 2 för att Handla mer");
            Console.WriteLine("Tryck 3 för att Logga ut");

            string input = Console.ReadLine();
            Customer customer = new();
            DrawBoxes meny = new DrawBoxes();
            
            //Ber om ursäkt för denna röran
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
                        customer.ClearCart();
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
                                            Console.Write("Vänligen välj ett av de ovanstående alternativen: ");
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
                                            Console.Write("Vänligen välj ett av de ovanstående alternativen: ");
                                            input = Console.ReadLine();
                                        }
                                        break;
                                }
                                break;
                        }
                        break;
                    default:
                        if (input == "exit")
                        {
                            //Avsluta programmet
                            Console.Clear();
                            Console.WriteLine("Hejdå!");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.Write("Vänligen välj en av de ovanstående alternativen: ");
                            input = Console.ReadLine();
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// Metod för att betala sina varor och stänga ner programmet
        /// </summary>
        public static void CheckOut()
        {
            Console.Clear();
            Console.Write("Tack för besöket! Tryck på valfri knapp för att lämna butiken: ");
            Console.ReadKey();
            Environment.Exit(0);
        }

    }
}
