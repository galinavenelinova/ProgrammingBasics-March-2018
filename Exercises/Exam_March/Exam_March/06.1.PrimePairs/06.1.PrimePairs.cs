using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._1.PrimePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n12 = int.Parse(Console.ReadLine());
            int n34 = int.Parse(Console.ReadLine());
            int m12 = int.Parse(Console.ReadLine());
            int m34 = int.Parse(Console.ReadLine());

            bool is12Prime = true, is34Prime = true;

            for (int i = n12; i <= n12 + m12; i++)
            {
                is12Prime = true;

                for (int j = n34; j <= n34 + m34; j++)
                {
                    is34Prime = true;

                    for (int k = 2; k <= Math.Sqrt(i); k++)
                    {
                        if (i % k == 0)
                        {
                            is12Prime = false;
                           
                        }
                    }

                    for (int l = 2; l <= Math.Sqrt(j); l++)
                    {
                        if (j % l == 0)
                        {
                            is34Prime = false;
                            
                        }
                    }


                    if (is12Prime && is34Prime)
                    {
                        Console.WriteLine($"{i}{j} ");
                    }
                }
            }
        }
    }
}
