using System;
using System.Linq;
using System.Collections.Generic;

namespace DragRace
{
    class Program
    {
        /**
 * Take a look at the cars in this solution.
 * 1. Extract common behaviour to an interface called Car, and use it in the all classes.
 * Which methods will be extracted with an empty body, and which can be default?
 * 2. Create two more cars of your own choice.
 * 3. As you see there is a possibility to use some kind of boost in Lexus, extract it to a new interface
          and add that behaviour in one more car.
 * 4. Create one instance of an each car and add them to list.
 * 5. Iterate over the list 10 times, in the 3rd iteration use speed boost on the car if they have one.
 * 6. Print out the car name and speed of the fastest car
 */

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