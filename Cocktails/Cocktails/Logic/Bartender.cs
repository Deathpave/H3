using Cocktails.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cocktails.Dal;
using System.Threading.Tasks;

namespace Cocktails.Logic
{
    public class Bartender
    {
        Context ct = new Context();

        public Bartender()
        {
            // creates some data for the db
            ct.Cocktails.Add(new Cocktail()
            {
                Id = ct.Cocktails.Count(),
                Name = "Screwdriver",
                Ingredients = new List<Ingredient>() {
                    new Ingredient() { Id = ct.Ingredients.Count(),
                        Name = "Orange juice", Amount = "135ml" },
                    new Ingredient() { Id = ct.Ingredients.Count(),
                        Name = "Vodka", Amount = "45ml" } }
            });
            ct.Cocktails.Add(new Cocktail()
            {
                Id = ct.Cocktails.Count(),
                Name = "Daiquiri",
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Id = ct.Ingredients.Count(),
                        Name = "Lime juice",
                        Amount = "25ml"
                    },
                    new Ingredient()
                    {
                        Id = ct.Ingredients.Count(),
                        Name = "White rum",
                        Amount = "45ml"
                    },
                    new Ingredient()
                    {
                        Id = ct.Ingredients.Count(),
                        Name = "Brown suger",
                        Amount = "1 tablespoon"
                    }
                }
            });
            ct.SaveChanges();
        }

        public List<Cocktail> GetCocktails()
        {
            // gets all cocktails from db
            List<Cocktail> cocktails = ct.Cocktails.ToList();
            // returns cocktails
            return cocktails;
        }

        public List<Cocktail> GetCocktailsByIngredientName(string name)
        {
            var r = ct.Cocktails.Where(p => p.Ingredients.Any(i => i.Name.Contains(name)));
            return r.ToList();
        }


    }
}
