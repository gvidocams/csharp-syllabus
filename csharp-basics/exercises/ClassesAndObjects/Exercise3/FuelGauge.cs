using System;

namespace Exercise3
{
    public class FuelGauge
    {
        double liters;

        public FuelGauge(double liters)
        {
            this.liters = liters;
        }

        public double ReportFuel()
        {
            return this.liters;
        }

        public void AddFuel()
        {
            if(liters < 70)
            {
                liters++;
            }
        }

        public void BurnFuel()
        {
            if(liters > 0)
            {
                liters--;
            }
        }
    }
}
