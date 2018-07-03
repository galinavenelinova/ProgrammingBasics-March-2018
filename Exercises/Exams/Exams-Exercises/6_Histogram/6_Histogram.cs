using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                    p1 += 1;
                else if (num <= 399)
                    p2 += 1;
                else if (num <= 599)
                    p3 += 1;
                else if (num <= 799)
                    p4 += 1;
                else if (num >= 800)
                    p5 += 1;
            }

            Console.WriteLine("{0:f2}%", p1 * 1.0 * 100 / n);
            Console.WriteLine("{0:f2}%", p2 * 1.0 * 100 / n);
            Console.WriteLine("{0:f2}%", p3 * 1.0 * 100 / n);
            Console.WriteLine("{0:f2}%", p4 * 1.0 * 100 / n);
            Console.WriteLine("{0:f2}%", p5 * 1.0 * 100 / n);
        }
    }
}
