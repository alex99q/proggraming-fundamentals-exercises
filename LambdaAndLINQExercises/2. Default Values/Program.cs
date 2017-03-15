using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Default_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, string> inputValues = new Dictionary<string, string>();

            while (input != "end")
            {
                string[] inputTokens = input.Split("-> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                string key = inputTokens[0];
                string value = inputTokens[1];

                inputValues[key] = value;

                input = Console.ReadLine();
            }

            string defaultValue = Console.ReadLine();

            Dictionary<string, string> unchangedValues = inputValues
                .Where(n => n.Value != "null")
                .OrderByDescending(n => n.Value.Length)
                .ToDictionary(n => n.Key, n => n.Value);

            Dictionary<string, string> changedValues = inputValues
                .Where(n => n.Value == "null")
                .ToDictionary(n => n.Key, n => defaultValue);

            foreach (var kvp in unchangedValues)
            {
                Console.WriteLine("{0} <-> {1}", kvp.Key, kvp.Value);
            }

            foreach (var kvp in changedValues)
            {
                Console.WriteLine("{0} <-> {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
