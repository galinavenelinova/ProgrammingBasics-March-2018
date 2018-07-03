using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.RunningInThePark
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int totalMinutes = 0;
            double totalDistance = 0;
            double caloriesPerDay = 0, totalCalories = 0;
            
            for (int day = 1; day <= n; day++)
            {
                int timeRunPerDay = int.Parse(Console.ReadLine());
                double distanceRunPerDay = double.Parse(Console.ReadLine());
                string mOrKm = Console.ReadLine();

                if (mOrKm == "m")
                {
                    distanceRunPerDay = distanceRunPerDay / 1000;
                }

                caloriesPerDay = timeRunPerDay * 400 / 20;

                totalMinutes += timeRunPerDay;
                totalDistance += distanceRunPerDay;
                totalCalories += caloriesPerDay;
            }

            Console.WriteLine($"He ran {totalDistance:f2}km for {totalMinutes} minutes and burned {totalCalories} calories.");
        }
    }
}
