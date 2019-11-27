using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Modifier : Ingredient
    {
        List<string> TypeList = new List<string>() { "TonicWater", "OrangeJuice", "Champagne", };

        public Modifier() // Konstruktorn låter spelaren bestämma vilken typ av modifier, för att sedan definiera värden för variablerna sweetness, sourness och bitterness. 
        {
            Console.WriteLine("\nWhat type of modifier do you want to add?\n1.Tonic Water  2.Orange Juice  3.Champagne");
            type = TypeList[Utils.Choice(1, 3) - 1];

            if (type == "TonicWater")
            {
                Attributes(generator.Next(0, 3), generator.Next(1, 5), bitterness = generator.Next(5, 10));
            }

            if (type == "OrangeJuice")
            {
                Attributes(generator.Next(5, 9), generator.Next(2, 7), bitterness = generator.Next(0, 3));
            }

            if (type == "Champagne")
            {
                Attributes(generator.Next(0, 3), generator.Next(4, 7), bitterness = generator.Next(2, 5));
            }

            GetStats();

        }

    }
}
