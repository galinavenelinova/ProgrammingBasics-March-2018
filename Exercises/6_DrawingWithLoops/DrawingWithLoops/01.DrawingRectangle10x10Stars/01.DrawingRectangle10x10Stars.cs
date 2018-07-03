using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DrawingRectangle10x10Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                string stars = new string('*', 10);
                Console.WriteLine(stars);
            }
        }
    }
}
