using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._1.Moon
{
    class Program
    {
        static void Main(string[] args)
        {
            int speed = int.Parse(Console.ReadLine());
            int gasPro100Km = int.Parse(Console.ReadLine());

            double distance = 384400;
            double timeTravel = (2 * distance) / speed;
            double timeTotal = timeTravel + 3;

            double gasNeeded = (gasPro100Km * 2 * distance) / 100;

            Console.WriteLine(Math.Ceiling(timeTotal));
            Console.WriteLine(gasNeeded);
        }
    }
}
