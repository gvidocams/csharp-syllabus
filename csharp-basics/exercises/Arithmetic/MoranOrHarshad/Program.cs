using System;

namespace MoranOrHarshad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is your number Moran or Harshad?\n");

            Console.Write($"Enter your number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            bool isHarshad = IsHarshad(userInput);
            bool isMoran = IsMoran(userInput) && isHarshad;

            if(isMoran && isHarshad)
            {
                Console.WriteLine("M");
            } 
            else if(isHarshad)
            {
                Console.WriteLine("H");
            } 
            else
            {
                Console.WriteLine("Neither");
            }
        }

        static bool IsHarshad(int number)
        {
            int sumOfDigits = GetDigitSum(number);

            return (number % sumOfDigits == 0);
        }

        static bool IsMoran(int userNumber)
        {
            int sumOfDigits = GetDigitSum(userNumber);
            int number = userNumber / sumOfDigits;

            int m = number / 2;
            for (int i = 2; i <= m; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static int GetDigitSum(int number)
        {
            var digits = number.ToString()
                               .ToCharArray();
            int sumOfDigits = 0;

            foreach (char digit in digits)
            {
                sumOfDigits += Convert.ToInt32(Char.GetNumericValue(digit));
            }

            return sumOfDigits;
        }
    }
}
