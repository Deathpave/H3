using System;
using System.Net;
using System.Threading;

namespace WebServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();

            IPAddress ip = IPAddress.Parse("127.0.0.1");

            server.Start(ip, 80, @"C:\Users\marti\Desktop\EmptyFiles");

            while (server.running)
            {
                Thread.Sleep(5000);
            }

        }
    }
}
