using System;
using System.IO;
using System.Text;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "../../lear.txt";
            string[] content = File.ReadAllLines(path, Encoding.UTF8);

            Console.WriteLine($"Lines: {GetNumberOfLines(content)}");
            Console.WriteLine($"Words: {GetNumberOfWords(content)}");
            Console.WriteLine($"Chars: {GetNumberOfChars(content)}");
        }

        static int GetNumberOfLines(string[] content)
        {
            return content.Length;
        }

        static int GetNumberOfWords(string[] content)
        {
            int words = 0;

            foreach(string line in content)
            {
                words += line.Split(new Char[] { ' ', '\'' }).Length;
            }

            return words;
        }

        static int GetNumberOfChars(string[] content)
        {
            int chars = 0;

            foreach(string line in content)
            {
                chars += line.ToCharArray().Length;
            }

            return chars;
        }
    }
}
