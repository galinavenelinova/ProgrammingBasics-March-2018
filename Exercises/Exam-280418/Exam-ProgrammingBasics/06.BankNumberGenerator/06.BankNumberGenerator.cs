using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BankNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            char d = char.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            int validNumbersCount = 0;

            for (int num1 = a; num1 <= 99; num1++)
            {
                for (int capitalLetter1 = b; capitalLetter1 <= 'Z'; capitalLetter1++)
                {
                    for (int smallLetter = c; smallLetter <= 'z'; smallLetter++)
                    {
                        for (int capitalLetter2 = d; capitalLetter2 <= 'Z'; capitalLetter2++)
                        {
                            for (int num2 = e; num2 >= 10; num2--)
                            {
                                if (num1 % 10 == 2 && num2 % 10 == 5)
                                {
                                    validNumbersCount += 1;
                                }

                                if (validNumbersCount == N)
                                {
                                    Console.WriteLine($"{num1}{(char)capitalLetter1}{(char)smallLetter}{(char)capitalLetter2}{num2}");
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
