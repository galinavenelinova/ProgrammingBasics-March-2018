﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int maxNumber = num1;

            if (num2 > num1)
            {
                maxNumber = num2;
            }

            Console.WriteLine(maxNumber);
        }
    }
}
