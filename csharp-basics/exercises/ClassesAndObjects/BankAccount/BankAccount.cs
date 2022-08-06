using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BankAccount
{
    public class BankAccount
    {
        string name;
        decimal balance;
        CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");

        public BankAccount(string name, decimal balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public string ShowUserNameAndBalance()
        {
            return $"{this.name}, {this.FormatBalance()}";
        }

        public string FormatBalance()
        {
            if(this.balance > 0)
            {
                return $"-{this.balance.ToString("C", culture)}";
            }
            else
            {
                return this.balance.ToString("C", culture);
            }
        }
    }
}
