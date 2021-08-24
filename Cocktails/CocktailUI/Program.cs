using Cocktails.Dal;
using Cocktails.DataModels;
using Cocktails.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CocktailUI
{
    class Program
    {
        static Bartender bartender = new Bartender();
        static void Main(string[] args)
        {
            // gets all cocktails
            var a = bartender.GetCocktails();
            // prints cocktails name
            foreach (var item in a)
            {
                Console.WriteLine(item.Name);
            }

            // gets cocktails by ingredient name
            var b = bartender.GetCocktailsByIngredientName("Vodka");
            // prints cocktails name
            foreach (var ab in b)
            {
                Console.WriteLine(ab.Name);
            }

            Console.ReadLine();
        }
    }
}
