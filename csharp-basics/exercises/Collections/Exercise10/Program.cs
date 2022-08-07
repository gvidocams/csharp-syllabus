using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hashSet = new HashSet<string>
            {
                "Gvido",
                "Andis",
                "Cams",
                "Codelex",
                "Code"
            };

            Console.WriteLine(String.Join(" ", hashSet));
            
            hashSet.Clear();

            hashSet.Add("Gvido");
            hashSet.Add("Cams");
            hashSet.Add("Code");
            hashSet.Add("Cams");
            hashSet.Add("Cams");

            Console.WriteLine(String.Join(" ", hashSet));
        }
    }
}
