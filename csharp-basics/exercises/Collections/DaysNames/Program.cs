using System;
using System.Linq;
using System.Collections;

namespace DaysNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dayInNumbers = { 0, 1, 2, 3, 4, 5, 6 };

            IEnumerable<string> daysNames =
                from number in dayInNumbers
                select (Enum.GetName(typeof(DayOfWeek), number));
            
            Console.WriteLine(String.Join(' ', daysNames));
            Console.ReadKey();
        }
    }
}
