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
            
            for (i = 0; i < n; i++)
            {
                i *= i;
            }

            Console.WriteLine($"Result is: {i}");
            Console.ReadKey();
        }
    }
}
