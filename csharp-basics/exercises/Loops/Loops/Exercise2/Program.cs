using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            
            Console.Write("Input number of terms: ");
            n = Convert.ToInt32(Console.ReadLine());
            /*
            todo - complete loop to multiply i with itself n times, it is NOT allowed to use Math.Pow()
            */
            for (i = 0; i < n; i++)
            {
                i *= i;
            }

            Console.WriteLine($"1 to the power of {n} is: {i}");
            Console.ReadKey();
        }
    }
}
