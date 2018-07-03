using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());

            double bonus = 0;

            if (score > 1000)
            {
                bonus += score * 0.1;
            }
            else if (score > 100)
            {
                bonus += score * 0.2;
            }
            else if (score <= 100)
            {
                bonus += 5;
            }

            if (score % 2 == 0)
            {
                bonus++;
            }
            else if (score % 10 == 5)
            {
                bonus += 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(score + bonus);
        }
    }
}
