using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    internal class Program
    {
        static void Main()
        {
            int desiredNum = GetAndValidateInput();
            
            Random random = new Random();

            int sum = 0;
            int dice1,dice2;
            while (sum != desiredNum)
            {
                dice1 = random.Next(1,7);
                dice2 = random.Next(1,7);
                sum = dice1 + dice2;

                Console.WriteLine($"{dice1} and {dice2} = {sum}");
            }
        }

        static int GetAndValidateInput()
        {
            Console.Clear();

            try
            {
                Console.Write("Desired sum: ");
                int desiredNum = Convert.ToInt16(Console.ReadLine());

                if (desiredNum < 2 || desiredNum > 12)
                {
                    Console.WriteLine("You need to be in the range from 2-12! Okey? (>'_')>");
                    Console.ReadKey();

                    GetAndValidateInput();
                }
                else
                {
                    return desiredNum;
                }
            }
            catch
            {
                Console.WriteLine("You need to give me an integer >_>");
                Console.ReadKey();
                GetAndValidateInput();
            }

            return 0;
        }
    }
}
