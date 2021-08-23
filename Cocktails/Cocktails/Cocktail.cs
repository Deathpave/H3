using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    public class Cocktail
    {
        public string Name { get; private set; }
        public List<Ingredient> Ingredients { get; private set; }

        public Cocktail(string name, List<Ingredient> ingredients)
        {
            Name = name;
            Ingredients = ingredients;
        }
    }
}
