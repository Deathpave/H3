using Cocktails.DataModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.Dal
{
    public class Context : DbContext
    {
        public Context() : base("DrinkDB")
        {
            Database.SetInitializer<Context>(new DropCreateDatabaseAlways<Context>());
        }

        public DbSet<Cocktail> Cocktails { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
    }
}
