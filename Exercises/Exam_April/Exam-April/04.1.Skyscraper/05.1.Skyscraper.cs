using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._1.Skyscraper
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n - 3; row++)
            {
                Console.WriteLine("{0}|{0}", new string(' ', n));
            }
            Console.WriteLine("{0}_|_{0}", new string(' ', n - 1));

            for (int row = 0; row < n - 3; row++)
            {
                Console.WriteLine("{0}|-|{0}", new string(' ', n - 1));
            }
            Console.WriteLine("{0}_|-|_{0}", new string(' ', n - 2));

            for (int row = 0; row < n - 3; row++)
            {
                Console.WriteLine("{0}|***|{0}", new string(' ', n - 2));
            }
            Console.WriteLine(" {0}|***|{0} ", new string('_', n - 3));

            for (int row = 0; row < 4 * n - 1; row++)
            {
                Console.WriteLine(" {0}---{0}", new string('|', n - 2));
            }
            Console.WriteLine("_{0}---{0}_", new string('|', n - 2));

            for (int row = 0; row < n - 2; row++)
            {
                Console.WriteLine("{0}", new string('|', 2 * n + 1));
            }
        }
    }
}
