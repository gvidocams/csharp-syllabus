using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int cars = 100;
            int seatsInACar = 4;
            int drivers = 28;
            int passengers = 90;
            int carsNotDriven = cars - drivers;
            int seatsInCarWithoutDriver = seatsInACar - 1;
            int carpool_capacity = seatsInCarWithoutDriver * drivers;
            double averagePassengersPerCar = passengers / (double)drivers;

            Console.WriteLine("There are " + cars + " cars available.");
            Console.WriteLine("There are only " + drivers + " drivers available.");
            Console.WriteLine("There will be " + carsNotDriven + " empty cars today.");
            Console.WriteLine("We can transport " + carpool_capacity + " people today.");
            Console.WriteLine("We have " + passengers + " people to carpool today.");
            Console.WriteLine("We need to put about " + String.Format("{0:0.00}", averagePassengersPerCar) + " people in each car.");
            Console.ReadKey();
        }
    }
}