using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.EiffelTower
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 2 * n + 6;

            char dash = '-';
            char star = '*';

            for (int row = 0; row < n; row++)
            {
                Console.WriteLine("{0}{1}{0}", new string(dash, (width - 2) / 2), new string(star, 2));
            }

            for (int row = 0; row < n - 3; row++)
            {
                Console.WriteLine("{0}{1}{0}", new string(dash, (width - 4) / 2), new string(star, 4));
            }

            Console.WriteLine("{0}{1}{0}", new string(dash, (width - 6) / 2), new string(star, 6));

            for (int row = 0; row < n - 4; row++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string(dash, (width - 6) / 2), new string(star, 2), new string(dash, 2));
            }

            for (int row = 0; row < n - 3; row++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string(dash, (width - 8) / 2), new string(star, 2), new string(dash, 4));
            }

            Console.WriteLine("{0}{1}{0}", new string(dash, (width - 10) / 2), new string(star, 10));

            for (int row = 0; row < n - 3; row++)
            {
                int leftRightDashes = (width - 12) / 2 - row;
                int insideDashes = 8 + 2 * row;
                Console.WriteLine("{0}{1}{2}{1}{0}", new string(dash, leftRightDashes), new string(star, 2), new string(dash, insideDashes));
            }

            Console.WriteLine("{0}{1}{0}", new string(star, 3), new string(dash, width - 6));
        }
    }
}
