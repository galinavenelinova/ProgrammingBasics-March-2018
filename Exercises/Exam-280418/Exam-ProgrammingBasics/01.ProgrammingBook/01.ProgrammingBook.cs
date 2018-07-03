using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ProgrammingBook
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricePage = double.Parse(Console.ReadLine());
            double priceFrontPage = double.Parse(Console.ReadLine());
            int percentDiscount = int.Parse(Console.ReadLine());
            double comissionDesigner = double.Parse(Console.ReadLine());
            int percentPaidByCrew = int.Parse(Console.ReadLine());

            double pricePrintingBook = pricePage * 899 + priceFrontPage * 2;
            double pricePrintingBookDiscounted = pricePrintingBook * (100 - percentDiscount) / 100;
            double totalPriceBook = pricePrintingBookDiscounted + comissionDesigner;
            double totalPriceToPay = totalPriceBook * (100 - percentPaidByCrew) / 100;

            Console.WriteLine($"Avtonom should pay {totalPriceToPay:f2} BGN.");
        }
    }
}
