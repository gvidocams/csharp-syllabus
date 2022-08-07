using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            var carList = new List<string> { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };
            Console.WriteLine(String.Join(" ", carList));

            var carHashSet = new HashSet<string> { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };
            Console.WriteLine(String.Join(" ", carHashSet));

            var dictionary = new Dictionary<string, string> { { "Audi", "Germany" }, { "BMW", "Germany" }, { "Honda", "Japan" }, { "Mercedes", "Germany" }, { "Volkswagen", "Germany" }, { "Tesla", "USA" } };
            
            foreach(var pair in dictionary)
            {
                Console.WriteLine(pair);
            }
        }
    }
}
