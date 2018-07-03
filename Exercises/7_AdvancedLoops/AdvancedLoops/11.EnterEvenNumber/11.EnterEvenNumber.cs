using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;

            while (true)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid number!");
                    continue;
                }

                if (n % 2 == 0)
                {
                    Console.WriteLine("Even number entered: {0}", n);
                    break;
                }
                else if (n % 2 == 1)
                {
                    Console.WriteLine("The number is not even.");
                }
            }
        }
    }
}
