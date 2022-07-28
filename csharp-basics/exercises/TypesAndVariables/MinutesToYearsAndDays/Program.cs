using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinutesToYearsAndDays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convert minutes into years and days.\n");

            Console.Write("How many minutes: ");
            long userInput = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine(GetYearsAndDays(userInput));
        }

        static string GetYearsAndDays(long minutes)
        {
            const int daysInAYear = 365;
            int years = 0;

            TimeSpan time = TimeSpan.FromMinutes(minutes);
            int days = time.Days;

            while(days >= daysInAYear)
            {
                years++;
                days -= daysInAYear;
            }

            return $"{years} years and {days} days";
        }
    }
}
