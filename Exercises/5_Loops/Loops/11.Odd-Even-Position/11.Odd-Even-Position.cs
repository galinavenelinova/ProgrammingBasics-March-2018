using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double oddSum = 0, evenSum = 0;
            double oddMin = 1000000000, evenMin = 1000000000;
            double oddMax = -1000000000, evenMax = -1000000000;

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    oddSum += num;

                    if (num < oddMin)
                        oddMin = num;
                    if (num > oddMax)
                        oddMax = num;
                }
                else
                {
                    evenSum += num;

                    if (num < evenMin)
                        evenMin = num;
                    if (num > evenMax)
                        evenMax = num;
                }
            }

            Console.WriteLine($"Oddsum={oddSum},");

            if (oddMin == 1000000000)
            {
                Console.WriteLine("Oddmin=No,");
            }
            else
            {
                Console.WriteLine($"Oddmin={oddMin},");
            }

            if (oddMax == -1000000000)
            {
                Console.WriteLine("Oddmax=No,");
            }
            else
            {
                Console.WriteLine($"Oddmax={oddMax},");
            }

            Console.WriteLine($"Evensum={evenSum},");

            if (evenMin == 1000000000)
            {
                Console.WriteLine("Evenmin=No,");
            }
            else
            {
                Console.WriteLine($"Evenmin={evenMin},");
            }

            if (evenMax == -1000000000)
            {
                Console.WriteLine("Evenmax=No");
            }
            else
            {
                Console.WriteLine($"Evenmax={evenMax}");
            }
        }
    }
}
