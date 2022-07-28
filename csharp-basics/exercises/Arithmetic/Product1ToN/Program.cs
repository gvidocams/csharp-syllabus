using System;

namespace Product1ToN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get factorial of a number\n");

            Console.Write("Enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            int factorial = 1;
            for (int i = 1; i <= userInput; i++)
            {
                factorial *= i;
            }
            
            Console.WriteLine(factorial);
        }
    }
}
