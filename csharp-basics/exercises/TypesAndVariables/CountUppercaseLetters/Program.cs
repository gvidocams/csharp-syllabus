using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CountUppercaseLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check how many uppercase letters you have in a sentence.\n");

            Console.Write("Enter a sentence: ");
            string userInput = Console.ReadLine();

            Console.WriteLine(CountUppercaseLetters(userInput));
        }

        static int CountUppercaseLetters(string sentence)
        {
            Regex regex = new Regex("[A-Z]");
            int numberOfMatches = regex.Matches(sentence).Count;

            return numberOfMatches;
        }
    }
}
