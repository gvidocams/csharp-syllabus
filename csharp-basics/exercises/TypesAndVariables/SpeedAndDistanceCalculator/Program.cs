using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedAndDistanceCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Speed and distance calculator\n");

            Console.Write("Enter distance in meters: ");
            double userMeters = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter hours spent: ");
            double userHours = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter minutes spent: ");
            double userMinutes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter seconds spent: ");
            double userSeconds = Convert.ToInt32(Console.ReadLine());

            GetSpeedAndDistance(userMeters, userHours, userMinutes, userSeconds);
        }

        static void GetSpeedAndDistance(double meters, double hours, double minutes, double seconds)
        {
            const double MpsToKmH = 3.6;
            const double KmhToMph = 0.621371192;

            seconds += (hours * 60 * 60) + (minutes * 60);
            double miles = meters / 1609;

            double speedInMps = meters / seconds;
            Console.WriteLine($"\nYour speed in meters/second is {Math.Round(speedInMps, 8)}");

            double speedInKmH = speedInMps * MpsToKmH;
            Console.WriteLine($"Your speed in km/h is {Math.Round(speedInKmH, 8)}");

            double speedInMph = speedInKmH * KmhToMph;
            Console.WriteLine($"Your speed in miles/h is {Math.Round(speedInMph, 8)}");
        }
    }
}
