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
            int startKilometers;
            int liters;

            Car Golf = new Car(50, 100, 5);
            Car Bmw = new Car(50, 100, 2);
            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"Enter {i}. odometer reading for Golf: ");
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

            Console.WriteLine("\nKilometers per liter are " + Golf.CalculateConsumption() + " gasHog:" + Golf.GasHog());
            Console.WriteLine("Car1 Kilometers per liter are " + Bmw.CalculateConsumption()+ " economyCar:" + Bmw.EconomyCar());
            Console.ReadKey();
        }
    }
}
