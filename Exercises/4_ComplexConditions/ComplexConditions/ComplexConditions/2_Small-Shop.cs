using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexConditions
{
    class Program
    {
        static void Main(string[] args)
        {
            //град /   coffee water   beer sweets  peanuts
            //Sofia   0.50    0.80    1.20    1.45    1.60
            //Plovdiv 0.40    0.70    1.15    1.30    1.50
            //Varna   0.45    0.70    1.10    1.35    1.55

            string product = Console.ReadLine().ToLower();
            string town = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            if (town == "sofia")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(quantity * 0.50);
                }
                if (product == "water")
                {
                    Console.WriteLine(quantity * 0.80);
                }
                if (product == "beer")
                {
                    Console.WriteLine(quantity * 1.20);
                }
                if (product == "sweets")
                {
                    Console.WriteLine(quantity * 1.45);
                }
                if (product == "peanuts")
                {
                    Console.WriteLine(quantity * 1.60);
                }
            }
            else if (town == "plovdiv")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(quantity * 0.40);
                }
                if (product == "water")
                {
                    Console.WriteLine(quantity * 0.70);
                }
                if (product == "beer")
                {
                    Console.WriteLine(quantity * 1.15);
                }
                if (product == "sweets")
                {
                    Console.WriteLine(quantity * 1.30);
                }
                if (product == "peanuts")
                {
                    Console.WriteLine(quantity * 1.50);
                }

            }
            else if (town == "varna")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(quantity * 0.45);
                }
                if (product == "water")
                {
                    Console.WriteLine(quantity * 0.70);
                }
                if (product == "beer")
                {
                    Console.WriteLine(quantity * 1.10);
                }
                if (product == "sweets")
                {
                    Console.WriteLine(quantity * 1.35);
                }
                if (product == "peanuts")
                {
                    Console.WriteLine(quantity * 1.55);
                }

            }
        }
    }
}
