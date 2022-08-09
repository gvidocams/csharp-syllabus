using System;
using System.Linq;
using System.Collections.Generic;

namespace DragRace
{
    class Program
    {
        private static void Main(string[] args)
        {
            
            var Audi = new Audi();
            var Bmw = new Bmw();
            var Ford = new Ford();
            var Lexus = new Lexus();
            var Tesla = new Tesla();
            var Volkswagen = new Volkswagen();

            var cars = new List<Car> { Audi, Bmw, Ford, Lexus, Tesla, Volkswagen };

            Audi.SpeedUp();
            Audi.ShowCurrentSpeed();
            
            for(int i = 0; i < 10; i++)
            {
                foreach(Car car in cars)
                {
                    if(i == 2)
                    {
                        if(car is IBoost nitrousCar)
                        {
                            nitrousCar.UseNitrousOxideEngine();
                        }
                        else
                        {
                            car.SpeedUp();
                        }
                    }

                    car.SpeedUp();
                }
            }

            List<Car> sortedCars = cars.OrderBy(Car => Car.ShowCurrentSpeed()).ToList();

            Console.WriteLine($"The fastest car was {sortedCars[0].GetType().Name} with the speed of {sortedCars[0].ShowCurrentSpeed()}");
            Console.ReadKey();
        }
    }
}