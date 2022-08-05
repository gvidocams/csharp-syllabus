using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WeekdayInDutch(1970, 9, 21));
            Console.WriteLine(WeekdayInDutch(1945, 9, 2));
            Console.WriteLine(WeekdayInDutch(2001, 9, 11));
        }

        static string WeekdayInDutch(int year, int month, int day)
        {
            var cultureInfo = new CultureInfo("nl-NL");
            DateTime date = new DateTime(year, month, day);

            return cultureInfo.DateTimeFormat.GetDayName(date.DayOfWeek);
        }
    }
}
