using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._2.Marguerita
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("'&${0}", new string('\'', 8 * n - 1));

            for (int row = 0; row < n - 1; row++)
            {
                Console.WriteLine("{0}\\{1}", new string('\'', row + 2), new string('\'', 8 * n - 1 - row));
            }

            for (int col = 0; col < (8 * n + 2) / 2 - 1; col++)
            {
                Console.Write("^");
                Console.Write("*");
            }
            Console.WriteLine("^'");

            for (int row = 0; row < n - 1; row++)
            {
                Console.WriteLine("{0}\\\\{1}\\{2}//{3}", new string('\'', row), new string(' ', n), 
                    new string(' ', 6 * n - 1 + n - 3 - row * 2), new string('\'', row + 1));
            }

            Console.WriteLine("{0}\\{1}/{2}", new string('\'', n - 1), new string('~', 6 * n + 1), new string('\'', n));

            for (int row = 0; row < n - 2; row++)
            {
                Console.WriteLine("{0}\\{1}/{2}", new string('\'', n + row), new string(' ', 6 * n - 1 - 2 * row), new string('\'', n + row + 1));
            }

            Console.WriteLine("{0}\\{1}/{2}", new string('\'', 2 * n - 2), new string('_', 4 * n + 3), new string('\'', 2 * n - 1));
            Console.WriteLine("{0}\\{1}/{2}", new string('\'', 2 * n - 1), new string('.', 4 * n + 1), new string('\'', 2 * n));

            for (int row = 0; row < 2 * n - 1; row++)
            {
                if (row == 2 * n - 2)
                {
                    Console.WriteLine("{0}\\{1}/{2}", new string('\'', 2 * n + row), new string('_', 4 * n - 1 - 2 * row), new string('\'', 2 * n + row + 1));
                }
                else
                {
                Console.WriteLine("{0}\\{1}/{2}", new string('\'', 2 * n + row), new string(' ', 4 * n - 1 - 2 * row), new string('\'', 2 * n + row + 1));
                }
            }

            for (int row = 0; row < 2 * n + 1; row++)
            {
                Console.WriteLine("{0}|||{0}\'", new string('\'', (8 * n - 2) / 2));
            }

            Console.WriteLine("{0}\'", new string('_', 8 * n + 1));
            Console.WriteLine("\'{0}\''", new string('-', 8 * n - 1));
        }
    }
}
