using System;

namespace Exercise2
{
    class Program
    {       
        // TODO: Write a C# program to sum values of an array.
        // Array values are starting from min (including) till max (including) number. 
        private static void Main(string[] args)
        {
            var sum = 0;

            Console.Write("Please enter a min number: ");
            int minNumber = int.Parse(Console.ReadLine());
            Console.Write("\nPlease enter a max number: ");
            int maxNumber = int.Parse(Console.ReadLine());

            for (int i = minNumber; i <= maxNumber; i++) {
                sum += i;
            }
            
            Console.WriteLine("\nThe sum is " + sum);
            Console.ReadKey();
        }
    }
}
