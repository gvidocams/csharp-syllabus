using VendingMachine.Exceptions;

namespace VendingMachine
{
    public class Validate
    {
        public static void Price(Money price)
        {
            if (price.Euros == 0 && price.Cents == 0)
            {
                throw new InvalidPriceException();
            }
        }
    }
}
