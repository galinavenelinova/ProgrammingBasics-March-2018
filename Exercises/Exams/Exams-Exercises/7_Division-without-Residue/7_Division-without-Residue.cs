using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Division_without_Residue
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0, p2 = 0, p3 = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                    p1 += 1;
                if (num % 3 == 0)
                    p2 += 1;
                if (num % 4 == 0)
                    p3 += 1;

            }

            Console.WriteLine("{0:f2}%", p1 * 100 / n);
            Console.WriteLine("{0:f2}%", p2 * 100 / n);
            Console.WriteLine("{0:f2}%", p3 * 100 / n);
        }
    }
}
