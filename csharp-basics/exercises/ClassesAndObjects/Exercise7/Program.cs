using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How much money is in the account?: ");
            SavingsAccount MyAccount = new SavingsAccount(Convert.ToDecimal(Console.ReadLine()));

            Console.Write("Enter the annual interest rate: ");
            decimal ANNUAL_INTEREST_RATE = Convert.ToDecimal(Console.ReadLine());

            Console.Write("How long has the account been opened: ");
            int months = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= months; i++)
            {
                Console.Write($"\nEnter amount deposited for month {i}: ");
                decimal deposit = Convert.ToDecimal(Console.ReadLine());
                MyAccount.Deposit(deposit);

                Console.Write($"Enter amount withdrawn for month {i}: ");
                decimal withdraw = Convert.ToDecimal(Console.ReadLine());
                MyAccount.Withdraw(withdraw);

                MyAccount.AddMonthlyInterest(ANNUAL_INTEREST_RATE);
            }

            Console.WriteLine($"\nTotal deposited: ${MyAccount.ReportDeposited()}");
            Console.WriteLine($"Total withdrawn: ${MyAccount.ReportWithdrawn()}");
            Console.WriteLine($"Interest earned: ${MyAccount.ReportInterestSum()}");
            Console.WriteLine($"Ending balance: ${MyAccount.ReportBalance()}");
        }
    }
}
