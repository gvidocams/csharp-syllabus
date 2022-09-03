namespace ScooterRental.Exceptions
{
    public class ScooterDoesNotExistsException : Exception
    {
        public ScooterDoesNotExistsException(string id)
            : base($"Scooter with id {id} doesn't exist!") { }
    }
}
