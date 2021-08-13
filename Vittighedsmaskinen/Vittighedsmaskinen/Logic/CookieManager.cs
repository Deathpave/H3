using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Vittighedsmaskinen.DataModels;

namespace Vittighedsmaskinen.Logic
{
    public class CookieManager
    {
        public string SetCategoryCookie(string Cat)
        {
            string response = string.Empty;
            List<string> categories = Enum.GetNames(typeof(Category)).ToList();
            if (categories.Contains(Cat))
            {
                response = JsonSerializer.Serialize<string>(Cat);
            }
            return response;
        }
    }
}
