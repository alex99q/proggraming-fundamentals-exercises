using System;
using System.Collections.Generic;

namespace _2.Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var towns = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] inputTokens = Console.ReadLine().Split();

                string continent = inputTokens[0];
                string country = inputTokens[1];
                string town = inputTokens[2];

                AddTown(towns, continent, country, town);
            }

            foreach (var continentCountryTownsPair in towns)
            {
                string continent = continentCountryTownsPair.Key;
                Console.WriteLine($"{continent}:");

                var countryTownsDict = continentCountryTownsPair.Value;
                foreach (var countryTownsPair in countryTownsDict)
                {
                    string country = countryTownsPair.Key;
                    var countryTowns = countryTownsPair.Value;

                    Console.WriteLine("  {0} -> {1}", country, string.Join(", ", countryTowns));
                }
            }

        }

        private static void AddTown(Dictionary<string, Dictionary<string, List<string>>> towns, string continent, string country, string town)
        {
            if (!towns.ContainsKey(continent))
            {
                towns[continent] = new Dictionary<string, List<string>>();
            }

            if (!towns[continent].ContainsKey(country))
            {
                towns[continent][country] = new List<string>();
            }

            towns[continent][country].Add(town);
        }
    }
}
