using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("How much money is in the account?: ");
            SavingsAccount MyAccount = new SavingsAccount(Convert.ToDecimal(Console.ReadLine()));

            Console.Write("Enter the annual interest rate: ");
            decimal _annualInterestRate = Convert.ToDecimal(Console.ReadLine());

            Console.Write("How long has the account been opened: ");
            int months = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= months; i++)
            {
                MyAccount.Deposit(HowMuchDeposited(i));

                MyAccount.Withdraw(HowMuchWithdrawn(i));

                MyAccount.AddMonthlyInterest(_annualInterestRate);
            }

            Console.WriteLine($"\nTotal deposited: ${MyAccount.ReportDeposited()}");
            Console.WriteLine($"Total withdrawn: ${MyAccount.ReportWithdrawn()}");
            Console.WriteLine($"Interest earned: ${MyAccount.ReportInterestSum()}");
            Console.WriteLine($"Ending balance: ${MyAccount.ReportBalance()}");
        }

        static decimal HowMuchDeposited(int month)
        {
            Console.Write($"\nEnter amount deposited for month {month}: ");
            decimal deposit = Convert.ToDecimal(Console.ReadLine());

            return deposit;
        }

        static decimal HowMuchWithdrawn(int month)
        {
            Console.Write($"Enter amount withdrawn for month {month}: ");
            decimal withdraw = Convert.ToDecimal(Console.ReadLine());

            return withdraw;
        }
    }
}
