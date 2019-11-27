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

        public static int ScoreCounter(int one, int two, int three, int four) // Denna metod lägger ihop fyra int:s och returnar summan av dem. Används för att lägga ihop värdet för de olika smakerna på s1, s2, s3 och s4.
        {
            int sum = one + two + three + four;
            return sum;
        }         

    }
}
