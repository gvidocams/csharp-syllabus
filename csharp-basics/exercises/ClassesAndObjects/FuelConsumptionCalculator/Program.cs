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
            int startKilometers = 0;
            int liters;

            Console.WriteLine("Fuel Consumption Calculator");

            Car Golf = new Car(startKilometers);
            Car Bmw = new Car(startKilometers);

            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"\nEnter {i}. odometer reading for Golf: ");
                startKilometers = Convert.ToInt32(Console.ReadLine());    
                Console.Write("Enter liters reading: ");
                liters = Convert.ToInt32(Console.ReadLine());
                Golf.FillUp(startKilometers, liters);
                
                Console.Write($"\nEnter {i}. odometer reading for Bmw: ");
                startKilometers = Convert.ToInt32(Console.ReadLine());    
                Console.Write("Enter liters reading: ");
                liters = Convert.ToInt32(Console.ReadLine());
                Bmw.FillUp(startKilometers, liters);
            }

            Console.WriteLine("\nGolf kilometers per liter are " + Math.Round(Golf.CalculateConsumption(), 2) + " gasHog: " + Golf.GasHog());
            Console.WriteLine("BMW kilometers per liter are " + Math.Round(Bmw.CalculateConsumption(), 2) + " economyCar: " + Bmw.EconomyCar());
            Console.ReadKey();
        }
    }
}
