using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int starsCount = 1;
            int dashesCount = n / 2;

            if (n % 2 == 0)
            {
                starsCount = 2;
                dashesCount = n / 2 - 1;
            }

            for (int row = 1; row <= (n + 1) / 2; row++)
            {
                Console.WriteLine("{0}{1}{0}", new string('-', dashesCount), new string('*', starsCount));
                starsCount += 2;
                dashesCount -= 1;
            }

            for (int row = 0; row < n / 2; row++)
            {
                Console.Write("|");
                Console.Write("{0}", new string('*', n - 2));
                Console.WriteLine("|");
            }
        }
    }
}
