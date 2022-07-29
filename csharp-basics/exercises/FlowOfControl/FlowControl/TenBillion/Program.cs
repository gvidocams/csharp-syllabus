using System;

namespace TenBillion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input an integer number less than ten billion: ");
            var input = Convert.ToInt64(Console.ReadLine());

            var inputType = input.GetType();

            if (inputType.Equals(typeof(Int64))) 
            {
                if (input < 0) 
                {
                    input *= -1;
                }
                if (input >= 10000000000) 
                {
                    Console.WriteLine("Number is greater or equals 10,000,000,000!");
                } 
                else 
                {
                    int digits = 1;
                    if (input < 100) 
                    {
                        digits = 2;
                    } 
                    else if (input < 1000) 
                    {
                        digits = 3;
                    } 
                    else if (input < 10000) 
                    {
                        digits = 4;
                    } 
                    else if (input < 100000) 
                    {
                        digits = 5;
                    } 
                    else if (input < 1000000) 
                    {
                        digits = 6;
                    } 
                    else if (input < 10000000) 
                    {
                        digits = 7;
                    } 
                    else if (input < 100000000) 
                    {
                        digits = 8;
                    } 
                    else if (input < 1000000000) 
                    {
                        digits = 9;
                    } 
                    else if (input < 10000000000) 
                    {
                        digits = 10;
                    }

                    Console.WriteLine("Number of digits in the number: " + digits);
                }
            }  
            else 
            {
                Console.WriteLine("The number is not a long");
            }
        }
    }
}
