
using System;

namespace GravityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double gravity = -9.81;
            double initialVelocity = 0.0;
            double fallingTime = 11.0;
            double initialPosition = 0.0;
            double finalPosition = CalculateFinalPosition(gravity, fallingTime, initialVelocity, initialPosition);

            Console.WriteLine("The object's position after " + fallingTime + " seconds is " + finalPosition + " m.");
            Console.ReadKey();
        }
        static double CalculateFinalPosition(double acceleration, double time, double initVelocity, double initPosistion)
        {
            const double VelocityCoefficient = 0.5;
            return VelocityCoefficient * (acceleration * Math.Pow(time, 2)) + initVelocity * time + initPosistion;
        }
    }
}
