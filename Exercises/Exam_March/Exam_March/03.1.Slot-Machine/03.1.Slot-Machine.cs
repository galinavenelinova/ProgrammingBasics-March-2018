using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._1.Slot_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            char n = char.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());
            char m = char.Parse(Console.ReadLine());
            int m1 = int.Parse(Console.ReadLine());
            char k = char.Parse(Console.ReadLine());
            int k1 = int.Parse(Console.ReadLine());

            int sum1 = (int)n + n1;
            int sum2 = (int)m + m1;
            int sum3 = (int)k + k1;

            if (sum1 == 55 && sum2 == 55 && sum3 == 55)
            {
                Console.WriteLine("777\n*** JACKPOT ***");
            }
            else if (sum1 == 64 && sum2 == 64 && sum3 == 64)
            {
                Console.WriteLine("@@@\n!!! YOU LOSE EVERYTHING !!!");
            }
            else
            {
                Console.WriteLine($"{(char)sum1}{(char)sum2}{(char)sum3}");
            }
        }
    }
}
