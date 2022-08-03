using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FuelGauge FuelGauge = new FuelGauge(50);
            Odometer Odometer = new Odometer(0, FuelGauge);

            Console.WriteLine(FuelGauge.ReportFuel());
            Odometer.ReportMileage();
            Console.WriteLine();

            for (int i = 0; i < 100; i++)
            {
                FuelGauge.AddFuel();
            }

            Console.WriteLine(FuelGauge.ReportFuel());
            Odometer.ReportMileage();
            Console.WriteLine();

            for (int i = 0; i < 900; i++)
            {
                Odometer.IncrementMileage();
            }

            Console.WriteLine(FuelGauge.ReportFuel());
            Odometer.ReportMileage();
            Console.WriteLine();
        }
    }
}
