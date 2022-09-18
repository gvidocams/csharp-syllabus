using System;

namespace VendingMachine.Exceptions
{
    public class InvalidProductNumberException : Exception
    {
        public InvalidProductNumberException()
            : base("Invalid product number!") { }
    }
}
