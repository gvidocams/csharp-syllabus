using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var userNumber = Convert.ToDouble(Console.ReadLine());

            while(true)
            {
                char[] digits = userNumber.ToString().ToCharArray();

                userNumber = 0;

                foreach(char digit in digits)
                {
                    userNumber += Math.Pow(Char.GetNumericValue(digit), 2);
                }

                if(userNumber == 1)
                {
                    break;
                }
            }

            Console.WriteLine("Happy");
        }
    }
}
