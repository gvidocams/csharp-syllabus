using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Max value? ");
            int max = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i < max; i++)
            {
                if(i % 5 == 0 && i % 3 == 0)
                {
                    Console.Write("FizzBuzz ");
                }
                else if(i % 5 == 0)
                {
                    Console.Write("Buzz ");
                }
                else if(i % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                else 
                {
                    Console.Write($"{i} ");
                }

                if(i % 20 == 0)
                {
                    Console.WriteLine();
                }    
            }

            Console.WriteLine();
        }
    }
}
