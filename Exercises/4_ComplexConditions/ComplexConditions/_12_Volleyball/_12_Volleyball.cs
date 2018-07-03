using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Volleyball
{
    class _12_Volleyball
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine().ToLower();
            int holidays = int.Parse(Console.ReadLine());
            int weekendsAtHomeTown = int.Parse(Console.ReadLine());

            double games = (48 - weekendsAtHomeTown) * 3.0 / 4 + weekendsAtHomeTown + holidays * 2.0 / 3;

            if (yearType == "leap")
            {
                games = 1.15 * games;
            }

            Console.WriteLine(Math.Truncate(games));
        }
    }
}
