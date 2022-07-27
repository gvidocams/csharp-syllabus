using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetMenu();
        }

        static void GetMenu()
        {
            Console.WriteLine("BMI (Body Mass Index) Calculator\n");
            Console.WriteLine("1. Calculate using metric system");
            Console.WriteLine("2. Calculate using imperial system");
            Console.WriteLine("3. Quit\n");

            Console.Write($"Enter your choice (1-3) : ");
            int userChoice = Convert.ToInt16(Console.ReadLine());

            Console.Clear();

            const double KgToPnd = 2.2;
            const double CmToIn = 0.39;

            double userWeightPnd, userHeightIn;

            switch (userChoice)
            {
                case 1:
                    Console.Write($"Enter your weight (kg): ");
                    userWeightPnd = Convert.ToInt32(Console.ReadLine()) * KgToPnd;

                    Console.Write($"Enter your height (cm): ");
                    userHeightIn = Convert.ToInt32(Console.ReadLine()) * CmToIn;

                    Console.WriteLine(GetBMI(userWeightPnd, userHeightIn));
                    break;
                case 2:
                    Console.Write($"Enter your weight (pnd): ");
                    userWeightPnd = Convert.ToInt32(Console.ReadLine());

                    Console.Write($"Enter your height (in): ");
                    userHeightIn = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(GetBMI(userWeightPnd, userHeightIn));
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input!!!\n");
                    GetMenu();
                    break;
            }
        }

        static double GetBMI(double weight, double height)
        {
            double userBMI = weight * 703 / Math.Pow(height, 2);

            return Math.Round(userBMI, 2);
        }
    }
}
