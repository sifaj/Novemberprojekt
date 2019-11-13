using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Spirit : Ingredient
    {
        List<string> TypeList = new List<string>() { "Whiskey", "Tequila", "Rum", "Gin", "Vodka" };
        int percentage = 0;
        string name = "";
        string type = "";
        static Random generator = new Random(); // Olika metoder för de olika spritsorterna? Annars hur ska jag göra för att slumpa smaker

        public Spirit()
        {
            type = TypeList[generator.Next(5)];
            Console.WriteLine("Type: " + type);

            percentage = PercentageGenerator(type);
            Console.WriteLine("Percentage: " + percentage + "%");

            
        }

        public void GetStats()
        {
            Console.WriteLine("Type: " + type);
            Console.WriteLine("Percentage: " + percentage + "%");
        }

        public int PercentageGenerator (string type)
        {
            if (type == "Vodka")
            {
                return generator.Next(34, 47);
            }

            if (type == "Tequila" || type == "Whiskey" || type == "Rum")
            {
                return generator.Next(39, 47);
            }

            if (type == "Gin")
            {
                return generator.Next(34, 41);
            }

            return 40;
        } 


    }
}
