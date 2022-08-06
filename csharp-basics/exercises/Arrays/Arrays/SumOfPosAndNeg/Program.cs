using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfPosAndNeg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count the positive and negative values seperatly from an array");

            int[] testCase1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            int[] testCase2 = { 92, 6, 73, -77, 81, -90, 99, 8, -85, 34 };
            int[] testCase3 = { 91, -4, 80, -73, -28 };
            int[] testCase4 = { };

            int[] testCase1Sum = SumOfPosAndNeg(testCase1);
            int[] testCase2Sum = SumOfPosAndNeg(testCase2);
            int[] testCase3Sum = SumOfPosAndNeg(testCase3);
            int[] testCase4Sum = SumOfPosAndNeg(testCase4);

            Console.WriteLine(String.Join(" ", testCase1Sum));
            Console.WriteLine(String.Join(" ", testCase2Sum));
            Console.WriteLine(String.Join(" ", testCase3Sum));
            Console.WriteLine(String.Join(" ", testCase4Sum));
        }

        static int[] SumOfPosAndNeg(int[] numbers)
        {
            if(numbers.Length == 0)
            {
                return new int[] { };
            }

            int posCount = 0;
            int negSum = 0;

            foreach(int num in numbers)
            {
                if(num > 0)
                {
                    posCount++;
                }
                else
                {
                    negSum += num;
                }
            }

            return new int[] {posCount, negSum};
        }
    }
}
