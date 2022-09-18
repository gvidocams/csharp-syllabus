using ScooterRental.Interfaces;

namespace ScooterRental
{
    public class Scooter : IScooter
    {
        public Scooter(string id, decimal pricePerMinute)
        {
            Id = id;
            PricePerMinute = pricePerMinute;
        }

        public string Id { get; }

        public decimal PricePerMinute { get; }

        public bool IsRented { get; set; }
    }
}
