using System;
using System.Collections.Generic;

namespace IthsLabb2
{
    class Customer
    {
        public string Username { get; private set; }
        private string Password { get; set; }

        private List<Products> _cart;
        public List<Products> cart { get { return _cart; } set { _cart = value; } }

        public List<Products> products = new() { new Products("Banan", 17), new Products("Äpple", 9), new Products("Päron", 26) };

        static List<Customer> exsistingCustomers = new() { new Customer("Knatte", "123"), new Customer("Fnatte", "321"), new Customer("Tjatte", "213") };

        public static Customer CurrentCustomer;

        public Customer(string username, string password)
        {
            Username = username;
            Password = password;
            cart = new List<Products>();
        }
        /// <summary>
        /// Använder mig av en tom konstruktor för att kunna återkalla i andra klasser utan några parametrar
        /// </summary>
        public Customer()
        {

        }

        /// <summary>
        /// Metod för att logga in befintlig användare
        /// </summary>
        public void LogIn()
        {
            Console.Clear();
            Console.Write("Hej! Vänligen skriv in ditt användarnamn: ");
            string username = Console.ReadLine();
            Console.Write("Skriv nu in ditt lösenord: ");
            string password = Console.ReadLine();
            bool found = false;

            //Loopar igenom de befintliga användarna i listan och jämför om det inmatade användarnamnet existerar eller ej
            for (int i = 0; i <= exsistingCustomers.Count; i++)
            {
                for (int j = 0; j < exsistingCustomers.Count; j++)
                {
                    Customer customer = exsistingCustomers[j];
                    //Om man skriver in en tom sträng
                    if (username.Trim() == String.Empty)
                    {
                        Console.WriteLine("Användarnamn kan inte vara tomt. Försök igen");
                        Console.Write("Användarnamn: ");
                        username = Console.ReadLine();
                        Console.Write("Lösenord: ");
                        password = Console.ReadLine();
                    }
                    //Om det inmatade användarnamnet är ett befintligt namn i listan
                    else if (customer.Username == username)
                    {
                        
                        //Om det inmatade lösenordet passar in till den befintliga användarens lösenord
                        if (password == customer.Password)
                        {
                            found = true;
                            CurrentCustomer = customer;
                            Console.WriteLine($"Välkommen {username}!");
                            Console.Write("Tryck på valfri tangent för att fortsätta till butiken:");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {
                            //Loopar igenom inmatning tills man skrivit rätt lösenord
                            while (password != customer.Password)
                            {
                                Console.Write("Tyvärr var det fel lösenord. Försök igen: ");
                                password = Console.ReadLine();
                            }
                            found = true;
                            CurrentCustomer = customer;
                            Console.WriteLine($"Välkommen {username}!");
                            Console.Write("Tryck på valfri tangent för att fortsätta till butiken:");
                            Console.ReadKey();
                            break;
                        }
                    }
                }
                if (username.Trim() == String.Empty)
                {
                    continue;
                }
                //För att bryta sig ur metoden om inmatande användarnamn och lösenord matchar befintlig användare
                else if (found == true)
                {
                    break;
                }
                //Om inmatande användarnamn inte existerar får man skapa ny profil
                else if (found != true)
                {
                    Console.Write("Det här användarnamnet finns inte registrerat. Tryck på valfri knapp för att registrera dig: ");
                    Console.ReadKey();
                    CustomerCreation();
                    break;
                }
            }
        }

        /// <summary>
        /// Metod för att registrera användare
        /// </summary>
        public void CustomerCreation()
        {
            Console.Clear();
            Console.Write("Vänligen skriv in ett användarnamn: ");
            string username = Console.ReadLine();
            Console.Write("Skriv nu in ett lösenord: ");
            string password = Console.ReadLine();
            bool loop = false;

            //Loopar igenom de befintliga användarna i listan och jämför om det inmatade användarnamnet existerar eller ej
            for (int i = 0; i >= 0; i++)
            {
                for (int j = 0; j < exsistingCustomers.Count; j++)
                {
                    Customer customers = exsistingCustomers[j];
                    //Om det inmatade namnet finns i listan, blir man ombedd att logga in istället
                    if (username.Trim() == customers.Username)
                    {
                        loop = true;
                        Console.Write("Det här användarnamnet finns redan. Tryck på valfri knapp för att logga in: ");
                        Console.ReadKey();
                        LogIn();
                        break;
                    }
                    //Om man anger att namn och lösenord är tomt
                    else if (username.Trim() == String.Empty && password.Trim() == String.Empty)
                    {
                        Console.WriteLine("Användarnamn och lösenord kan inte vara tomma tecken. Vänligen försök igen");
                        Console.Write("Användarnamn: ");
                        username = Console.ReadLine();
                        Console.Write("Lösenord: ");
                        password = Console.ReadLine();

                        //Om det inmatande namnet man skriver in redan är någon av de befintliga användarna
                        if (username.Trim() == customers.Username)
                        {
                            loop = true;
                            Console.Write("Det här användarnamnet finns redan. Tryck på valfri knapp för att logga in: ");
                            Console.ReadKey();
                            LogIn();
                        }
                    }
                }
                //För att bryta sig ur hela metoden om inmatande användarnamn och lösenord matchar befintlig användare
                if (loop == true)
                {
                    break;
                }
                //Om användarnamn fortfarande är tomt, itererar den om igen
                else if (username.Trim() == String.Empty)
                {
                    continue;
                }
                //Annars om de inmatade användarnamnet inte finns, skapas profilen
                else if (loop != true)
                {
                    var newCustomer = new Customer(username, password);
                    exsistingCustomers.Add(newCustomer);
                    CurrentCustomer = newCustomer;
                    Console.WriteLine($"Välkommen {username}! Din profil är nu skapad!");
                    Console.Write("Tryck på valfri tangent för att forsätta till butiken: ");
                    Console.ReadKey();
                    break;
                }
            }
        }

        /// <summary>
        /// Metod för att visa alla produkter i butiken
        /// </summary>
        public void Products()
        {
            Console.Clear();
            Console.WriteLine("Välkommen till våra varor! Välj nedan vad du vill köpa");
            Console.WriteLine("");

            Console.WriteLine("1. Banan 17kr");
            Console.WriteLine("2. Äpple 9kr");
            Console.WriteLine("3. Päron 26kr");
            Console.WriteLine("Tryck på 0 för att gå till kundvagnen");

            string input = Console.ReadLine();

            while (input != "0")
            {
                switch (input)
                {
                    case "1":
                        Banan();
                        EndStore();
                        input = Console.ReadLine();
                        break;
                    case "2":
                        Äpple();
                        EndStore();
                        input = Console.ReadLine();
                        break;
                    case "3":
                        Päron();
                        EndStore();
                        input = Console.ReadLine();
                        break;
                    case "4":
                        Console.Write("Vad vill du handla här näst?: ");
                        input = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Vänligen välj ett av de ovanstående alternativen");
                        input = Console.ReadLine();
                        break;
                }
            }
        }

        /// <summary>
        /// Metod för att lägga till banan i kundvagnen
        /// </summary>
        public void Banan()
        {
            Console.WriteLine("Du har lagt till 1st banan i kundvagnen");
            CurrentCustomer.cart.Add(new Products("Banan", products[0].Price));
        }

        /// <summary>
        /// Metod för att lägga till äpple i kundvagnen
        /// </summary>
        public void Äpple()
        {
            Console.WriteLine("Du har lagt till 1st äpple i kundvagnen");
            CurrentCustomer.cart.Add(new Products("Äpple", products[0].Price));
        }

        /// <summary>
        /// Metod för att lägga till päron i kundvagnen
        /// </summary>
        public void Päron()
        {
            Console.WriteLine($"Du har lagt till 1st päron i kundvagnen");
            CurrentCustomer.cart.Add(new Products("Päron", products[0].Price));
        }

        /// <summary>
        /// Metod för att visa vad som ligger i kundvagnen samt totala priser
        /// </summary>
        public void ShowCart()
        {
            Console.Clear();
            var apple = 0;
            var banana = 0;
            var pear = 0;

            //Loopar igenom kundvagnslistan samt lägger till 1st av respektive produkt
            foreach (var items in CurrentCustomer.cart)
            {
                if (items.Product == "Äpple")
                {
                    apple++;
                }
                else if (items.Product == "Banan")
                {
                    banana++;
                }
                else
                {
                    pear++;
                }
            }

            var sumBanana = products[0].Price * banana;
            var sumApple = products[1].Price * apple;
            var sumPear = products[2].Price * pear;
            double totalSum = sumBanana + sumApple + sumPear;

            //Om kundvagnen är tom
            if (totalSum == 0)
            {
                Console.WriteLine("Din kundvagn är tom! Vänligen handla valfria produkter om du vill se din kundvagn!");
                Console.WriteLine("");
            }
            //Om kundvagnen inte är tom
            else
            {
                Console.WriteLine("Här är din kundvagn!");
                Console.WriteLine("");
                Console.WriteLine($"Du har {banana}st bananer i kundvagnen á 17kr/st. Totalt: {sumBanana}kr");
                Console.WriteLine($"Du har {apple}st äpplen i kundvagnen á 9kr/st. Totalt: {sumApple}kr");
                Console.WriteLine($"Du har {pear}st päron i kundvagnen á 26kr/st. Totalt: {sumPear}kr");
                Console.WriteLine("");
                Console.WriteLine($"Totalt är din kundvagn {totalSum}kr.");
                Console.WriteLine("");
                Console.WriteLine("Vill du Betala och lämna butiken, Handla mer eller Logga ut?");
                Console.WriteLine("");
            }
        }

        /// <summary>
        /// Metod för att fråga användaren om den vill handla en till produkt eller gå till kundvagnen
        /// </summary>
        public void EndStore()
        {
            Console.WriteLine("Vill du handla mer eller gå tillbaka?");
            Console.WriteLine("4. För att Handla mer");
            Console.WriteLine("0. För att gå till kundvagnen");
        }
        
        /// <summary>
        /// Tömmer kundvagnen om det finns produkter i den
        /// </summary>
        public void ClearCart()
        {
            if (CurrentCustomer.cart.Count != 0)
            {
                CurrentCustomer.cart.Clear();
            }
        }

        public override string ToString()
        {
            return Username.ToString() + Password.ToString() + CurrentCustomer.cart.ToString();
        }
    }
}
