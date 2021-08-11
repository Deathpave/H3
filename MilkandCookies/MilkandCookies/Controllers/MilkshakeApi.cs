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
    public class MilkshakeApi : Controller
    {
        [HttpGet]
        // [Route("[action]")]
        public string GetMilkshake()
        {
            // gets the value from the cookie
            string cookiestring = Request.Cookies["favoritmilkshake"];
            // if the value is null
            if (cookiestring == null)
            {
                // sets value to unknown
                cookiestring = "Unknown";
            }
            // returns response
            return "your milkshake: " + cookiestring;
        }

        [HttpGet]
        [Route("{taste?}")]
        public string GetMilkshake(string taste)
        {
            // sets options for cookie
            CookieOptions cookieOptions = new CookieOptions();
            // creates new timespan 5 minutes
            TimeSpan timeSpan = new TimeSpan(0, 5, 0);
            // sets cookies life time
            cookieOptions.MaxAge = timeSpan;
            // adds cookie with options
            Response.Cookies.Append("favoritmilkshake", taste, cookieOptions);
            // returns response
            return "milkshake with taste of: " + taste;
        }
    }
}
