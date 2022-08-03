using System;


namespace Exercise3
{
    public class Odometer
    {
        int mileage;
        FuelGauge fuelGauge;

        public Odometer(int mileage, FuelGauge fuelGauge)
        {
            this.mileage = mileage;
            this.fuelGauge = fuelGauge;
        }

        public void ReportMileage()
        {
            Console.WriteLine($"Current mileage {mileage}");
        }

        public void IncrementMileage()
        {
            if (mileage > 999999)
            {
                mileage = 0;
            }

            if (fuelGauge.ReportFuel() > 0)
            {
                mileage++;
                if (mileage % 10 == 0)
                {
                    fuelGauge.BurnFuel();
                }
            }
        }
    }
}
