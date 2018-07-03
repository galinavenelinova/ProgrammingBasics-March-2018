using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string kindOfFigure = Console.ReadLine();

            double area = 0;

            if (kindOfFigure == "square")
            {
                double a = double.Parse(Console.ReadLine());

                area = a * a;
            }
            if (kindOfFigure == "rectangle")
            {
                double length = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());

                area = length * width;
            }
            if (kindOfFigure == "circle")
            {
                double r = double.Parse(Console.ReadLine());

                area = Math.PI * r * r;
            }
            if (kindOfFigure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                area = side * height / 2;
            }

            Console.WriteLine(Math.Round(area, 3));
        }
    }
}
