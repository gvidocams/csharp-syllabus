namespace ScooterRental.Interfaces
{
    public interface IScooter
    {
        public string Id { get; }
        public decimal PricePerMinute { get; }
        public bool IsRented { get; set; }
    }
}
