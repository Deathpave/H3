using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Vittighedsmaskinen.DataModels;
using Vittighedsmaskinen.DontLook;

namespace Vittighedsmaskinen.Logic
{
    public class JokeManager
    {
        public Tuple<string, string> GetRandomJoke(HttpContext context)
        {
            // holders for return data
            string foundJoke = string.Empty;
            string json = string.Empty;
            JokeList usedJokes = new JokeList();

            // gets all jokes
            List<Joke> allJokes = Jokes.GetAllJokes();
            // gets the json string from session
            string usedJokesJson = context.Session.GetString("UsedJokes");
            // checks if there have been used any jokes in this session
            if (usedJokesJson != null && usedJokesJson != string.Empty && usedJokesJson != "{}")
            {
                // converts json string to list of jokes
                usedJokes = JsonSerializer.Deserialize<JokeList>(usedJokesJson);
                // remoces all used jokes from list
                List<Joke> jokes = allJokes.Except(usedJokes.Jokes).ToList();
                if (jokes.Count > 0)
                {
                    // gets a random joke from the list
                    Joke joke = jokes[new Random().Next(jokes.Count)];
                    // adds the taken joke to used jokes list
                    usedJokes.Jokes.Add(joke);
                    // converts found joke to json string
                    foundJoke = JsonSerializer.Serialize<Joke>(joke);
                }
                else
                {
                    // converts string to json string
                    foundJoke = JsonSerializer.Serialize("No more jokes");
                }
            }
            // if there have not been used any jokes this session
            else
            {
                // get random joke
                Joke joke = allJokes[new Random().Next(allJokes.Count)];
                // converts string to json string
                foundJoke = JsonSerializer.Serialize<Joke>(joke);
                usedJokes.Jokes.Add(joke);
            }

            // converts used joke list to json string
            json = JsonSerializer.Serialize<JokeList>(usedJokes);
            // returns the joke and the used joke json strings
            return new Tuple<string, string>(foundJoke, json);
        }
    }
}
