using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._1.Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double lengthSpaceship = double.Parse(Console.ReadLine());
            double widthSpaceship = double.Parse(Console.ReadLine());
            double heightSpaceship = double.Parse(Console.ReadLine());
            double peopleHeight = double.Parse(Console.ReadLine());

            double volumeSpaceship = lengthSpaceship * widthSpaceship * heightSpaceship;
            double volumeRoom = (peopleHeight + 0.4) * 2 * 2;

            int astronautsCount = (int)(volumeSpaceship / volumeRoom);

            if (astronautsCount < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (astronautsCount > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
            else
            {
                Console.WriteLine($"The spacecraft holds {astronautsCount} astronauts.");
            }
        }
    }
}
