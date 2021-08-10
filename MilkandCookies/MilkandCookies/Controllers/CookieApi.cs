using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MilkandCookies.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CookieApi : Controller
    {
        [HttpGet]
        public string GetCookie()
        {
            return "cookie";
        }
    }
}
