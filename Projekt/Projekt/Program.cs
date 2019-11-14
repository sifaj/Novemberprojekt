using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json;
using System.Threading;

namespace Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In this game your mission is to combine the perfect cocktail using the provided ingredients! \nA group of three judges will score the cocktail based on their taste and preference.");

            Spirit s1 = new Spirit();

            Console.WriteLine("Generate a new spirit?");

            Spirit s2 = new Spirit();

            Console.ReadKey();


        }



    }
}
