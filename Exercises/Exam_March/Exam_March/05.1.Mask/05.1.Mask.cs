using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._1.Mask
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n - 1; row++)
            {
                Console.WriteLine("{0}/{1}|  |{1}\\{0}", new string(' ', n - 2 - row), new string(' ', row));
            }
            Console.WriteLine(new string('-', 2 * n + 2));
            Console.WriteLine("|{0}_{1}_{0}|", new string(' ', n / 2 - 1), new string(' ', (2 * n - 2 - 2 * (n / 2 - 1))));
            Console.WriteLine("|{0}@{1}@{0}|", new string(' ', n / 2 - 1), new string(' ', (2 * n - 2 - 2 * (n / 2 - 1))));

            for (int row = 1; row <= n/2; row++)
            {
                Console.WriteLine("|{0}|", new string(' ', 2 * n));
            }

            Console.WriteLine("|{0}OO{0}|", new string(' ', (2 * n - 2) / 2));
            Console.WriteLine("|{0}/  \\{0}|", new string(' ', (2 * n - 4) / 2));
            Console.WriteLine("|{0}||||{0}|", new string(' ', (2 * n - 4) / 2));

            for (int row = 0; row < n + 1; row++)
            {
                Console.WriteLine("{0}{1}{2}", new string('\\', row + 1), new string('`', 2 * n - row * 2), new string('/', row + 1));
            }
        }
    }
}
