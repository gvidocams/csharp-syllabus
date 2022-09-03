using ScooterRental.Exceptions;

namespace ScooterRental.Helper
{
    public static class Get
    {
        public static Scooter Scooter(string id, IList<Scooter> scooters)
        {
            var scooter = scooters.FirstOrDefault(scooter => scooter.Id == id);

            if (scooter == null)
            {
                throw new ScooterDoesNotExistsException(id);
            }

            return scooter;
        }

    }
}
