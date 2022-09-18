using System;

namespace VendingMachine.Exceptions
{
    public class InvalidMoneyException : Exception
    {
        public InvalidMoneyException()
            : base("You can't put these coins in this vending machine!") { }
    }
}
