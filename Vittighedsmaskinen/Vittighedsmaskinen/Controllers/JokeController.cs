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
            //Tuple<string, string> res = manager.GetRandomJoke(HttpContext);
            Tuple<string, string> res = manager.GetRandomJokeLanguage(HttpContext);
            HttpContext.Session.SetString("UsedJokes", res.Item2);

            return res.Item1;
        }

        [HttpGet]
        [Route("Category")]
        public string GetCategory()
        {
            string cats = "";
            foreach (var item in Enum.GetNames(typeof(Category)))
            {
                cats += item + "\n";
            }
            return cats;
        }

        [HttpGet]
        [Route("Category/{Cat}")]
        public string SetCategory(string Cat)
        {
            CookieManager cookieManager = new CookieManager();
            string value = cookieManager.SetCategoryCookie(Cat);
            if (value != string.Empty && value != "Category not allowed!")
            {
                HttpContext.Response.Cookies.Append("FavCat", value);
                return "Preferred category set!";
            }
            if (value != string.Empty)
            {
                return value;
            }
            else
            {
                return "Category not found";
            }
        }

        [HttpGet]
        [Route("Category/{Cat}/{ApiKey}")]
        public string SetCategory(string Cat, string ApiKey)
        {
            CookieManager cookieManager = new CookieManager();
            string value = cookieManager.SetCategoryCookie(Cat, ApiKey);
            if (value != string.Empty && value != "Category not allowed!")
            {
                HttpContext.Response.Cookies.Append("FavCat", value);
                return "Preferred category set!";
            }
            if (value != string.Empty)
            {
                return value;
            }
            else
            {
                return "Category not found";
            }
        }
    }
}
