using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AnualSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearsExperience = int.Parse(Console.ReadLine());
            string specialisation = Console.ReadLine();

            double monthSalary = 0;

            switch (specialisation)
            {
                case "C# Developer":
                    monthSalary = 5400; break;
                case "Java Developer":
                    monthSalary = 5700; break;
                case "Front-End Web Developer":
                    monthSalary = 4100; break;
                case "UX / UI Designer":
                    monthSalary = 3100; break;
                case "Game Designer":
                    monthSalary = 3600; break;
            } 

            if (yearsExperience <= 5)
            {
                monthSalary = monthSalary * (100 - 65.8) / 100;
            }

            double yearsSalary = monthSalary * 12;

            Console.WriteLine($"Total earned money: {yearsSalary:f2} BGN");
        }
    }
}
