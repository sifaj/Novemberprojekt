using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Utils
    {
        protected static Random generator = new Random(); // En random generator som är static för att inte få samma värde

        public static int Choice(int minChoice, int maxChoice) // En metod som möjliggör att välja hur många inputs spelaren kan ge, och som ser till att den är giltig inom angett scope.
        {
            int returnValue = 0;
            bool check = false;
            Console.WriteLine("Choose a number between " + minChoice + " and " + maxChoice + " as input.");

            while (check == false)
            {
                int.TryParse(Console.ReadLine(), out returnValue);

                if (returnValue > maxChoice || returnValue < minChoice)
                {
                    Console.WriteLine("Not compliable. Choose a number between " + minChoice + " and " + maxChoice + " as input.");
                    check = false;
                }
                else
                {
                    return returnValue;
                }
            }

            return 1;
        }

        public int ScopeGenerator(int min, int max) // Denna metod genererar ett värde mellan de sifforna som anges som min och max, för att kontrollera scopet som värdet ligger i. Denna metod är public för att den ska kunna användas av subklasserna.
        {
            return generator.Next(min, max);
        }
    }
}
