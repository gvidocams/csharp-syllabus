using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            //TODO: Write a C# program to create a new list, add some elements (string) and print out the collection.
            //TODO: Add 5 colors to list
            var colors = new List<string> { "Yellow", "Brown" };

            Console.WriteLine(String.Join(" ", colors));

            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Blue");
            colors.Add("Purple");
            colors.Add("Magenta");
        }
    }
}
