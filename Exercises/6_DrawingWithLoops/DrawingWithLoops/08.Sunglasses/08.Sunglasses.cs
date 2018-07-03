using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}", new string('*', 2 * n), new string (' ', n));

            for (int row = 0; row < n-2; row++)
            {
                string symbols = new string('/', 2 * n - 2);
                Console.Write("*" + symbols + "*");
                if (row == (n - 1) / 2 - 1)
                    Console.Write("{0}", new string('|', n));
                else
                    Console.Write("{0}", new string(' ', n));
                Console.WriteLine("*" + symbols + "*");
            }

            Console.WriteLine("{0}{1}{0}", new string('*', 2 * n), new string(' ', n));
        }
    }
}
