using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Shellbound
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<long>> cityandShellSizesDict = new Dictionary<string, HashSet<long>>();

            string input = Console.ReadLine();
            
            while(input != "Aggregate")
            {
                string[] inputTokens = input.Split();

                string city = inputTokens[0];
                long shellSize = long.Parse(inputTokens[1]);

                if (!cityandShellSizesDict.ContainsKey(city))
                {
                    cityandShellSizesDict[city] = new HashSet<long>();
                }
                cityandShellSizesDict[city].Add(shellSize);

                input = Console.ReadLine();
            }

            foreach (var cityandShellSizesPair in cityandShellSizesDict)
            {
                string city = cityandShellSizesPair.Key;
                HashSet<long> shellSizes = cityandShellSizesPair.Value;
                long giantShell = 0;

                if (shellSizes.Count > 1)
                {
                    giantShell = (long)Math.Ceiling(shellSizes.Sum() - shellSizes.Average());
                }
                else
                {
                    giantShell = shellSizes.Sum();
                }

                Console.WriteLine("{0} -> {1} ({2})", city, string.Join(", ", shellSizes), giantShell);
            }
        }
    }
}
