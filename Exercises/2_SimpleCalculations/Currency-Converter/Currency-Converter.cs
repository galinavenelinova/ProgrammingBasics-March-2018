using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();

            double result = 0;

            if (input == "BGN") 
            {   if (output == "USD")
                {
                    result = a / 1.79549;
                }
                if (output == "EUR")
                {
                    result = a / 1.95583;
                }
                if (output == "GBP")
                {
                    result = a / 2.53405;
                }

            }

            if (input == "USD")
            {
                if (output == "BGN")
                {
                    result = a * 1.79549;
                }
                if (output == "EUR")
                {
                    result = a * 1.79549 / 1.95583;
                }
                if (output == "GBP")
                {
                    result = a * 1.79549 / 2.53405;
                }

            }

            if (input == "EUR")
            {
                if (output == "USD")
                {
                    result = a * 1.95583 / 1.79549;
                }
                if (output == "BGN")
                {
                    result = a * 1.95583;
                }
                if (output == "GBP")
                {
                    result = a * 1.95583 / 2.53405;
                }

            }

            if (input == "GBP")
            {
                if (output == "USD")
                {
                    result = a * 2.53405 / 1.79549;
                }
                if (output == "BGN")
                {
                    result = a * 2.53405;
                }
                if (output == "EUR")
                {
                    result = a * 2.53405 / 1.95583;
                }

            }

            Console.WriteLine($"{Math.Round(result, 2)} {output}");

        }
    }
}
