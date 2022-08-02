using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    internal class AsciiFigure
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of your Ascii Figure: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int half = (input - 1) * 4;

            string firstLine = new string('/', half) + new string('\\', half);
            Console.WriteLine(firstLine);

            char[] line = firstLine.ToCharArray();
            int overwriteStart = half - 4;
            int overwriteEnd = half + 4;
            
            for(int i = 1; i < input; i++)
            {
                for(int y = overwriteStart; y < overwriteEnd; y++)
                {
                    line[y] = '*';
                }
                overwriteStart -= 4;
                overwriteEnd += 4;

                Console.WriteLine(String.Join("", line));
            }
        }
    }
}
