using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vittighedsmaskinen.DataModels
{
    public class Joke
    {
        public Category Category { get; set; }
        public string Text { get; set; }
        public Language Language { get; set; }
    }
}
