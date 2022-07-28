using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the 1st number: ");
            var input1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the 2nd number: ");
            var input2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the 3rd number: ");
            var input3 = Convert.ToInt32(Console.ReadLine());

            if(input1 > input2)
            {
                if(input1 > input3)
                {
                    Console.WriteLine($"Your first input is the largest: {input1}");
                }
                else
                {
                    Console.WriteLine($"Your third input is the largest: {input3}");
                }
            } 
            else if(input2 > input3)
            {
                Console.WriteLine($"Your second input is the largest: {input2}");
            }
            else
            {
                Console.WriteLine($"Your thirs input is the largest: {input3}");
            }

            Console.ReadKey();
        }
    }
}
