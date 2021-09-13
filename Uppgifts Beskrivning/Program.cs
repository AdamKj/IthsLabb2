using System;

namespace Uppgifts_Beskrivning
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Skapa en konsollaplikation som skall agera som en enkel affär. 
                När programmet körs så ska man få se någon form av meny där man ska kunna välja att registrera ny kund eller logga in. 
                Därefter ska ytterligare en meny visas där man ska kunna välja att handla, se kundvagn eller gå till kassan.

               Om man väljer att handla ska man få upp minst 3 olika produkter att köpa (t.ex. Korv, Dricka och Äpple). 
                Man ska se pris för varje produkt och kunna lägga till vara i kundvagn.

               Kundvagnen ska visa alla produkter man lagt i den, styckpriset, antalet och totalpriset samt totala kostnaden för hela kundvagnen. 
                Kundvagnen skall sparas i kund och finnas tillgänglig när man loggar in.

               När man ska Registrera en ny kund ska man ange Namn och lösenord. Dessa ska sparas och namnet ska inte gå att ändra.

               Väljer man Logga In så ska man skriva in namn och lösenord. 
                Om användaren inte finns registrerad ska programmet skriva ut att kunden inte finns och fråga ifall man vill registrera ny kund. 
                Om lösenordet inte stämmer så ska programmet skriva ut att lösenordet är fel och låta användaren försöka igen.

               Både kund och produkt ska vara separata klasser med Properties för information och metoder för att räkna ut totalpris och verifiera lösenord.

               I klassen Kund skall det finnas en ToString() som skriver ut Namn, lösenord och kundvagnen på ett snyggt sätt. */
        }
    }
}
