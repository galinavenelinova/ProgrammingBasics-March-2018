﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double size = double.Parse(Console.ReadLine());
            string inputMetric = Console.ReadLine().ToLower();
            string outputMetric = Console.ReadLine().ToLower();

            if (inputMetric == "mm")
            {
                size = size / 1000;
            }
            else if (inputMetric == "cm")
            {
                size = size / 100;
            }
            else if (inputMetric == "mi")
            {
                size = size / 0.000621371192;
            }
            else if (inputMetric == "in")
            {
                size = size / 39.3700787;
            }
            else if (inputMetric == "km")
            {
                size = size / 0.001;
            }
            else if (inputMetric == "ft")
            {
                size = size / 3.2808399;
            }
            else if (inputMetric == "yd")
            {
                size = size / 1.0936133;
            }

            if (outputMetric == "mm")
            {
                size = size * 1000;
            }
            else if (outputMetric == "cm")
            {
                size = size * 100;
            }
            else if (outputMetric == "mi")
            {
                size = size * 0.000621371192;
            }
            else if (outputMetric == "in")
            {
                size = size * 39.3700787;
            }
            else if (outputMetric == "km")
            {
                size = size * 0.001;
            }
            else if (outputMetric == "ft")
            {
                size = size * 3.2808399;
            }
            else if (outputMetric == "yd")
            {
                size = size * 1.0936133;
            }

            Console.WriteLine(Math.Round(size,8));
        }
    }
}
