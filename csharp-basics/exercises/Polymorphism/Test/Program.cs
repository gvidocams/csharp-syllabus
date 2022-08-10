using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstString = "Lorem Ipsum is simply dummy text of the printing and typesetting industry";
            string secondString = "the printing and typesetting industryLorem Ipsum is simply dummy text of ";


            Console.WriteLine(firstString.IndexOf("the printing and typesetting industry"));
            Console.WriteLine(Rotation(firstString, secondString));
        }
        
        static bool Rotation(string firstString, string secondString)
        {
            if(firstString.Length == secondString.Length)
            {
                return false;
            }

            string[] words = firstString.Split(' ');
            string firstPart = secondString.Substring(0, firstString.IndexOf(words[0]));

            if(firstString.IndexOf(firstPart) == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
        
        
    }
}
