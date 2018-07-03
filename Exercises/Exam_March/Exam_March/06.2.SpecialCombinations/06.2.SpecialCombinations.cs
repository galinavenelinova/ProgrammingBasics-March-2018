using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._2.SpecialCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int hundredsMax = int.Parse(Console.ReadLine());
            int tensMax = int.Parse(Console.ReadLine());
            int digitsMax = int.Parse(Console.ReadLine());

            bool isHundredsEven = true, isDigitsEven = true, isTensPrime = true;

            for (int i = 1; i <= hundredsMax; i++)
            {
                isHundredsEven = true;

                if (i % 2 == 1)
                {
                    isHundredsEven = false;
                }
                for (int j = 2; j <= tensMax; j++)
                {
                    isTensPrime = true;

                    for (int g = 2; g <= Math.Sqrt(j); g++)
                    {
                        if (j % g == 0)
                        {
                            isTensPrime = false;
                        }
                    }
                    for (int k = 1; k <= digitsMax; k++)
                    {
                        isDigitsEven = true;

                        if (k % 2 == 1)
                        {
                            isDigitsEven = false;
                        }


                        if (isHundredsEven && isTensPrime && isDigitsEven)
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }
        }
    }
}
