namespace ScooterRental.Exceptions
{
    public class ScooterIsntRentedToEndRentException : Exception
    {
        public ScooterIsntRentedToEndRentException(string id)
            : base($"Can't end rent to this scooter with id {id} because it hasn't been rented in the first place!") { }
    }
}
