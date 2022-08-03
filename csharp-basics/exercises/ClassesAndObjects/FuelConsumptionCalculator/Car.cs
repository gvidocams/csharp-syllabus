namespace FuelConsumptionCalculator
{
    public class Car
    {
        double startKilometers;
        double endKilometers;
        double liters;

        public Car(double startOdo)
        {
            this.startKilometers = startOdo;
        }

        public double CalculateConsumption()
        {
            return (this.endKilometers - this.startKilometers) / this.liters;
        }

        private double ConsumptionPer100Km()
        {
            return 0;
        }

        public bool GasHog()
        {
            return ConsumptionPer100Km() > 15;
        }

        public bool EconomyCar()
        {
            return ConsumptionPer100Km() < 5;
        }

        public void FillUp(int mileage, double liters)
        {
            this.endKilometers = mileage;
            this.liters = liters;
        }
    }
}
