using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MilkandCookies.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class BurgersController : Controller
    {
        [HttpGet]
        public string CreateCookie()
        {
            // sets options for cookie
            CookieOptions cookieOptions = new CookieOptions();
            // creates new timespan 5 minutes
            TimeSpan timeSpan = new TimeSpan(0, 5, 0);
            // sets cookies life time
            cookieOptions.MaxAge = timeSpan;
            // adds cookie with options
            Response.Cookies.Append("BurgerCookie", "Burgers are good for you", cookieOptions);
            // returns response
            return "Burger cookie set";
        }
    }
}
