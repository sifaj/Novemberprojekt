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
            Console.WriteLine("\nWhat type of spirit do you want to add?\n1.Nutmeg  2.Lime Twist  3.Pineapple Wedge");
            type = TypeList[Utils.Choice(1, 3) - 1];
        }

        public void Nutmeg()
        {

        }

        public void LimeTwist()
        {

        }

        public void PineappleWedge()
        {

        }
    }
}
