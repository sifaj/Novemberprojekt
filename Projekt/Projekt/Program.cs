using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using System.Threading;

namespace Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            Console.WriteLine("In this game your mission is to combine the perfect cocktail using the provided ingredients! \nA group of three judges will score the cocktail based on their taste and preference.\nPress any key to begin.");
            Console.ReadKey();

            Console.WriteLine("\nYour judges are:");

            JuryMember j1 = new JuryMember();
            Thread.Sleep(500);

            JuryMember j2 = new JuryMember();
            Thread.Sleep(500);

            JuryMember j3 = new JuryMember();
            Thread.Sleep(500);

            Console.WriteLine("\nYour base spirit (slot 1) is:");
            Thread.Sleep(500);
            Ingredient s1 = new Spirit(); // Anledningen till att s1 inte lagras i klassen spirit är för att spelaren ska kunna välja vilka typer av ingredienser den ska välja, och det ska sedan gå att addera instansernas variabler. Om de alla lagras i Ingredient spelar det ingen roll vilken typ det är, de går ändå att använda tillsammans.
            Thread.Sleep(500);

            //
            
            Console.WriteLine("\nSlot 2: 1.Add spirit 2.Add modifier 3.Skip slot");

            input = Utils.Choice(1, 3);
            Ingredient s2; // Lagrar en referens till namnet "s2" i klassen ingredient.

            if (input == 1)
            {
                Thread.Sleep(500);
                s2 = new Spirit(); // Om spelaren skriver in 1 blir s2 en spritsort.

                Thread.Sleep(1000);
            }

            else // Om annat blir s2 en modifier.
            {
                Thread.Sleep(500);
                s2 = new Modifier();

                Thread.Sleep(1000);
            }

            //

            Console.WriteLine("\nSlot 3: 1.Add spirit 2.Add modifier 3.Skip slot");

            input = Utils.Choice(1, 3);
            Ingredient s3; // Samma princip som ovan. 

            if (input == 1)              
            {
                Thread.Sleep(500);
                s3 = new Spirit();

                Thread.Sleep(1000);
            }

            else
            {
                Thread.Sleep(500);
                s3 = new Modifier();

                Thread.Sleep(1000);
            }

            //

            Console.WriteLine("\nSlot 4 (Garnish):");
            Thread.Sleep(500);
            Ingredient s4 = new Garnish();

            int totsweet = Utils.ScoreCounter(s1.getSweet(), s2.getSweet(), s3.getSweet(), s4.getSweet()); // KAN INTE KALLA METOD FRÅN EN INSTANS SOM SKAPAS I EN IF-SATS PUCKO

            int totsour = Utils.ScoreCounter(s1.getSour(), s2.getSour(), s3.getSour(), s4.getSour());

            int totbitter = Utils.ScoreCounter(s1.getBitter(), s2.getBitter(), s3.getBitter(), s4.getBitter());

            j1.Score(totsweet, totsour, totbitter);
            j2.Score(totsweet, totsour, totbitter);
            j3.Score(totsweet, totsour, totbitter);

            Console.ReadLine();

        }



    }
}
