using System;

namespace IsFifteen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is a number or sum or difference 15?\n");

            Console.Write("Enter the first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the first number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(IsFifteen(firstNumber, secondNumber));
        }

        static bool IsFifteen(int firstNumber, int secondNumber)
        {
            bool isANumberFifteen = (firstNumber == 15 || secondNumber == 15);
            bool isSumFifteen = (firstNumber + secondNumber == 15);
            bool isDifferenceFifteen = (Math.Abs(firstNumber - secondNumber) == 15);

            bool isFifteen = isANumberFifteen || isSumFifteen || isDifferenceFifteen;

            return isFifteen;
        }
    }
}
