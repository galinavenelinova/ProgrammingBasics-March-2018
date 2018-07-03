using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool isXInRect1 = x >= 0 && x <= 3 * h;
            bool isYInRect1 = y >= 0 && y <= h;
            bool isXInRect2 = x >= h && x <= 2 * h;
            bool isYInRect2 = y >= h && y <= 4 * h;

            bool isXOnBorder1 = (x == 0) || (x == 3 * h);
            bool isYOnBorder1 = (y == 0) || (y == h);
            bool isXOnBorder2 = (x == h) || (x == 2 * h);
            bool isYOnBorder2 = (y == h) || (y == 4 * h);

            if ((isXOnBorder1 && isYInRect1) || 
               (isYOnBorder1 && isXInRect1) || 
               (isXOnBorder2 && isYInRect2) ||
               (isYOnBorder2 && isXInRect2))
            {
                if (y == h && x > h && x < 2 * h)
                {
                    Console.WriteLine("inside");
                }
                else
                {
                    Console.WriteLine("border");
                }
            }
            else if ((isXInRect1 && isYInRect1) || (isXInRect2 && isYInRect2))
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
