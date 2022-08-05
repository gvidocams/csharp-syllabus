using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smoothie s1 = new Smoothie(new string[] { "Banana" });

            Console.WriteLine(String.Join(" ", s1.ingredients));
            Console.WriteLine(s1.GetCost());
            Console.WriteLine(s1.GetPrice());
            Console.WriteLine(s1.GetName());

            Smoothie s2 = new Smoothie(new string[] { "Raspberries", "Strawberries", "Blueberries" });

            Console.WriteLine();
            Console.WriteLine(String.Join(" ", s2.ingredients));
            Console.WriteLine(s2.GetCost());
            Console.WriteLine(s2.GetPrice());
            Console.WriteLine(s2.GetName());

        }
    }
}
