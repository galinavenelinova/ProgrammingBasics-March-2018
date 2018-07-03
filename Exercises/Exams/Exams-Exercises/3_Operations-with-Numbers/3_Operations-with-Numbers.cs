using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Operations_with_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string oper = Console.ReadLine();

            string evenOrOdd = "odd";
            double result = 0;

            if (oper == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    result = num1 * 1.0 / num2;
                    Console.WriteLine($"{num1} / {num2} = {result:f2}");
                }
            }
            else if (oper == "%")
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    result = num1 % num2;
                    Console.WriteLine($"{num1} % {num2} = {result}");
                }
            }
            else
            {
                if (oper == "+")
                {
                    result = num1 + num2;
                }
                else if (oper == "-")
                {
                    result = num1 - num2;
                }
                else if (oper == "*")
                {
                    result = num1 * num2;
                }

                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }

                Console.WriteLine($"{num1} {oper} {num2} = {result} - {evenOrOdd}");
            }
        }
    }
}
