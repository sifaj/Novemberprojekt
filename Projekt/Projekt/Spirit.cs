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
            

            if (type == "Whiskey")
            {
                Whiskey();
            } // Beroende på vilken spritsort det blir kommer respektive metod köra för att slumpa instansens egenskaper.

            if (type == "Tequila")
            {
                Tequila();
            }

            if (type == "Rum")
            {
                Rum();
            }

            if (type == "Gin")
            {
                Gin();
            }

            if (type == "Vodka")
            {
                Vodka();
            }

            GetStats();

            InstanceExists = true;
            
        }

        public void GetStats() // Denna metod skriver ut värdena av de int-variabler instansen har samt vilken typ av sprit det är. 
        {
            Console.WriteLine("Type: " + type);
            Console.WriteLine("Percentage: " + percentage + "%");
            Console.WriteLine("Sweetness: " + sweetness + "/10");
            Console.WriteLine("Sourness: " + sourness + "/10");
            Console.WriteLine("Bitterness: " + bitterness + "/10");
        }

        public void Whiskey()    // Varje spritsort har en egen metod där värden för int-variablerna Percetange (alkoholhalt), sweetness, sourness och bitterness inom ett scope som är realistiskt för varje sort.
        {
            percentage = ScopeGenerator(39, 47);
            sweetness = ScopeGenerator(0, 5);
            sourness = ScopeGenerator(0, 3);
            bitterness = ScopeGenerator(2, 6);
        }

        public void Tequila()
        {
            percentage = ScopeGenerator(39, 47);
            sweetness = ScopeGenerator(4, 9);
            sourness = ScopeGenerator(0, 2);
            bitterness = ScopeGenerator(0, 3);
        }

        public void Rum()
        {
            percentage = ScopeGenerator(39, 47);
            sweetness = ScopeGenerator(6, 10);
            sourness = ScopeGenerator(0, 4);
            bitterness = ScopeGenerator(1, 5);
        }

        public void Gin()
        {
            percentage = ScopeGenerator(34, 41);
            sweetness = ScopeGenerator(1, 3);
            sourness = ScopeGenerator(1, 6);
            bitterness = ScopeGenerator(4, 9);
        }

        public void Vodka()
        {
            percentage = ScopeGenerator(34, 46);
            sweetness = ScopeGenerator(0, 3);
            sourness = ScopeGenerator(0, 2);
            bitterness = ScopeGenerator(1, 5);
        }






    }
}
