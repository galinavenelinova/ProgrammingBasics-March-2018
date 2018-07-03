using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Match_tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine().ToLower();
            int people = int.Parse(Console.ReadLine());

            double ticketPrice = 249.99;

            if (category == "vip")
            {
                ticketPrice = 499.99;
            }

            if (people >= 1 && people <=4)
            {
                budget -= 0.75 * budget;
            }
            else if (people >= 5 && people <= 9)
            {
                budget -= 0.6 * budget;
            }
            else if (people >= 10 && people <= 24)
            {
                budget -= 0.5 * budget;
            }
            else if (people >= 25 && people <= 49)
            {
                budget -= 0.4 * budget;
            }
            else if (people >= 50)
            {
                budget -= 0.25 * budget;
            }

            if (budget >= people * ticketPrice)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", budget - people * ticketPrice);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", people * ticketPrice - budget);
            }
        }
    }
}
