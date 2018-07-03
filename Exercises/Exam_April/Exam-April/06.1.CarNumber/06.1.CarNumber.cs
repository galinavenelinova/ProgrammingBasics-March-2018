using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._1.CarNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    for (int k = n; k <= m; k++)
                    {
                        for (int l = n; l <= m; l++)
                        {
                            if (i > l && (j + k) % 2 == 0 && (i + l) % 2 == 1)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
