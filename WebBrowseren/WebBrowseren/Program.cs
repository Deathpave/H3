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
            // create a http client
            HttpClient client = new HttpClient();
            // requests a website
            HttpResponseMessage response = await client.GetAsync("https://www.zbc.dk");

            // makes sure the status code is success
            response.EnsureSuccessStatusCode();
            // html content
            string body = await response.Content.ReadAsStringAsync();

            // regex to remove html tags
            Regex regex = new Regex("(<[^^]*\\shtml>)|(<*html*>)");
            // prints html content without html tags
            Console.WriteLine(regex.Replace(body, "<<<>>>"));

            Console.ReadLine();
        }
    }
}
