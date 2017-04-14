using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03.Word_Encounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string filter = Console.ReadLine();

            string sentence = Console.ReadLine();
            Regex sentenceRegex = new Regex(@"[A-Z].*[.!?]");

            List<string> filteredWords = new List<string>();

            while(sentence != "end")
            {
                if (sentence == sentenceRegex.Match(sentence).ToString())
                {
                    Regex wordRegex = new Regex(@"\w+");
                    MatchCollection words = wordRegex.Matches(sentence);

                    char filterChar = filter[0];
                    int filterDigit = int.Parse(filter[1].ToString());

                    foreach (Match word in words)
                    {
                        int charCount = 0;
                        foreach (var character in word.Value)
                        {
                            if (character == filterChar)
                            {
                                charCount++;
                            }
                        }

                        if (charCount >= filterDigit)
                        {
                            filteredWords.Add(word.Value);
                        }
                    }
                }

                sentence = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", filteredWords));
        }
    }
}
