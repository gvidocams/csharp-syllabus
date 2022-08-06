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
