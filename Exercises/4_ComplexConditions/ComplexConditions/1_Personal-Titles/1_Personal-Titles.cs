﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine().ToLower();

            if (age < 16)
            {
                if (gender == "f")
                {
                    Console.WriteLine("Miss");
                }
                else if (gender == "m")
                {
                    Console.WriteLine("Master");
                }
            }
            else
            {
                if (gender == "f")
                {
                    Console.WriteLine("Ms.");
                }
                else if (gender == "m")
                {
                    Console.WriteLine("Mr.");
                }
            }
        }
    }
}
