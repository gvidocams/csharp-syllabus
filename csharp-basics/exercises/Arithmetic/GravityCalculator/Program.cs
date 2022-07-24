
using System;

namespace GravityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double gravity = -9.81;  // Earth's gravity in m/s^2
            double initialVelocity = 0.0;
            double fallingTime = 11.0;
            double initialPosition = 0.0;
            double finalPosition = CalculateFinalPosition(gravity, fallingTime, initialVelocity, initialPosition);
            Console.WriteLine("The object's position after " + fallingTime + " seconds is " + finalPosition + " m.");
            Console.ReadKey();
        }
        static double CalculateFinalPosition(double accel, double time, double initVelo, double initPos)
        {
            //Formula for calculating traveled distance is:
            //0.5 * acceleration * time^2 + inital velocity * time + inital position

            return 0.5 * (accel * Math.Pow(time, 2)) + initVelo * time + initPos;
        }
    }
}
