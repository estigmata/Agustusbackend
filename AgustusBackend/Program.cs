namespace AgustusBackend
{
    using System;
    using Microsoft.Owin.Hosting;

    public class Program
    {
        public static void Main(string[] args)
        {
            string baseAddress = "http://localhost:9000/";

            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine($"Service started at {baseAddress}");
                Console.ReadLine();
            }
        }
    }
}
