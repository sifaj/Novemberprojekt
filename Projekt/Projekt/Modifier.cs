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
            Console.WriteLine("\nWhat type of modifier do you want to add?\n1.Tonic Water  2.Orange Juice  3.Champagne");
            type = TypeList[Utils.Choice(1, 3) - 1];

            if (type == "TonicWater")
            {
                TonicWater();
            }

            if (type == "OrangeJuice")
            {
                OrangeJuice();
            }

            if (type == "Champagne")
            {
                Champagne();
            }

        }

        public void TonicWater()
        {
            sweetness = ScopeGenerator(0, 3);
            sourness = ScopeGenerator(1, 5);
            bitterness = ScopeGenerator(5, 10);

        }

        public void OrangeJuice()
        {
            sweetness = ScopeGenerator(5, 9);
            sourness = ScopeGenerator(2, 5);
            bitterness = ScopeGenerator(0, 3);
        }

        public void Champagne()
        {
            sweetness = ScopeGenerator(0, 3);
            sourness = ScopeGenerator(4, 7);
            bitterness = ScopeGenerator(2, 5);
        }
    }
}
