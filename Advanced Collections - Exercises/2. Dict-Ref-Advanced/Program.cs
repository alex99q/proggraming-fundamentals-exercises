using System;
using System.Collections.Generic;

namespace _2.Dict_Ref_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> nameValuesDict = new Dictionary<string, List<int>>();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputTokens = input.Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                string name = inputTokens[0].Trim();
                string[] values = inputTokens[1].Split(" ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string referencedName = values[0];

                int parsedNumber = 0;
                if (int.TryParse(referencedName, out parsedNumber))
                {
                    foreach (var number in values)
                    {
                        int value = int.Parse(number);
                        AddValueToName(nameValuesDict, name, value);
                    }
                }
                else
                {
                    if (nameValuesDict.ContainsKey(referencedName))
                    {
                        nameValuesDict[name] = new List<int>(nameValuesDict[referencedName]);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var nameValuesPair in nameValuesDict)
            {
                string name = nameValuesPair.Key;
                var values = nameValuesPair.Value;

                Console.WriteLine("{0} === {1}", name, string.Join(", ", values));
            }
        }

        private static void AddValueToName(Dictionary<string, List<int>> nameValuesDict, string name, int value)
        {
            if (!nameValuesDict.ContainsKey(name))
            {
                nameValuesDict[name] = new List<int>();
            }
            nameValuesDict[name].Add(value);
        }
    }
}

