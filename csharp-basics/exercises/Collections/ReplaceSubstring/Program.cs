using System;
using System.Linq;
using System.Collections.Generic;

namespace ReplaceSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new[] { "near", "speak", "tonight", "weapon", "customer", "deal", "lawyer" };

            IEnumerable<string> noDuplicates =
                from word in words
                select word.Replace("ea", "*");

            Console.WriteLine(String.Join(' ', noDuplicates));
            Console.ReadKey();
        }
    }
}
