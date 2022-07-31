using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapMe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A program which capitalizes names from arrays!\n");

            string[] names = { "mavis", "senaida", "letty" };
            string[] moreNames = { "samuel", "MABELLE", "letitia", "meridith" };
            string[] evenMoreNames = { "Slyvia", "Kristal", "Sharilyn", "Calista" };

            Console.WriteLine("Original arrays:\n");
            Console.WriteLine(String.Join(" ", names));
            Console.WriteLine(String.Join(" ", moreNames));
            Console.WriteLine(String.Join(" ", evenMoreNames));

            string[] capNames = CapMe(names);
            string[] capMoreNames = CapMe(moreNames);
            string[] capEvenMoreNames = CapMe(evenMoreNames);

            Console.WriteLine("\nCapitalised arrays:\n");
            Console.WriteLine(String.Join(" ", capNames));
            Console.WriteLine(String.Join(" ", capMoreNames));
            Console.WriteLine(String.Join(" ", capEvenMoreNames));
        }

        static string[] CapMe(string[] names)
        {
            string[] capNames = new string[names.Length];

            for(int i = 0; i < names.Length; i++)
            {
                string name = names[i];

                capNames[i] = name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();
            }

            return capNames;
        }
    }
}
