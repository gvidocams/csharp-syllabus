using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a position from range (0 - 19): ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] randomArray = CreateRandomArray();

            Console.WriteLine($"The value from your input is {randomArray[n]}");
        }

        static int[] CreateRandomArray()
        {
            Random rand = new Random();
            int arrayLength = 20;
            int[] array = new int[arrayLength];

            for(int i = 0; i < arrayLength; i++)
            {
                array[i] = rand.Next(100);
            }

            return array;
        }
    }
}
