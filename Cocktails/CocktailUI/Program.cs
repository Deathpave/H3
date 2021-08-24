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

            // debug
            foreach (var item in a)
            {
                foreach (var ing in item.Ingredients)
                {
                    Console.WriteLine(ing.Name + " - " + ing.Id);
                }
            }
            // debug

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

            var c = bartender.GetCocktailsByIngredientName("Vodka").FirstOrDefault();

            // prints cocktail name
            Console.WriteLine(c.Name);
            // pritns all ingredients in cocktail
            foreach (var item in c.Ingredients)
            {
                Console.WriteLine(item.Name + " - " + item.Amount);
            }
            // adds a new ingredient to the cocktail
            bartender.AddIngredientToCocktail(c, bartender.NewIngredient("Stupid rule", 1, IngredientType.Garnish));

            // gets first cocktail with ingredient
            var cc = bartender.GetCocktailsByIngredientName("Stupid rule").FirstOrDefault();
            // prints cocktail name
            Console.WriteLine(cc.Name);
            // prints all ingredients in cocktail
            foreach (var item in cc.Ingredients)
            {
                Console.WriteLine(item.Name + " - " + item.Amount + " - " + item.Type);
            }

            // tries to remove ingredient from cocktail
            if (bartender.RemoveIngredientFromCocktail(cc, cc.Ingredients.Where(i => i.Name == "Stupid rule").FirstOrDefault()))
            {
                // if removed print
                Console.WriteLine("Ingredient was removed");
            }
            else
            {
                // if not removed print
                Console.WriteLine("Ingredient was not found and removed");
            }

            // tries to remove cocktail from db
            if (bartender.RemoveCocktail(cc))
            {
                // if removed print
                Console.WriteLine("Cocktail was removed");
            }
            else
            {
                // if not removed print
                Console.WriteLine("Cocktail was not found and removed");
            }

            // gets all cocktails
            a = bartender.GetCocktails();
            // prints cocktails name
            foreach (var item in a)
            {
                Console.WriteLine(item.Name);
            }

            List<Ingredient> ingredients = new List<Ingredient>();
            ingredients.Add(bartender.NewIngredient("kage", 1, IngredientType.Edible));
            ingredients.Add(bartender.NewIngredient("fisk", 5, IngredientType.Edible));
            Cocktail newcocktail = bartender.NewCocktail("Tester", ingredients);
            //bartender.AddCocktail(newcocktail);

            // tries to add cocktail
            if (bartender.AddCocktail(newcocktail))
            {
                // if added print
                Console.WriteLine("Cocktail was added");
            }
            else
            {
                // if not added print
                Console.WriteLine("Cocktail was not added");
            }
            if (bartender.AddCocktail(newcocktail))
            {
                // if added print
                Console.WriteLine("Cocktail was added");
            }
            else
            {
                // if not added print
                Console.WriteLine("Cocktail was not added");
            }

            // gets all cocktails
            a = bartender.GetCocktails();
            // prints cocktails name
            foreach (var item in a)
            {
                Console.WriteLine(item.Name);
            }


            // debug
            foreach (var item in a)
            {
                foreach (var ing in item.Ingredients)
                {
                    Console.WriteLine(ing.Name + " - " + ing.Id + " - " + ing.Type);
                }
            }
            // debug

            Console.ReadLine();
        }
    }
}
