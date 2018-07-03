using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftRight = (n - 1) / 2;

            for (int row = 0; row < (n + 1) / 2; row++)
            {
                int mid = n - 2 * leftRight - 2;

                Console.Write("{0}", new string('-', leftRight));
                Console.Write("*");
                if (mid >= 0)
                {
                    Console.Write("{0}", new string('-', mid));
                    Console.Write("*");
                }
                Console.WriteLine("{0}", new string('-', leftRight));

                leftRight--;
            }

            leftRight = 1;

            for (int row = 0; row < (n - 1) / 2; row++)
            {
                int mid = n - 2 * leftRight - 2;

                Console.Write("{0}", new string('-', leftRight));
                Console.Write("*");
                if (mid >= 0)
                {
                    Console.Write("{0}", new string('-', mid));
                    Console.Write("*");
                }
                Console.WriteLine("{0}", new string('-', leftRight));

                leftRight++;
            }
        }
    }
}
