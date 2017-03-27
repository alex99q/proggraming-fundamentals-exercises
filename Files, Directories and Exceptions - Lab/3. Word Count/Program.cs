using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _3.Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputText = File.ReadAllText("../../../Resources/03. Word Count/text.txt")
                .ToLower()
                .Split(new char[] { '\n', '\r', ' ', '.', ',', '-', '?', '!' },
                StringSplitOptions.RemoveEmptyEntries);

            string[] inputWords = File.ReadAllText("../../../Resources/03. Word Count/words.txt").ToLower().Split(' ');

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            foreach (var word in inputWords)
            {
                wordsCount[word] = 0;
            }

            foreach (var word in inputText)
            {
                if (wordsCount.ContainsKey(word))
                {
                    wordsCount[word]++;
                }
            }

            wordsCount = wordsCount.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var wordCountPair in wordsCount)
            {
                File.AppendAllText("../../../Resources/03. Word Count/output.txt", wordCountPair.Key + " - " + wordCountPair.Value + Environment.NewLine);
            }
        }
    }
}
