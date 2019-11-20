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

            Console.WriteLine("\nYour base spirit (slot 1) is:");
            Thread.Sleep(500);
            Ingredient s1 = new Spirit(); // Anledningen till att s1 inte lagras i klassen spirit är för att spelaren ska kunna välja vilka typer av ingredienser den ska välja, och det ska sedan gå att addera instansernas variabler. Om de alla lagras i Ingredient spelar det ingen roll vilken typ det är, de går ändå att använda tillsammans.
            Thread.Sleep(500);

            //
            
            Console.WriteLine("\nSlot 2: 1.Add spirit 2.Add modifier 3.Skip slot");
            input = Utils.Choice(1, 3);

            if (input == 1)
            {
                Thread.Sleep(500);
                Ingredient s2 = new Spirit();

                Thread.Sleep(1000);
            }

            if (input == 2)
            {
                Thread.Sleep(500);
                Ingredient s2 = new Modifier();

                Thread.Sleep(1000);
            }

            //

            Console.WriteLine("\nSlot 3: 1.Add spirit 2.Add modifier 3.Skip slot");
            input = Utils.Choice(1, 3);
            if (input == 1)

            {
                Thread.Sleep(500);
                Ingredient s3 = new Spirit();

                Thread.Sleep(1000);
            }

            if (input == 2)
            {
                Thread.Sleep(500);
                Ingredient s3 = new Modifier();

                Thread.Sleep(1000);
            }

            //

            Console.WriteLine("\nSlot 4 (Garnish):");
            Thread.Sleep(500);
            Ingredient s4 = new Garnish();

            Console.ReadLine();

        }



    }
}
