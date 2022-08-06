using System;
using System.Linq;
using System.Collections.Generic;

namespace DecryptNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] solution = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')' };
            var cryptedNumbers = new List<string>
            {
                "())(",
                "*$(#&",
                "!!!!!!!!!!",
                "$*^&@!",
                "!)(^&(#@",
                "!)(#&%(*@#%"
            };

            var decryptedNumbers = new List<string>();

            for(int i = 0; i < cryptedNumbers.Count; i++)
            {
                string res = "";
                foreach(char c in cryptedNumbers[i])
                {
                    int index = Array.IndexOf(solution, c) + 1;
                    res += (index >= 10) ? 0 : index;
                }
                decryptedNumbers.Add(res);
            }

            Console.WriteLine(String.Join(' ', decryptedNumbers));
            Console.ReadKey();
        }
    }
}
