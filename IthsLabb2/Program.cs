using System;
using System.Collections.Generic;

namespace IthsLabb2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Första menyn när man startar applikationen
            DrawBoxMeny1();
            string mainMenyInput = Console.ReadLine();
            

            while (mainMenyInput != "0")
            {
                switch (mainMenyInput)
                {
                    //Registrera ny kund
                    case "1":
                        var newCustomers = new List<NewCustomer>();
                        Console.Clear();
                        Console.Write("Vänligen registrera ett användarnamn: ");
                        var usernameInput = Console.ReadLine();
                        newCustomers.Add(usernameInput);
                        //newCustomers.Add(Console.ReadLine());
                        Console.Clear();
                        Console.Write("Välj nu ditt lösenord: ");
                        string passwordInput = Console.ReadLine();
                        Console.WriteLine("Din profil är nu skapad!");
                        break;
                    //Logga in kund    
                    case "2":
                        Console.Clear();
                        ExistingCustomer exsitingCustomar = new ExistingCustomer();
                        Console.Write("Vänligen skriv in ditt användarnamn: ");
                        string usernameInput2 = Console.ReadLine();
                        exsitingCustomar.Username = usernameInput2;
                        Console.Clear();

                        Console.Write("Skriv in ditt lösenord: ");
                        string passwordInput2 = Console.ReadLine();
                        exsitingCustomar.Password = passwordInput2;

                        break;
                    //Avsluta programmet
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Vänligen välj ett av de ovanstående alternativen");
                        mainMenyInput = Console.ReadLine();
                        break;
                }
            }
            Console.WriteLine("Hejdå!");
            



            Console.ReadKey();

        }

        private static void RegisterCustomer()
        {
            Console.Write("Vänligen registrera ett användarnamn: ");
            string usernameInput = Console.ReadLine();
            Console.Clear();
            Console.Write("Välj nu ditt lösenord: ");
            string passwordInput = Console.ReadLine();
        }

        /// <summary>
        /// Gjorde en Drawbox istället för att skriva ut varje enskild rad, tyckte det blev lite snyggare.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public static void DrawBoxMeny1(int width = 30, int height = 3)
        {

            Console.WriteLine("Hejsan och välkommen till butiken! Vänligen välj nedan vad du vill göra:");
            Console.WriteLine("");

            //Skapar raden
            string line = new('#', width);

            //Skapar inre raderna
            string innerLine = "Tryck 1 för att Registrera dig";
            string innerLine1 = "Tryck 2 för att Logga in";
            string innerLine2 = "Tryck 0 för att Avsluta";

            //innerLine += "#";

            //Loopar igenom bredden
            for (int j = 0; j < width - 2; j++)
            {
                innerLine += "";
                innerLine1 += "";
                innerLine2 += "";

            }
            Console.WriteLine(line);

            //Loopar igenom höjden
            for (int i = 0; i < height - 2; i++)
            {
                Console.WriteLine(innerLine);
                Console.WriteLine(innerLine1);
                Console.WriteLine(innerLine2);

            }
            Console.WriteLine(line);
        }
    }
}
