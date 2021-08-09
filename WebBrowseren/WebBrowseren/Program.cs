using System;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace WebBrowseren
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://www.zbc.dk");

            response.EnsureSuccessStatusCode();
            string body = await response.Content.ReadAsStringAsync();

            Regex regex = new Regex("(<[^^]*\\shtml>)|(<*html*>)");
            Console.WriteLine(regex.Replace(body, "<<<>>>"));

            Console.ReadLine();
        }
    }
}
