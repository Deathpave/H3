using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vittighedsmaskinen.DataModels;

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
            return "Random joke!";
        }
    }
}
