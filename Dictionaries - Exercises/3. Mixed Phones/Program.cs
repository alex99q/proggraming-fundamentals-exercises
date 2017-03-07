using System;
using System.Collections.Generic;

namespace _3.Mixed_Phones
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, long> namePhoneDict = new SortedDictionary<string, long>();

            string input = Console.ReadLine();
            while (input != "Over")
            {
                string[] inputTokens = input.Split(" :".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                string firstElement = inputTokens[0];
                string secondElement = inputTokens[1];

                long number = 0;
                if (long.TryParse(firstElement, out number))
                {
                    namePhoneDict[secondElement] = number;
                }

                else
                {
                    namePhoneDict[firstElement] = long.Parse(secondElement);
                }

                input = Console.ReadLine();
            }

            foreach (var namePhonePair in namePhoneDict)
            {
                string name = namePhonePair.Key;
                long phone = namePhonePair.Value;

                Console.WriteLine($"{name} -> {phone}");
            }
        }
    }
}
