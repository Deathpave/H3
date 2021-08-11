using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkandCookies.DataModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MilkandCookies.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShoppingcartController : Controller
    {
        /// <summary>
        /// g) Sessionen bliver afsluttet, og findes nu ikke mere.
        /// </summary>
        private static int _id = 0;

        [HttpGet]
        [Route("{name},{price}")]
        public string AddItem(string name, double price)
        {
            // creates a product from user params
            Product product = new Product(name, price);

            // converts product to json string
            string objstring = JsonSerializer.Serialize<Product>(product);

            // adds json string to session by "id"
            HttpContext.Session.SetString(_id.ToString(), objstring);
            // increments id
            _id++;
            // returns string of input
            return name + "," + price.ToString();
        }

        [HttpGet]
        public IEnumerable<Product> GetCart()
        {
            // gets all keys in session
            var keys = HttpContext.Session.Keys;
            // empty list of products
            List<Product> products = new List<Product>();
            // foreach found key
            foreach (var key in keys)
            {
                // gets keys value
                string json = HttpContext.Session.GetString(key);
                // converts json string to product
                Product p = JsonSerializer.Deserialize<Product>(json);
                // adds product to list
                products.Add(p);
            }
            // returns found products
            return products;
        }

        [HttpGet]
        [Route("reset")]
        public void Reset()
        {
            // clears the session
            HttpContext.Session.Clear();
            // resets id
            _id = 0;
        }
    }
}
