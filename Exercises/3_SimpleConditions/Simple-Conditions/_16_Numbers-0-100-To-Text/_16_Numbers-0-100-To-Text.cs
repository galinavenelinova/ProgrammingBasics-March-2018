using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Numbers_0_100_To_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string word1 = "";
            string word2 = "";

            if (num == 0)
            {
                word2 = "zero";
            }
            else if (num == 10)
            {
                word2 = "ten";
            }
            else if (num == 11)
            {
                word2 = "eleven";
            }
            else if (num == 12)
            {
                word2 = "twelve";
            }
            else if (num == 13)
            {
                word2 = "thirteen";
            }
            else if (num == 14)
            {
                word2 = "fourteen";
            }
            else if (num == 15)
            {
                word2 = "fifteen";
            }
            else if (num == 16)
            {
                word2 = "sixteen";
            }
            else if (num == 17)
            {
                word2 = "seventeen";
            }
            else if (num == 18)
            {
                word2 = "eighteen";
            }
            else if (num == 19)
            {
                word2 = "nineteen";
            }
            else if (num == 100)
            {
                word1 = "one hundred";
            }
            else if (num % 10 == 1)
            {
                word2 = "one";
            }
            else if (num % 10 == 2)
            {
                word2 = "two";
            }
            else if (num % 10 == 3)
            {
                word2 = "three";
            }
            else if (num % 10 == 4)
            {
                word2 = "four";
            }
            else if (num % 10 == 5)
            {
                word2 = "five";
            }
            else if (num % 10 == 6)
            {
                word2 = "six";
            }
            else if (num % 10 == 7)
            {
                word2 = "seven";
            }
            else if (num % 10 == 8)
            {
                word2 = "eight";
            }
            else if (num % 10 == 9)
            {
                word2 = "nine";
            }

            if (num / 10 == 2)
            {
                word1 = "twenty";
            }
            if (num / 10 == 3)
            {
                word1 = "thirty";
            }
            if (num / 10 == 4)
            {
                word1 = "forty";
            }
            if (num / 10 == 5)
            {
                word1 = "fifty";
            }
            if (num / 10 == 6)
            {
                word1 = "sixty";
            }
            if (num / 10 == 7)
            {
                word1 = "seventy";
            }
            if (num / 10 == 8)
            {
                word1 = "eighty";
            }
            if (num / 10 == 9)
            {
                word1 = "ninety";
            }

            if (num > 100 || num < 0)
            {
                Console.WriteLine("invalid number");
            }
            else if (num > 19)
            {
                if (num % 10 == 0)
                {
                    Console.WriteLine(word1);
                }
                else
                {
                    Console.WriteLine(word1 + " " + word2);
                }
            }
            else
            {
                Console.WriteLine(word2);
            } 
        }
    }
}
