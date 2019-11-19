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
            Console.WriteLine("In this game your mission is to combine the perfect cocktail using the provided ingredients! \nA group of three judges will score the cocktail based on their taste and preference.\nPress any key to begin.");
            Console.ReadKey();

            Console.WriteLine("Your base spirit is:");
            Thread.Sleep(500);
            Ingredient s1 = new Spirit(); // Anledningen till att s1 inte lagras i klassen spirit är för att spelaren ska kunna välja vilka typer av ingredienser den ska välja, och det ska sedan gå att addera instansernas variabler. Om de alla lagras i Ingredient spelar det ingen roll vilken typ det är, de går ändå att använda tillsammans.
            Thread.Sleep(500);

            for (int i = 0; i < 3; i++)
            {
                
            }


            Console.WriteLine("What type of spirit do you want to generate?");
            Thread.Sleep(500);
            Ingredient s2 = new Spirit();

            Console.ReadKey();


        }



    }
}
