using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            string destination = "Europe";
            string vacation = "Hotel";
            double price = budget * 0.9;

            if (budget <= 100)
            {
                destination = "Bulgaria";

                if (season == "summer")
                {
                    vacation = "Camp";
                    price = budget * 0.3;
                }
                else if (season == "winter")
                {
                    price = budget * 0.7;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";

                if (season == "summer")
                {
                    vacation = "Camp";
                    price = budget * 0.4;
                }
                else if (season == "winter")
                {
                    price = budget * 0.8;
                }
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{vacation} - {price:f2}");
        }
    }
}
