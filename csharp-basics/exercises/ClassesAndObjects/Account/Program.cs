using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            Account bartosAccount = new Account("Barto's account", 100.00);
            Account bartosSwissAccount = new Account("Barto's account in Switzerland", 1000000.00);
            
            Console.WriteLine("###First Program");
            Console.WriteLine("Initial state");
            Console.WriteLine(bartosAccount);
            Console.WriteLine(bartosSwissAccount);

            bartosAccount.Withdrawal(20);
            Console.WriteLine("Barto's account balance is now: " + bartosAccount.Balance());
            bartosSwissAccount.Deposit(200);
            Console.WriteLine("Barto's Swiss account balance is now: " + bartosSwissAccount.Balance());

            Console.WriteLine("\nFinal state");
            Console.WriteLine(bartosAccount);
            Console.WriteLine(bartosSwissAccount);

            Console.WriteLine("\n###Your first account");
            Console.WriteLine("\nInitial state");

            Account Gvido = new Account("Gvido", 20);

            Console.WriteLine(Gvido);

            Console.WriteLine("\nAfter deposit");

            Gvido.Deposit(20);

            Console.WriteLine(Gvido);

            Console.WriteLine("\n###Your first money transfer");
            Console.WriteLine("\nInitial state");

            Account MattsAccount = new Account("Matt", 1000);
            Account GvidoAccount = new Account("Gvido", 0);

            Console.WriteLine(MattsAccount);
            Console.WriteLine(GvidoAccount);

            Console.WriteLine("After transfer");

            MattsAccount.Withdrawal(100);
            GvidoAccount.Deposit(100);

            Console.WriteLine(MattsAccount);
            Console.WriteLine(GvidoAccount);

            Console.WriteLine("\n###Money transfers");
            Console.WriteLine("\nInitial state");

            Account A = new Account("A", 100);
            Account B = new Account("B", 0);
            Account C = new Account("C", 0);

            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);

            Transfer(A, B, 50);
            Transfer(B, C, 25);

            Console.WriteLine("\nAfter transfers");

            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
        }

        public static void Transfer(Account from, Account to, double howMuch)
        {
            to.Deposit(from.Withdrawal(howMuch));
        }
    }
}
