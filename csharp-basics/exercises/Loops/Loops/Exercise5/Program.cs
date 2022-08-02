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
            Console.Write("Input the chapter: ");
            string chapter = Console.ReadLine();

            Console.Write("Input the page number: ");
            string page = Console.ReadLine();

            const int MaxLineLength = 30;

            int usedLength = chapter.Length + page.Length;
            int dotsLength = MaxLineLength - usedLength;

            Console.Write(chapter);

            for(int i = 0; i < dotsLength; i++)
            {
                Console.Write(".");
            }

            Console.Write($"{page}\n");
        }
    }
}
