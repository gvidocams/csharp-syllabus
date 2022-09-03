using ScooterRental.Exceptions;
using ScooterRental.Helper;
using ScooterRental.Interfaces;

namespace ScooterRental
{
    public class ScooterService : IScooterService
    {
        public List<Scooter> _scooters;

        public ScooterService(List<Scooter> inventory)
        {
            _scooters = inventory;
        }

        public void AddScooter(string id, decimal pricePerMinute)
        {
            Validate.ScooterId(id);

            if (pricePerMinute <= 0)
            {
                throw new InvalidPriceException(pricePerMinute);
            }

            if(_scooters.Any(scooter => scooter.Id == id))
            {
                throw new DuplicateScooterException(id);
            }

            _scooters.Add(new Scooter(id, pricePerMinute));
        }

        public void RemoveScooter(string id)
        {
            Validate.ScooterId(id);

            var scooter = Get.Scooter(id, _scooters);

            if(scooter.IsRented)
            {
                throw new ScooterIsStillRentedException(id);
            }

            _scooters.Remove(Get.Scooter(id, _scooters));
        }

        public IList<Scooter> GetScooters()
        {
            return _scooters.FindAll(scooter => !scooter.IsRented).ToList();
        }

        public Scooter GetScooterById(string scooterId)
        {
            Validate.ScooterId(scooterId);

            return Get.Scooter(scooterId, _scooters);
        }
    }
}
