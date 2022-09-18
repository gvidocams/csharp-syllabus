namespace ScooterRental.Interfaces
{
    public interface IScooterService
    {
        void AddScooter(string id, decimal pricePerMinute);
        void RemoveScooter(string id);
        IList<IScooter> GetScooters();
        IScooter GetScooterById(string scooterId);
    }
}
