using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randNum = rand.Next(101);
            
            Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if(userInput == randNum)
            {
                Console.WriteLine("You guessed it! What are the odds?!?");
            }
            else
            {
                Console.WriteLine($"Sorry, you are too {(userInput > randNum ? "high" : "low")}. I was thinking of {randNum}");
            }
        }
    }
}
