using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._1.Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int passengersCount = int.Parse(Console.ReadLine());
            int stopsCount = int.Parse(Console.ReadLine());

            for (int stop = 1; stop <= stopsCount; stop++)
            {
                int passengersGetOff = int.Parse(Console.ReadLine());
                int passengersGetOn = int.Parse(Console.ReadLine());

                if (stop % 2 == 1)
                {
                    passengersCount += 2;
                }
                else
                {
                    passengersCount -= 2;
                }

                passengersCount = passengersCount - passengersGetOff + passengersGetOn;
            }

            Console.WriteLine("The final number of passengers is : {0}", passengersCount);
        }
    }
}
