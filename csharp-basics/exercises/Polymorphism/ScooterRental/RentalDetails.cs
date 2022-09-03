namespace ScooterRental
{
    public class RentalDetails
    {
        public string Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal PricePerMinute { get; set; }

        public RentalDetails(string id, DateTime startDate, decimal rentalPrice)
        {
            Id = id;
            StartTime = startDate;
            PricePerMinute = rentalPrice;
        }
    }
}
