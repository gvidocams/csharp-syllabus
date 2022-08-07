using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var stringElements = new List<string>();
            
            stringElements.Add("String");
            stringElements.Add("A string");
            stringElements.Add("Still a string");
            stringElements.Add("String element");
            stringElements.Add("This is a string element");
            stringElements.Add("I'm a string element too :(");
            stringElements.Add("I am just a string");
            stringElements.Add("Just a mush full of chars");
            stringElements.Add("At least i am loopable");
            stringElements.Add("Hihi");
            
            stringElements.Insert(5, "Can i be a string too?");
            
            stringElements[stringElements.Count - 1] = "Haha";
            
            stringElements.Sort();
            
            Console.WriteLine(stringElements.Contains("Foobar"));
            
            foreach(string element in stringElements)
            {
                Console.WriteLine(element);
            }
        }
    }
}
