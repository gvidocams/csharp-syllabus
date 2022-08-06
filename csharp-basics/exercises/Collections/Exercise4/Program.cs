using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new HashSet<string>();

            while(true)
            {
                Console.Write("Enter name: ");
                var userInput = Console.ReadLine();

                if(userInput == "")
                {
                    break;
                }

                names.Add(userInput);
            }

            Console.WriteLine($"Unique name list contains: {String.Join(" ", names)}");
        }
    }
}
