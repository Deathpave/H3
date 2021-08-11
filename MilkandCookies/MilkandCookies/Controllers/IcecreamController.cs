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
    public class IcecreamController : Controller
    {
        [HttpGet]
        public string GetBurgerCookie()
        {
            // cookie options
            CookieOptions options = new CookieOptions();
            options.MaxAge = new TimeSpan(0, 0, -1);

            // this doesnt work?
            // Response.Cookies.Delete("BurgerCookie");
            // gets the value from the cookie
            string cookiestring = Request.Cookies["BurgerCookie"];
            // if the value is null
            if (cookiestring == null)
            {
                // sets value to unknown
                cookiestring = "404 cookie not found";
            }
            // returns response
            return cookiestring;

            // cookie is deleted after this is called. ( browser/tab closing )
        }
    }
}
