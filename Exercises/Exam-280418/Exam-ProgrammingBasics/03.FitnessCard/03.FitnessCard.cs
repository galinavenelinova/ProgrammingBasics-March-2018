using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FitnessCard
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyAvailable = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sportKind = Console.ReadLine();

            double fitnessCardPrice = 0;

            if (gender == 'm')
            {
                switch (sportKind)
                {
                    case "Gym":
                        fitnessCardPrice = 42; break;
                    case "Boxing":
                        fitnessCardPrice = 41; break;
                    case "Yoga":
                        fitnessCardPrice = 45; break;
                    case "Zumba":
                        fitnessCardPrice = 34; break;
                    case "Dances":
                        fitnessCardPrice = 51; break;
                    case "Pilates":
                        fitnessCardPrice = 39; break;
                }
            }
            else if (gender == 'f')
            {
                switch (sportKind)
                {
                    case "Gym":
                        fitnessCardPrice = 35; break;
                    case "Boxing":
                        fitnessCardPrice = 37; break;
                    case "Yoga":
                        fitnessCardPrice = 42; break;
                    case "Zumba":
                        fitnessCardPrice = 31; break;
                    case "Dances":
                        fitnessCardPrice = 53; break;
                    case "Pilates":
                        fitnessCardPrice = 37; break;
                }
            }

            if (age <= 19)
            {
                fitnessCardPrice = fitnessCardPrice * (100 - 20) / 100;
            }

            if (moneyAvailable >= fitnessCardPrice)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sportKind}.");
            }
            else
            {
                Console.WriteLine("You don't have enough money! You need ${0:f2} more.", 
                    fitnessCardPrice - moneyAvailable);
            }
        }
    }
}
