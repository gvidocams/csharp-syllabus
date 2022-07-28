using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOddEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even or odd number checker\n");

            Console.Write("Enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if(userInput % 2 == 0)
            {
                Console.WriteLine("\nEven");
                Console.WriteLine("Bye");
            }
            else
            {
                Console.WriteLine("\nOdd");
                Console.WriteLine("Bye");
            }
        }
    }
}
