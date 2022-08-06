using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] myArray =
            {
                1789, 2035, 1899, 1456, 2013,
                1458, 2458, 1254, 1472, 2365,
                1456, 2265, 1457, 2456
            };

            for (int i = 0; i < myArray.Length; i++) {
                if(myArray[i] == 1245)
                {
                    Console.WriteLine("Contains!");
                }
            }
        }
    }
}
