using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails.DataModels
{
    [Table("Ingredients")]
    public class Ingredient
    {
        [Key]
        public int Id { get; set; }
        //[Column("Name")]
        public string Name { get; set; }
        //[Column("Amount")]
        public MeasureUnit Unit { get; set; }
        public int Amount { get; set; }
        public IngredientType Type { get; set; }
        public Ingredient()
        {
        }
    }
}
