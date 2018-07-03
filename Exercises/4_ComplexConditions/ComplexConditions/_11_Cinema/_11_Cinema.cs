using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Cinema
{
    class _11_Cinema
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine().ToLower();
            int lines = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double price = 5;

            if (projection == "premiere")
            {
                price = 12;
            }
            else if (projection == "normal")
            {
                price = 7.5;
            }

            double result = lines * columns * price;

            Console.WriteLine($"{result:f2} leva");

        }
    }
}
