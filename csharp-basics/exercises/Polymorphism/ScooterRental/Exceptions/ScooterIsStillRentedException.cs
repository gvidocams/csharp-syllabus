namespace ScooterRental.Exceptions
{
    public class ScooterIsStillRentedException : Exception
    {
        public ScooterIsStillRentedException(string id)
            : base($"Can't remove a scooter with id {id} because it's still being rented!") { }
    }
}
