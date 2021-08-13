using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vittighedsmaskinen.DataModels;
using Vittighedsmaskinen.Logic;

namespace Vittighedsmaskinen.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JokeController : Controller
    {
        [HttpGet]
        [Route("Random")]
        public string GetRandom()
        {
            JokeManager manager = new JokeManager();
            Tuple<string, string> res = manager.GetRandomJoke(HttpContext);
            HttpContext.Session.SetString("UsedJokes", res.Item2);

            return res.Item1;
        }
    }
}
