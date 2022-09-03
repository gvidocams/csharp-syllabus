using System;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            var VendingMachine = new VendingMachine("LG");

            Console.WriteLine(VendingMachine.HasProducts);
            
            var Change = new Money();
            Change.Euros = 5;
            Change.Cents = 25;

            VendingMachine.AddProduct("Chocolate", Change, 12);

            Console.WriteLine(VendingMachine.HasProducts);

            Console.ReadKey();
            */
            // int policyDays = (validTill - entry.Value).Days;
            /*
            var date1 = DateTime.Now.AddMinutes(-4);
            DateTime? date2 = null;
            DateTime date3;
            if(date2.HasValue)
            {
                date3 = (DateTime)date2;
            }
            else
            {
                date3 = DateTime.Now;
            }

            var minutes = (date3 - date1).TotalMinutes;
            */

            var remaining = 1440 - DateTime.Now.TimeOfDay.TotalMinutes;

            Console.WriteLine(remaining);
            Console.ReadKey();
        }
    }
}
