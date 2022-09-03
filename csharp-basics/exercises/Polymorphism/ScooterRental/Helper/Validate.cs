using ScooterRental.Exceptions;

namespace ScooterRental.Helper
{
    public static class Validate
    {
        public static void ScooterId(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new InvalidIdException();
            }
        }
    }
}
