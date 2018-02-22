using System;

namespace CV01PR05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter desired address:");
            string address = Console.ReadLine();
            var GPS = Geocoding.GetGPS(address);
            Console.WriteLine($"GPS of '{address}' is {GPS}");
            var data = Weather.GetWeatherData(GPS);

            Console.WriteLine("Current temperature is {0}", data.Item1);
            Console.WriteLine("Current wind speed is {0}", data.Item2);
            Console.WriteLine("Current pressure is {0}", data.Item3);

            Console.Read();
        }
    }
}