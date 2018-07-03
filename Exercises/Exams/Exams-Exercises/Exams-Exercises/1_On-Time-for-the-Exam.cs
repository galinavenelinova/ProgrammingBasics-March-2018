using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourOfExam = int.Parse(Console.ReadLine());
            int minuteOfExam = int.Parse(Console.ReadLine());
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minuteOfArrival = int.Parse(Console.ReadLine());

            int hAndMExam = hourOfExam * 60 + minuteOfExam;
            int hAndMArrival = hourOfArrival * 60 + minuteOfArrival;

            if (hAndMArrival > hAndMExam)
            {
                Console.WriteLine("Late");

                if (hAndMArrival - hAndMExam < 60)
                {
                    Console.WriteLine("{0} minutes after the start", hAndMArrival - hAndMExam);
                }
                else
                {
                    Console.WriteLine("{0}:{1:d2} hours after the start", 
                        (hAndMArrival - hAndMExam) / 60, (hAndMArrival - hAndMExam) % 60);
                }
            }
            else if (hAndMExam - hAndMArrival <= 30)
            {
                Console.WriteLine("On Time");
                if (hAndMExam != hAndMArrival)
                {
                    Console.WriteLine("{0} minutes before the start", hAndMExam - hAndMArrival);
                }
            }
            else
            {
                Console.WriteLine("Early");
                if (hAndMExam - hAndMArrival < 60)
                {
                    Console.WriteLine("{0} minutes before the start", hAndMExam - hAndMArrival);
                }
                else
                {
                    Console.WriteLine("{0}:{1:d2} hours before the start",
                        (hAndMExam - hAndMArrival) / 60, (hAndMExam - hAndMArrival) % 60);
                }
            }
        }
    }
}
