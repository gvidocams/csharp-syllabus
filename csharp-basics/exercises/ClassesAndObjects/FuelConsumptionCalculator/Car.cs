namespace FuelConsumptionCalculator
{
    public class Car
    {
        public string carName;
        double startKilometers;
        double endKilometers;
        double liters;

        public Car(string carName, double startOdo)
        {
            this.carName = carName;
            this.startKilometers = startOdo;
        }

        public double CalculateConsumption()
        {
            return (this.endKilometers - this.startKilometers) / this.liters;
        }

        private double ConsumptionPer100Km()
        {
            return 100 / CalculateConsumption();
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
