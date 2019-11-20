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
                Nutmeg();
            }

            if (type == "LimeTwist")
            {
                LimeTwist();
            }

            if (type == "PineappleWedge")
            {
                PineappleWedge();
            }

        }

        public void Nutmeg()
        {
            sweetness = ScopeGenerator(0, 2);
            sourness = ScopeGenerator(0, 2);
            bitterness = ScopeGenerator(3, 8);
        }

        public void LimeTwist()
        {
            sweetness = ScopeGenerator(0, 2);
            sourness = ScopeGenerator(4, 7);
            bitterness = ScopeGenerator(0, 4);
        }

        public void PineappleWedge()
        {
            sweetness = ScopeGenerator(5, 9);
            sourness = ScopeGenerator(2, 5);
            bitterness = ScopeGenerator(0, 3);
        }
    }
}
