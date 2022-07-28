using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            const double InToCm = 2.54;
            const double LbToKg = 0.453592;

            string name = "Zed A. Shaw";
            int age = 35;
            int heightInInches = 74;
            int weightInLb = 180;
            double heightInCm = Math.Round(heightInInches * InToCm, 2);
            double weightInKg = Math.Round(weightInLb * LbToKg, 2); ;
            string eyes = "Blue";
            string teeth = "White";
            string hair = "Brown";

            Console.WriteLine("Let's talk about " + name + ".");
            Console.WriteLine("He's " + heightInCm + " centimeters tall.");
            Console.WriteLine("He's " + weightInKg + " kilograms heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + eyes + " eyes and " + hair + " hair.");
            Console.WriteLine("His teeth are usually " + teeth + " depending on the coffee.");

            Console.WriteLine("If I add " + age + ", " + heightInCm + ", and " + weightInLb
                               + " I get " + (age + heightInCm + weightInLb) + ".");

            Console.ReadKey();
        }
    }
}