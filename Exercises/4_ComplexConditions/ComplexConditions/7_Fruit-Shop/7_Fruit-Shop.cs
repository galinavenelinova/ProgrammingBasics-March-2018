using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //   плод banana  apple orange  grapefruit kiwi    pineapple grapes
            // цена    2.50    1.20    0.85    1.45    2.70    5.50    3.85

//            плод banana  apple orange  grapefruit kiwi    pineapple grapes
//          цена    2.70    1.25    0.90    1.60    3.00    5.60    4.20

            string fruit = Console.ReadLine().ToLower();
            string weekDay = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());

            if (weekDay == "monday" || weekDay == "tuesday" || weekDay == "wednesday" ||
                weekDay == "thursday" || weekDay == "friday")
            {
                if (fruit == "banana")
                {
                    Console.WriteLine(Math.Round((quantity * 2.50), 2));
                }
                else if (fruit == "apple")
                {
                    Console.WriteLine(Math.Round((quantity * 1.20), 2));
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine(Math.Round((quantity * 0.85), 2));
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine(Math.Round((quantity * 1.45), 2));
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine(Math.Round((quantity * 2.70), 2));
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine(Math.Round((quantity * 5.50), 2));
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine(Math.Round((quantity * 3.85), 2));
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (weekDay == "saturday" || weekDay == "sunday")
            {
                if (fruit == "banana")
                {
                    Console.WriteLine(Math.Round((quantity * 2.70), 2));
                }
                else if (fruit == "apple")
                {
                    Console.WriteLine(Math.Round((quantity * 1.25), 2));
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine(Math.Round((quantity * 0.90), 2));
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine(Math.Round((quantity * 1.60), 2));
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine(Math.Round((quantity * 3.00), 2));
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine(Math.Round((quantity * 5.60), 2));
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine(Math.Round((quantity * 4.20), 2));
                }
                else
                {
                    Console.WriteLine("error");
                }

            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
