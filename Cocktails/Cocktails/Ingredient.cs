using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    public class Ingredient
    {
        public string Name { get; private set; }
        public string Amount { get; private set; }
        public Ingredient(string name, string amount)
        {
            Name = name;
            Amount = amount;
        }
    }
}
