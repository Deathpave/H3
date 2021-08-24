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
        // creates a new dbcontext
        private Context ct = new Context();

        public Bartender()
        {
            // creates some data for the db
            ct.Cocktails.Add(new Cocktail()
            {
                Name = "Screwdriver",
                Ingredients = new List<Ingredient>() {
                    new Ingredient() {
                        Name = "Orange juice",
                        Amount = 135,
                    Unit = MeasureUnit.ml
                    },
                    new Ingredient() {
                        Name = "Vodka",
                        Amount = 45,
                    Unit = MeasureUnit.ml
                    } }
            });
            ct.Cocktails.Add(new Cocktail()
            {
                Name = "Daiquiri",
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = "Lime juice",
                        Amount = 25,
                        Unit = MeasureUnit.ml
                    },
                    new Ingredient()
                    {
                        Name = "White rum",
                        Amount = 45,
                        Unit = MeasureUnit.ml
                    },
                    new Ingredient()
                    {
                        Name = "Brown suger",
                        Amount = 1,
                        Unit = MeasureUnit.tsp
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
            // gets all cocktails with ingredient name in them
            var r = ct.Cocktails.Where(p => p.Ingredients.Any(i => i.Name.Contains(name)));
            // returns list of cocktails
            return r.ToList();
        }

        public void AddIngredientToCocktail(Cocktail cocktail, Ingredient ingredient)
        {
            // finds the cocktail in db, and adds ingredient to it
            ct.Cocktails.Where(p => p.Id == cocktail.Id).FirstOrDefault().Ingredients.Add(ingredient);
            // saves changes to db
            ct.SaveChanges();
        }

        public Ingredient NewIngredient(string name, int amount, IngredientType type)
        {
            // creates a new ingredient
            Ingredient ingredient = new Ingredient()
            {
                Name = name,
                Amount = amount,
                Type = type
            };
            // returns the ingredient
            return ingredient;
        }

        public Cocktail NewCocktail(string name, List<Ingredient> ingredients)
        {
            // creates new cocktail
            Cocktail cocktail = new Cocktail()
            {
                Name = name,
                Ingredients = ingredients
            };
            // returns cocktail
            return cocktail;
        }

        public bool RemoveIngredientFromCocktail(Cocktail cocktail, Ingredient ingredient)
        {
            // checks for nulls
            if (cocktail != null && ingredient != null)
            {
                // tries to remove a ingredient from a given cocktail
                var res = ct.Ingredients.Remove(ct.Cocktails.Where(c => c.Id == cocktail.Id).FirstOrDefault().Ingredients.Where(i => i.Id == ingredient.Id).FirstOrDefault());
                // if removed res = removed ingredient
                if (res != null)
                {
                    // if removed save changes and return true
                    ct.SaveChanges();
                    return true;
                }
                return false;
            }
            else
            {
                // if not removed return false
                return false;
            }
        }
        public bool RemoveCocktail(Cocktail cocktail)
        {
            // tries to remove a cocktail
            var res = ct.Cocktails.Remove(ct.Cocktails.Where(c => c.Id == cocktail.Id).FirstOrDefault());
            // if removed res = removed cocktail
            if (res != null)
            {
                // if removed save changes and return true
                ct.SaveChanges();
                return true;
            }
            else
            {
                // if not removed return false;
                return false;
            }
        }

        public bool AddCocktail(Cocktail cocktail)
        {
            // checks if cocktail exists
            if (ct.Cocktails.Any(c => c.Id == cocktail.Id))
            {
                // if exists return false
                return false;
            }
            else
            {
                // if none found, add cocktail and save to db
                ct.Cocktails.Add(cocktail);
                ct.SaveChanges();
                return true;
            }
        }
    }
}
