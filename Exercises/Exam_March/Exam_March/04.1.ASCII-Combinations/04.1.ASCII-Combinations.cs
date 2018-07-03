using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._1.ASCII_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int digitsSum = 0, smallLettersSum = 0, capitalLettersSum = 0, otherSymbolsSum = 0;
            int biggestSum = 0;

            string digitsComb = "", smallLettersComb = "", capitalLettersComb = "", otherSymbolsComb = "";

            for (int i = 0; i < n; i++)
            {
                char input = char.Parse(Console.ReadLine());
                int charNumber = (int)input;

                if (charNumber >= 48 && charNumber <= 57)
                {
                    digitsSum += charNumber;
                    digitsComb += (char)charNumber;
                }
                else if (charNumber >= 65 && charNumber <= 90)
                {
                    capitalLettersSum += charNumber;
                    capitalLettersComb += (char)charNumber;
                }
                else if (charNumber >= 97 && charNumber <= 122)
                {
                    smallLettersSum += charNumber;
                    smallLettersComb += (char)charNumber;
                }
                else
                {
                    otherSymbolsSum += charNumber;
                    otherSymbolsComb += (char)charNumber;
                }
            }

            biggestSum = Math.Max(Math.Max(digitsSum, smallLettersSum), Math.Max(capitalLettersSum, otherSymbolsSum));

            Console.WriteLine("Biggest ASCII sum is:{0}", biggestSum);

            string combWithBiggestSum = "";

            
            if (biggestSum == digitsSum)
            {
                combWithBiggestSum = digitsComb;
            }
            else if (biggestSum == capitalLettersSum)
            {
                combWithBiggestSum = capitalLettersComb;
            }
            else if (biggestSum == smallLettersSum)
            {
                combWithBiggestSum = smallLettersComb;
            }
            else if (biggestSum == otherSymbolsSum)
            {
                combWithBiggestSum = otherSymbolsComb;
            }

            Console.WriteLine("Combination of characters is:{0}", combWithBiggestSum);
        }
    }
}
