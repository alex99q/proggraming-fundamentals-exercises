using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Array_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            List<string> strings = new List<string>();
            List<int> countOfStrings = new List<int>();

            //Adds the uniqe words into strings[] and the amount of them in countOfStrings[]
            for (int i = 0; i < input.Length; i++)
            {
                string currentWord = input[i];

                if (!strings.Contains(currentWord))
                {
                    strings.Add(currentWord);
                    countOfStrings.Add(1);
                }
                else
                {
                    int stringIndex = strings.IndexOf(currentWord);
                    countOfStrings[stringIndex] += 1;
                }
            }

            //Sorts strings[] and countOfStrings using insertion sort
            for (int i = 0; i < countOfStrings.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    int currentCount = countOfStrings[j];
                    int prevCount = countOfStrings[j - 1];

                    if (currentCount > prevCount)
                    {
                        countOfStrings[j - 1] = currentCount;
                        countOfStrings[j] = prevCount;

                        string temp = strings[j - 1];
                        strings[j - 1] = strings[j];
                        strings[j] = temp;
                    }
                }
            }

            //prints strings[] and countOfStrings[]
            for (int i = 0; i < countOfStrings.Count; i++)
            {
                int currentCount = countOfStrings[i];
                string currentWord = strings[i];
                double currentChanse = ((double)currentCount / input.Count()) * 100;

                Console.WriteLine("{0} -> {1} times ({2:F2}%)", currentWord, currentCount, currentChanse);
            }
        }
    }
}
