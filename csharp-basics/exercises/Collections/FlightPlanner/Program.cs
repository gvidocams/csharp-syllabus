using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "../../flights.txt";

        static void Main(string[] args)
        {
            Console.WriteLine("Flight planner program!");
            Console.WriteLine("\nStarting city list:");

            var uniqueCities = GetUniqueCities();
            
            for (int i = 0; i < uniqueCities.Count; i++)
            {
                Console.WriteLine($"{i}. {uniqueCities[i]}");
            }

            Console.Write($"Enter a starting city number: ");
            int startingCityIndex = Convert.ToInt16(Console.ReadLine());
            
            string startingCity = uniqueCities[startingCityIndex];
            
            string flightPlan = FlightPlanner(startingCity);

            Console.WriteLine("Your flight plan is:\n");
            Console.WriteLine(flightPlan);
            Console.ReadKey();
        }

        static string FlightPlanner(string startingCity)
        {
            var flightPaths = GetFlightPaths();

            string path = $"{startingCity}";
            string currentCity = startingCity;

            while (true)
            {
                Console.WriteLine($"\nFlight options from {currentCity}:");

                var flightOptions = flightPaths[currentCity];

                for(int i = 0; i < flightOptions.Count; i++)
                {
                    Console.WriteLine($"{i}. {flightOptions[i]}");
                }
                
                Console.Write("\nEnter a city number: ");
                int chosenCityIndex = Convert.ToInt16(Console.ReadLine());  
                
                currentCity = flightOptions[chosenCityIndex];
                path += $" => {currentCity}";

                if (currentCity == startingCity)
                {
                    return path;
                }
            }
        }

        static List<string> GetUniqueCities()
        {
            var uniqueCities = new HashSet<string>();
            var readText = File.ReadAllLines(Path);

            string[] seperator = { " -> " };

            foreach (var s in readText)
            {
                string[] flight = s.Split(seperator, 0);
                uniqueCities.Add(flight[0]);
                uniqueCities.Add(flight[1]);
            }

            return uniqueCities.ToList<string>();
        }

        static SortedDictionary<string, List<string>> GetFlightPaths()
        {
            var flights = new SortedDictionary<string, List<string>>();

            var readText = File.ReadAllLines(Path);

            string[] seperator = { " -> " };

            foreach (var s in readText)
            {
                string[] flight = s.Split(seperator, 0);

                string flightFrom = flight[0];
                string flightTo = flight[1];

                if(flights.ContainsKey(flightFrom))
                {
                    flights[flightFrom].Add(flightTo);
                }
                else
                {
                    flights[flightFrom] = new List<string> { flightTo };
                }
            }

            return flights;
        }
    }
}
