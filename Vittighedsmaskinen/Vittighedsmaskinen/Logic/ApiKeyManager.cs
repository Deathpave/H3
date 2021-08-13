using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vittighedsmaskinen.DontLook;

namespace Vittighedsmaskinen.Logic
{
    public static class ApiKeyManager
    {
        public static bool ValidateApiKey(string ApiKey)
        {
            if (ApiKey == ApiKeys.ApiKey1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
