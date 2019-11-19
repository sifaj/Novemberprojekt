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


        public Modifier()
        {
            Console.WriteLine("\nWhat type of spirit do you want to add?\n1.Tonic Water  2.Orange Juice  3.Champagne");
            type = TypeList[Utils.Choice(1, 3) - 1];
        }
    }
}
