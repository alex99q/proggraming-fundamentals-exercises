using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Flatten_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> dictionary = new Dictionary<string, Dictionary<string, string>>();

            string input = Console.ReadLine();

            while(input != "end")
            {
                string[] inputTokens = input.Split();
                if (inputTokens.Length == 3)
                {
                    string key = inputTokens[0];
                    string innerKey = inputTokens[1];
                    string innerValue = inputTokens[2];

                    if (!dictionary.ContainsKey(key))
                    {
                        dictionary[key] = new Dictionary<string, string>();
                    }

                    dictionary[key][innerKey] = innerValue;
                }
                else
                {
                    string command = inputTokens[0];
                    string key = inputTokens[1];

                    dictionary[key] = 
                        dictionary[key]
                            .ToDictionary(n => n.Key + n.Value, n => command);
                }

                input = Console.ReadLine();
            }

            dictionary = 
                dictionary
                    .OrderByDescending(n => n.Key.Length)
                    .ToDictionary(n => n.Key, n => n.Value);

            foreach (var KeyDictPair in dictionary)
            {
                string key = KeyDictPair.Key;

                Console.WriteLine(key);

                var dict = 
                    dictionary[key]
                        .Where(n => n.Value != "flatten")
                        .OrderBy(n => n.Key.Length)
                        .ToDictionary(n => n.Key, n => n.Value);

                var flattenedDict = 
                    dictionary[key]
                        .Where(n => n.Value == "flatten")
                        .ToDictionary(n => n.Key, n => n.Value);

                int counter = 1;

                foreach (var kvp in dict)
                {
                    Console.WriteLine("{0}. {1} - {2}", counter, kvp.Key, kvp.Value);

                    counter++;
                }

                foreach (var kvp in flattenedDict)
                {
                    Console.WriteLine("{0}. {1}", counter, kvp.Key);

                    counter++;
                }
            }
        }
    }
}
