﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Point_in_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool isXInRange = x >= x1 && x <= x2;
            bool isYInRange = y >= y1 && y <= y2;

            if (isXInRange && isYInRange)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }

        }
    }
}
