using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();

            int overnights = int.Parse(Console.ReadLine());

            double studioPerNight = 50;
            double appartmentPerNight = 65;

            if (month == "june" || month == "september")
            {
                studioPerNight = 75.2;
                appartmentPerNight = 68.7;
            }
            else if (month == "july" || month == "august")
            {
                studioPerNight = 76;
                appartmentPerNight = 77;
            }

            double studioPrice = studioPerNight * overnights;
            double appartmentPrice = appartmentPerNight * overnights;

            if (overnights > 14)
            {
                if (month == "may" || month == "october")
                {
                    studioPrice -= 0.3 * studioPrice;
                }
                else if (month == "june" || month == "september")
                {
                    studioPrice -= 0.2 * studioPrice;
                }

                appartmentPrice -= 0.1 * appartmentPrice;
            }
            else if (overnights > 7)
            {
                if (month == "may" || month == "october")
                {
                    studioPrice -= 0.05 * studioPrice;
                }
            }

            Console.WriteLine($"Apartment: {appartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}
