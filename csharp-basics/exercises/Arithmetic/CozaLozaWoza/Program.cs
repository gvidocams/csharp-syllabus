using System;

namespace CozaLozaWoza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 110;

            int i;
            for(i = start; i <= end; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("CozaLoza ");
                }
                else if(i % 7 == 0)
                {
                    Console.Write("Woza ");
                }
                else if(i % 5 == 0)
                {
                    Console.Write("Loza ");
                }
                else if(i % 3 == 0)
                {
                    Console.Write("Coza ");
                }
                else
                {
                    Console.Write(i + " ");
                }    

                if(i % 11 == 0) 
                {
                    Console.WriteLine(""); 
                }
            }
        }
    }
}
