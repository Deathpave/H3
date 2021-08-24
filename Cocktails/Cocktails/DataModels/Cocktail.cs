using Cocktails.DataModels.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.DataModels
{
    [Table("Cocktails")]
    public class Cocktail : IDrink
    {
        [Key]
        public int Id { get; set; }
        //[Column("Name")]
        public string Name { get; set; }

        public List<Ingredient> Ingredients { get; set; }

        public Cocktail()
        {
        }

        public void DrinkAmount(int ml)
        {
            Console.WriteLine("drank " + ml + " ml");
        }

        public void DrinkAll()
        {
            Console.WriteLine("Drink is now empty!");
        }
    }
}
