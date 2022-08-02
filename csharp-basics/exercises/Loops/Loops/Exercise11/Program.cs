using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type a sentence: ");
            string userSentence = Console.ReadLine();

            Console.WriteLine(ReverseCase(userSentence));
        }

        static string ReverseCase(string sentence)
        {
            char[] letters = sentence.ToCharArray();
            string result = "";
            foreach(char letter in letters)
            {
                if(letter == char.ToUpper(letter))
                {
                    result += char.ToLower(letter);
                }
                else
                {
                    result += char.ToUpper(letter);
                }
            }

            return result;
        }
    }
}
