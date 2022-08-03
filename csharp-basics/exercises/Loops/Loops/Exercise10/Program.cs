using System;

namespace Exercise10
{
    internal class NumberSquare
    {
        static void Main(string[] args)
        {
            Console.Write("Min? ");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.Write("Max? ");
            int max = Convert.ToInt32(Console.ReadLine());
            int index = min;

            for (int i = index; i <= max; i++)
            {
                int line = index;
                for (int j = min; j <= max; j++)
                {
                    if(line > max)
                    {
                        line = min;
                    }
                    Console.Write(line);
                    line++;
                }
                index++;
                Console.WriteLine();
            }
        }
    }
}
