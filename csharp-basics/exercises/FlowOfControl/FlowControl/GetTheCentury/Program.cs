using System;

namespace GetTheCentury
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type in a year and get the century: ");
            var userYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(GetTheCentury(userYear));
            Console.ReadKey();
        }

        static string GetTheCentury(int year)
        {
            string century = "";

            if (year > 2001)
            {
                century = "21st";
            }
            else if (year > 1900)
            {
                century = "20th";
            }
            else if (year > 1800)
            {
                century = "19th";
            }
            else if (year > 1700)
            {
                century = "18th";
            }
            else if (year > 1600)
            {
                century = "17th";
            }
            else if (year > 1500)
            {
                century = "16th";
            }
            else if (year > 1400)
            {
                century = "15th";
            }
            else if (year > 1300)
            {
                century = "14th";
            }
            else if (year > 1200)
            {
                century = "13th";
            }
            else if (year > 1100)
            {
                century = "12th";
            }
            else if (year > 1000)
            {
                century = "11th";
            }
            else
            {
                century = "10th";
            }

            return $"{century} century";
        }
    }
}
