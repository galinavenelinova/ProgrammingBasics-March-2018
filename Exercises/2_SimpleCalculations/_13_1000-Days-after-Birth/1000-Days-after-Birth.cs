using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _13_1000_Days_after_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            string birth = Console.ReadLine();
            DateTime input = DateTime.ParseExact(birth, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime output = input.AddDays(999);

            Console.WriteLine(output.ToString("dd-MM-yyyy"));
        }
    }
}
