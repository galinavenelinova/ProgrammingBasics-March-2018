using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Smart_Lili
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washMachPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int toys = 0, money = 0, savedMoney = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 != 0)
                {
                    toys += 1;
                }
                else
                {
                    money += 10;
                    savedMoney += money - 1;
                }
            }
            savedMoney += toys * toyPrice;

            if (savedMoney >= washMachPrice)
            {
                Console.WriteLine("Yes! {0:f2}", savedMoney - washMachPrice);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", washMachPrice - savedMoney);
            }
        }
    }
}
