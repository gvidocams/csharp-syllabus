namespace ScooterRental
{
    public class Calculate
    {
        public static decimal TotalRentalPrice(RentalDetails rentalDetails)
        {
            var startTime = rentalDetails.StartTime;
            var endTime = rentalDetails.EndTime.HasValue ? (DateTime)rentalDetails.EndTime : DateTime.Now;
            var pricePerMinute = rentalDetails.PricePerMinute;

            var rentedMinutes = (endTime - startTime).TotalMinutes;
            var rentedDays = (endTime - startTime).Days;

            const int MinutesInADay = 1440;

            decimal rentPrice = 0;

            if (rentedDays <= 0)
            {
                return Math.Round(RentPrice(rentedMinutes, pricePerMinute), 2);
            }

            var firstDayMinutes = MinutesInADay - startTime.TimeOfDay.TotalMinutes;

            rentPrice += RentPrice(firstDayMinutes, pricePerMinute);
            rentedMinutes -= firstDayMinutes;

            while (rentedMinutes > MinutesInADay)
            {
                rentPrice += RentPrice(firstDayMinutes, pricePerMinute);
                rentedMinutes -= MinutesInADay;
            }

            rentPrice += RentPrice(rentedMinutes, pricePerMinute);

            return Math.Round(rentPrice, 2);
        }

        public static decimal RentPrice(double minutes, decimal pricePerMinute)
        {
            const decimal RentPriceLimit = 20m;

            decimal rentPrice = pricePerMinute * (decimal)minutes;
            decimal priceForThisDay = rentPrice >= RentPriceLimit ? RentPriceLimit : rentPrice;

            return Math.Round(priceForThisDay, 2);
        }
    }
}
