using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    public class SavingsAccount
    {
        decimal balance;
        decimal withdrawn;
        decimal deposited;
        decimal interestSum;

        public SavingsAccount(decimal startingBalance)
        {
            this.balance = startingBalance;
            this.withdrawn = 0;
            this.deposited = 0;
            this.interestSum = 0;
        }

        public decimal ReportBalance()
        {
            return Math.Round(this.balance, 2);
        }

        public decimal ReportWithdrawn()
        {
            return Math.Round(this.withdrawn, 2);
        }

        public decimal ReportDeposited()
        {
            return Math.Round(this.deposited, 2);
        }

        public decimal ReportInterestSum()
        {
            return Math.Round(this.interestSum, 2);
        }

        public void Withdraw(decimal balanceToWithdraw)
        {
            this.balance -= balanceToWithdraw;
            this.withdrawn += balanceToWithdraw;
        }

        public void Deposit(decimal balanceToDeposit)
        {
            this.balance += balanceToDeposit;
            this.deposited += balanceToDeposit;
        }

        public void AddMonthlyInterest(decimal annualInterest)
        {
            this.interestSum += this.balance * (annualInterest / 12);
            this.balance += this.balance * (annualInterest / 12);
        }
    }
}
