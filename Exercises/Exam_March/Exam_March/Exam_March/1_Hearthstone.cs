using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_March
{
    class Program
    {
        static void Main(string[] args)
        {
            int restTime = int.Parse(Console.ReadLine());
            double cardPrice = double.Parse(Console.ReadLine());
            double advPrice = double.Parse(Console.ReadLine());
            double coffeePrice = double.Parse(Console.ReadLine());

            int timeLeft = restTime - 5 - (3 * 2) - (2 * 2);
            double moneySpent = 3 * cardPrice + 2 * advPrice + coffeePrice;

            Console.WriteLine($"{moneySpent:F2}");
            Console.WriteLine(timeLeft);
        }
    }
}
