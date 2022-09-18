using ScooterRental.Exceptions;
using ScooterRental.Helper;
using ScooterRental.Interfaces;

namespace ScooterRental
{
    public class RentalCompany : IRentalCompany
    {
        private IScooterService _scooterService;
        private List<IRentalDetails> _rentalList;

        public RentalCompany(string name, IScooterService scooterService, List<IRentalDetails> rentalPeriods)
        {
            Name = name;
            _scooterService = scooterService;
            _rentalList = rentalPeriods;
        }

        public string Name { get; }

        public void StartRent(string id)
        {
            var scooter = _scooterService.GetScooterById(id);

            if (scooter.IsRented)
            {
                throw new ScooterIsStillRentedException(id);
            }

            _scooterService.GetScooterById(id).IsRented = true;

            _rentalList.Add(new RentalDetails(id, DateTime.Now, scooter.PricePerMinute));
        }

        public decimal EndRent(string id)
        {
            var scooter = _scooterService.GetScooterById(id);

            if (!scooter.IsRented)
            {
                throw new ScooterIsntRentedToEndRentException(id);
            }

            var rentalDetails = _rentalList.FirstOrDefault(r => r.Id == id && !r.EndTime.HasValue);

            rentalDetails.EndTime = DateTime.Now;

            scooter.IsRented = false;

            return Calculate.TotalRentalPrice(rentalDetails);
        }

        public decimal CalculateIncome(int? year, bool includeNotCompletedRentals)
        {
            decimal income = 0;

            if (year.HasValue)
            {
                foreach(var rentalDetail in _rentalList)
                {
                    if ((rentalDetail.EndTime.HasValue && rentalDetail.EndTime.Value.Year == year) || 
                        (includeNotCompletedRentals && DateTime.Now.Year == year))
                    {
                        income += Calculate.TotalRentalPrice(rentalDetail);
                    }
                }
            }
            else
            {
                foreach(var rentalDetail in _rentalList)
                {
                    if(rentalDetail.EndTime.HasValue || includeNotCompletedRentals)
                    {
                        income += Calculate.TotalRentalPrice(rentalDetail);
                    }
                }
            }

            return income;
        }
    }
}
