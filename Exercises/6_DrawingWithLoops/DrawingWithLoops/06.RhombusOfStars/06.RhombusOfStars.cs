using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                Console.Write("{0}{1}", new string(' ', n-row), new string('*', 1));
                for (int col = 0; col < row-1; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

            for (int row = 1; row <= n-1; row++)
            {
                Console.Write("{0}{1}", new string(' ', row), new string('*', 1));
                for (int col = 0; col < n - row - 1; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
