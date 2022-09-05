using System;

namespace VendingMachine.Exceptions
{
    public class InvalidPriceException : Exception
    {
        public InvalidPriceException()
            : base("Nothing in life is for free!") { }
    }
}
