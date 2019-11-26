using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Garnish : Ingredient
    {
        List<string> TypeList = new List<string>() { "Nutmeg", "LimeTwist", "PineappleWedge", };

        public Garnish()
        {
            Console.WriteLine("\nWhat type of garnish do you want to add?\n1.Nutmeg  2.Lime Twist  3.Pineapple Wedge");
            type = TypeList[Utils.Choice(1, 3) - 1];

            if (type == "Nutmeg" )
            {
                Attributes(generator.Next(0, 2), generator.Next(0, 2), bitterness = generator.Next(3, 8));
            }

            if (type == "LimeTwist")
            {
                Attributes(generator.Next(0, 2), generator.Next(4, 7), bitterness = generator.Next(0, 4));
            }

            if (type == "PineappleWedge")
            {
                Attributes(generator.Next(5, 9), generator.Next(2, 5), bitterness = generator.Next(0, 3));
            }

            GetStats();

        }
    }
}
