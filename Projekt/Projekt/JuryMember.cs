using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class JuryMember : Utils
    {
        List<string> TypeList = new List<string>() { "Sweet", "Sour", "Bitter" }; // En lista med preferenser
        public string preference = "";

        public JuryMember() // Konstruktorn bestämmer preference vilket i sin tur påverkar den slutgiltiga bedömningen.
        {
            preference = TypeList[generator.Next(3)];
            Console.WriteLine("Judge preference: " + preference);
            
        }

        public void Score (int sweet, int sour, int bitter) // Metoden score avgör vilken bedömning drinken får, vilket påverkas av Juryns preference.
        {
            int score = 0;

            score = sweet + sour + bitter;
            score = score / 3;

            if (preference == "Sweet" && sweet > 3)
            {
                score = score + 2;
            }

            if (preference == "Sour" && sour > 3)
            {
                score = score + 2;
            }

            if (preference == "Bitter" && bitter > 3)
            {
                score = score + 2;
            }

            if (score > 10)
            {
                score = 10;
            }

            Console.WriteLine("Score: " + score);
        }
        
    }
}
