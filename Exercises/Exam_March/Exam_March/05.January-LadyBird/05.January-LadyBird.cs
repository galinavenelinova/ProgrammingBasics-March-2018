using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.January_LadyBird
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 2 * n + 1;
            char space = ' ';

            string spacesLeftRight = new string(space, (width - 5) / 2);
            Console.WriteLine("{0}@   @{0}", spacesLeftRight);

            spacesLeftRight = new string(space, (width - 3) / 2);
            string insideSymbols = "\\_/";

            for (int row = 0; row < 3; row++)
            {
                if (row == 1)
                {
                    insideSymbols = "/ \\";
                }
                else if (row == 2)
                {
                    insideSymbols = "|_|";
                }
            Console.WriteLine("{0}{1}{0}", spacesLeftRight, insideSymbols);
            }

            string spacesInside = "";
            for (int row = 0; row < n; row++)
            {
                spacesLeftRight = new string(space, (width - 3) / 2 - row);
                spacesInside = new string(space, row);
                Console.WriteLine("{0}/{1}|{1}\\{0}", spacesLeftRight, spacesInside);
            }

            for (int row = 0; row < n / 2; row++)
            {
                spacesLeftRight = new string(space, n / 2 - 1);
                spacesInside = new string(space, n - 2 - (n / 2 - 1));

                Console.WriteLine("|{0}@{1}|{1}@{0}|", spacesLeftRight, spacesInside);
            }

            for (int row = 0; row < n / 2; row++)
            {
                spacesLeftRight = new string(space, row);
                spacesInside = new string(space, (width - 3) / 2 - row);

                if (n > 2)
                {
                Console.WriteLine("{0}\\{1}|{1}/{0}", spacesLeftRight, spacesInside);
                }
            }

            int symbolsCountAtBottom = n / 2;
            string symbolsAtBottom = new string('^', symbolsCountAtBottom);
            spacesLeftRight = new string(space, n - symbolsCountAtBottom);
            Console.WriteLine("{0}{1}|{1}{0}", spacesLeftRight, symbolsAtBottom);
        }
    }
}
