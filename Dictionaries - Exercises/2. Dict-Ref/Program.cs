using System;
using System.Collections.Generic;

namespace _2.Dict_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resultDict = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputTokens = input.Split();

                string name = inputTokens[0];
                string value = inputTokens[inputTokens.Length - 1];

                int number = 0;
                if (int.TryParse(value, out number))
                {
                    resultDict[name] = number;
                }

                else
                {
                    if (resultDict.ContainsKey(value))
                    {
                        resultDict[name] = resultDict[value];
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var nameValuePair in resultDict)
            {
                string name = nameValuePair.Key;
                int value = nameValuePair.Value;

                Console.WriteLine($"{name} === {value}");
            }
        }
    }
}
