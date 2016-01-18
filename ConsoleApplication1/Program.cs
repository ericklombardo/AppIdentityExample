using System;
using Microsoft.Owin.Hosting;

namespace AppIdentityExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseUri = "http://localhost:8080";

            Console.WriteLine("Starting web Server...");
            using (WebApp.Start<Startup>(baseUri))
            {
                Console.WriteLine($"Server running at {baseUri} - press any key to quit. ");
                Console.ReadLine();
            }
        }
    }
}
