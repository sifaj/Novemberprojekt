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

        public int GetSweet()
        {
            return sweetness;
        } // Returnar värdet av sweetness.

        public int GetSour()
        {
            return sourness;
        } // Returnar värdet av sourness.

        public int GetBitter()
        {
            return bitterness;
        } // Returnar värdet av bitterness.

        public void Attributes(int inputSweet, int inputSour, int inputBitter) // En metod som definierar variablerna sweetness, sourness och bitterness efter input. 
        {
            sweetness = inputSweet;
            sourness = inputSour;
            bitterness = inputBitter;
        } 

        public virtual void GetStats() // En metod som helt enkelt skriver ut stats.
        {
            Console.WriteLine("\nStats:\nType: " + type + "\nSweetness: " + sweetness + "/10\nSourness: " + sourness + "/10\nBitterness: " + bitterness + "/10\n");
        }




    }
}
