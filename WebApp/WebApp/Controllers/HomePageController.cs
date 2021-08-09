using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomePageController : Controller
    {
        [HttpGet]
        public IEnumerable<TesterClass> Home()
        {
            return Enumerable.Range(0, 2).Select(index => new TesterClass { Alpha = "Kage er godt", Xone = index }).ToArray();
        }
    }
}
