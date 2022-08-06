using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program for finding nemo");

            string testCase1 = "I am finding Nemo !";
            string testCase2 = "Nemo is me";
            string testCase3 = "I Nemo am";
            string testCase4 = "I am Gvido and not a fish";

            Console.WriteLine(FindNemo(testCase1));
            Console.WriteLine(FindNemo(testCase2));
            Console.WriteLine(FindNemo(testCase3));
            Console.WriteLine(FindNemo(testCase4));
        }

        static string FindNemo(string sentence)
        {
            string[] words = sentence.Split(' ');

            int nemoIndex = Array.IndexOf(words, "Nemo");

            return nemoIndex != -1 ? $"I found nemo at {nemoIndex + 1}" : "I can't find Nemo :(";
        }
    }
}
