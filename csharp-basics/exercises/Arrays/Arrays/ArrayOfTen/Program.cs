using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfTen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random array generator");

            int[] array = GenerateRandomArray();
            int[] arrayCopy = new int[array.Length];

            array.CopyTo(arrayCopy, 0);

            int indexToChange = array.Length - 1;
            int numToChange = -7;

            array[indexToChange] = numToChange;

            Console.WriteLine($"Array 1: {String.Join(" ", array)}");
            Console.WriteLine($"Array 2: {String.Join(" ", arrayCopy)}");
        }
        static int[] GenerateRandomArray()
        {
            const int ArrayLength = 10;

            Random random = new Random();

            int[] array = new int[ArrayLength];

            for (int i = 0; i < array.Length; i++)
            {
                int newRandomNum = random.Next(101);
                array[i] = newRandomNum;
            }

            return array;
        }
    }
}
