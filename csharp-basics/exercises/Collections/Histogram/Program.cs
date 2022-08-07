using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        private const string Path = "../../midtermscores.txt";

        private static void Main(string[] args)
        {
            var statDictionary = new Dictionary<string, int>
            {
                { "00-09", 9 },
                { "10-19", 19 },
                { "20-29", 29 },
                { "30-39", 39 },
                { "40-49", 49 },
                { "50-59", 59 },
                { "60-69", 69 },
                { "70-79", 79 },
                { "80-89", 89 },
                { "90-99", 99 },
                { "  100", 100 },
            };
            var readText = File.ReadAllText(Path);

            int[] scores = Array.ConvertAll(readText.Split(' '), score => Convert.ToInt32(score));

            int previousStat = 0;

            foreach(KeyValuePair<string, int> stat in statDictionary)
            {
                int statCount = scores.Where(x => x > previousStat && x <= stat.Value).Count();
                previousStat = stat.Value;
                Console.WriteLine($"{stat.Key}: {new String('*', statCount)}");
            }
        }
    }
}
