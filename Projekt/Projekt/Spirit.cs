using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Spirit : Ingredient
    {
        List<string> TypeList = new List<string>() { "Whiskey", "Tequila", "Rum", "Gin", "Vodka" }; // Listan med de olika spritsorterna instansen kan få som för med sig olika värden för dess egenskaper.
        int percentage = 0;
        // string name = "";
        static bool InstanceExists = false; 
        

        public Spirit()
        {
            if (InstanceExists == false)
            {
                type = TypeList[generator.Next(5)];
            }

            else if (InstanceExists == true)
            {
                Console.WriteLine("\nWhat type of spirit do you want to add?\n1.Whiskey  2.Tequila  3.Rum  4.Gin  5.Vodka");
                type = TypeList[Utils.Choice(1, 5) - 1];
            }


            if (type == "Whiskey") // Beroende på vilken spritsort det blir kommer instansens egenskaper genereras med hjälp av metoden Attributes.
            {
                Attributes(generator.Next(0, 5), generator.Next(0, 3), generator.Next(2, 6));
                percentage = generator.Next(39, 47);
            } 

            if (type == "Tequila")
            {
                Attributes( generator.Next(4, 9), generator.Next(0, 2), generator.Next(0, 3));
                percentage = generator.Next(39, 47);
            }

            if (type == "Rum")
            {
                Attributes(generator.Next(6, 10), generator.Next(0, 4), generator.Next(1, 5));
                percentage = generator.Next(39, 47);
            }

            if (type == "Gin")
            {
                Attributes(generator.Next(1, 3), generator.Next(1, 4), generator.Next(4, 9));
                percentage = generator.Next(34, 41);
            }

            if (type == "Vodka")
            {
                Attributes(generator.Next(0, 3), generator.Next(0, 3), generator.Next(1, 5));
                percentage = generator.Next(34, 46);
            }

            GetStats();

            InstanceExists = true;
            
        }

        public override void GetStats() // Denna metod skriver ut värdena av de int-variabler instansen har samt vilken typ av sprit det är. 
        {
            Console.WriteLine("\nType: " + type + "\nStats: " + "\nPercentage: " + percentage + "%\nSweetness: " + sweetness + "/10\nSourness: " + sourness + "/10\nBitterness: " + bitterness + "/10");
        }








    }
}
