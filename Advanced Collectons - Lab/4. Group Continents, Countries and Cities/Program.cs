using System;
using System.Collections.Generic;

namespace _4.Group_Continents__Countries_and_Cities
{
    class Program
    {
        static void Main(string[] args)
        {
            var towns = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputTokens = Console.ReadLine().Split();

                string continent = inputTokens[0];
                string country = inputTokens[1];
                string town = inputTokens[2];

                if (!towns.ContainsKey(continent))
                {
                    towns[continent] = new SortedDictionary<string, SortedSet<string>>();
                }

                if (!towns[continent].ContainsKey(country))
                {
                    towns[continent][country] = new SortedSet<string>();
                }

                towns[continent][country].Add(town);
            }

            foreach (var ContinentCountryPair in towns)
            {
                string continent = ContinentCountryPair.Key;
                var countryTownsDict = ContinentCountryPair.Value;
                Console.WriteLine($"{continent}:");

                foreach (var countryTownsPair in countryTownsDict)
                {
                    string country = countryTownsPair.Key;
                    var countryTowns = countryTownsPair.Value;

                    Console.WriteLine("  {0} -> {1}", country, string.Join(", ", countryTowns));
                }
            }
        }
    }
}
