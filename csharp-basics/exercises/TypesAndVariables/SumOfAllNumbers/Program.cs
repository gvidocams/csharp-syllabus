using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfAllNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get the sum of single digit numbers");
            Console.WriteLine("Writing format is: 1 4 2 6 1 2 6 2...\n");

            Console.Write("Enter a series of single digit numbers: ");
            string userInput = Console.ReadLine();

            Console.WriteLine(GetSumOfDigits(userInput));
        }
        static int GetSumOfDigits(string seriesOfDigits)
        {
            string[] listOfDigits = seriesOfDigits.Split(' ');
            int sumOfDigits = 0;

            for(int i = 0; i < listOfDigits.Length; i++)
            {
                sumOfDigits += Convert.ToInt16(listOfDigits[i]);
            }

            return sumOfDigits;
        }
    }
}
