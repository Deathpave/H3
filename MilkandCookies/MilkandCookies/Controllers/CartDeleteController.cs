using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkandCookies.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace MilkandCookies.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartDeleteController : Controller
    {
        [HttpGet]
        [Route("{id}")]
        public Product DeleteItem(int id)
        {
            // gets json string from session
            var json = HttpContext.Session.GetString(id.ToString());
            // creates product from json string
            Product p = JsonSerializer.Deserialize<Product>(json);
            // removes key/value with key id
            HttpContext.Session.Remove(id.ToString());
            // returns product to screen
            return p;
        }
    }
}
