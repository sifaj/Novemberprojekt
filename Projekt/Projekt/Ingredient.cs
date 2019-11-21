using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Ingredient : Utils
    {


        protected int sweetness = 0; // Dessa variabler kontrollerar sötheten, surheten och bitterheten hos ingrediensen. Dessa variabler påverkar sedan hur mycket jurymedlemmarna gillar drinken.
        protected int sourness = 0; // Variablerna är protected eftersom att de ska kunna användas av de tre subklasserna som genererar de ingredienser som ska vara me di drinken.
        protected int bitterness = 0;
        protected string type = "";

        public int getSweet()
        {
            return sweetness;
        }

        public int getSour()
        {
            return sourness;
        }

        public int getBitter()
        {
            return bitterness;
        }




    }
}
