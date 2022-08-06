using System;
using System.Linq;
using System.Collections.Generic;

namespace UniqueValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ToDo: Given a non-empty list of strings, return a list that contains only unique (non-duplicate) strings.
            //ToDo: Example: ["abc", "xyz", "klm", "xyz", "abc", "abc", "rst"] → ["klm", "rst"]

            var values = new List<string> { "Hi", "Meow", "Hello", "Meow", "Hi!", "Meow", "Hi", "Bye" };
            
            IEnumerable<string> noDuplicates =
                from value in values
                where values.Where(x => x.Equals(value)).Count() <= 1
                select value;

            Console.WriteLine(String.Join(' ', noDuplicates));
            Console.ReadKey();
        }
    }
}
