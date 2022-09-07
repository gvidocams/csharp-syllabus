namespace ScooterRental.Interfaces
{
    public interface IRentalDetails
    {
        public string Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal PricePerMinute { get; set; }
    }
}
