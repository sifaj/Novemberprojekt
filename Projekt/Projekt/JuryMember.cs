using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class JuryMember : Utils
    {
        List<string> TypeList = new List<string>() { "Sweet", "Sour", "Bitter" };
        public string preference = "";

        public JuryMember()
        {
            preference = TypeList[generator.Next(3)];
            Console.WriteLine("Judge preference: " + preference);
            
        }

        public void Score (int sweet, int sour, int bitter)
        {
            int score = 0;

            score = sweet + sour + bitter;
            score = score / 3;

            if (preference == "Sweet" && sweet > 5)
            {
                score++;
            }

            if (preference == "Sour" && sour > 5)
            {
                score++;
            }

            if (preference == "Bitter" && bitter > 5)
            {
                score++;
            }

            Console.WriteLine("Score: " + score);
        }
        
    }
}
