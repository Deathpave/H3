using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vittighedsmaskinen.DataModels;

namespace Vittighedsmaskinen.DontLook
{
    public class JokeList
    {
        public JokeList()
        {
            Jokes = new List<Joke>();
        }
        public List<Joke> Jokes { get; set; }
    }
}
