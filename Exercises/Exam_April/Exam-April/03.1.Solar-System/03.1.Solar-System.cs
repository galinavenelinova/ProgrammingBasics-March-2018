using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._1.Solar_System
{
    class Program
    {
        static void Main(string[] args)
        {
            string planet = Console.ReadLine();
            int daysOnPlanet = int.Parse(Console.ReadLine());

            double distance = 0;
            int maxDaysOnPlanet = 0;

            switch (planet)
            {
                case "Mercury": distance = 0.61; maxDaysOnPlanet = 7; break;
                case "Venus": distance = 0.28; maxDaysOnPlanet = 14; break;
                case "Mars": distance = 0.52; maxDaysOnPlanet = 20; break;
                case "Jupiter": distance = 4.2; maxDaysOnPlanet = 5; break;
                case "Saturn": distance = 8.52; maxDaysOnPlanet = 3; break;
                case "Uranus": distance = 18.21; maxDaysOnPlanet = 3; break;
                case "Neptune": distance = 29.09; maxDaysOnPlanet = 2; break;
            }

            double totalDistance = distance * 2;
            double totalDays = totalDistance * 226 + daysOnPlanet;

            if (distance == 0)
            {
                Console.WriteLine("Invalid planet name!");
            }
            else if (daysOnPlanet > maxDaysOnPlanet)
            {
                Console.WriteLine("Invalid number of days!");
            }
            else
            {
                Console.WriteLine("Distance: {0:f2}", totalDistance);
                Console.WriteLine("Total number of days: {0:f2}", totalDays);
            }
        }
    }
}
