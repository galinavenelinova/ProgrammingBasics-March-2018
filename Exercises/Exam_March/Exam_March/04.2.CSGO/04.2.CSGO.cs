using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._2.CSGO
{
    class Program
    {
        static void Main(string[] args)
        {
            int weaponCount = int.Parse(Console.ReadLine());
            int money = int.Parse(Console.ReadLine());

            int weaponPrice = 0, totalExpense = 0;

            if (weaponCount > 7)
            {
                Console.WriteLine("Sorry, you can't carry so many things!");
            }
            else
            {
                for (int i = 0; i < weaponCount; i++)
                {
                    string weaponType = Console.ReadLine();

                    switch (weaponType)
                    {
                        case "ak47":
                            weaponPrice = 2700; break;
                        case "awp":
                            weaponPrice = 4750; break;
                        case "sg553":
                            weaponPrice = 3500; break;
                        case "grenade":
                            weaponPrice = 300; break;
                        case "flash":
                            weaponPrice = 250; break;
                        case "glock":
                            weaponPrice = 500; break;
                        case "bazooka":
                            weaponPrice = 5600; break;
                        default:
                            break;
                    }

                    totalExpense += weaponPrice;
                }

                if (money >= totalExpense)
                {
                    Console.WriteLine($"You bought all {weaponCount} items! Get to work and defeat the bomb!");
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0} more money.", totalExpense - money);
                }
            }
        }
    }
}
