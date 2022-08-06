using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Fuel Consumption Calculator");

            int startKilometers = 0;
            int liters;

            Car Audi = new Car("Audi", startKilometers);
            Car Bmw = new Car("BMW", startKilometers);

            for (int i = 1; i <= 3; i++)
            {
                SetOdometerAndLitersReading(Audi, i);

                SetOdometerAndLitersReading(Bmw, i);
            }

            Console.WriteLine("\nAudi kilometers per liter are " + Math.Round(Audi.CalculateConsumption(), 2) + " gasHog: " + Audi.GasHog());
            Console.WriteLine("BMW kilometers per liter are " + Math.Round(Bmw.CalculateConsumption(), 2) + " economyCar: " + Bmw.EconomyCar());
            Console.ReadKey();
        }

        private static void SetOdometerAndLitersReading(Car car, int readingCount)
        {
            Console.Write($"\nEnter {readingCount}. odometer reading for {car.carName}: ");
            var odometerReading = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter liters reading: ");
            var literReading = Convert.ToInt32(Console.ReadLine());

            car.FillUp(odometerReading, literReading);
        }
    }
}
