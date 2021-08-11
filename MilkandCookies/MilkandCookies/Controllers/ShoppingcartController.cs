using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MilkandCookies.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShoppingcartController : Controller
    {
        [HttpGet]
        [Route("{name}.{price}")]
        public string AddItem(string name, double price)
        {
            return name + price;
        }

        [HttpGet]
        public string[] GetCart()
        {
            return new string[] { };
        }
    }
}
