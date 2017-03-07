using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Letter_Repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> lettersCount = new Dictionary<char, int>();

            foreach (var letter in input)
            {
                if (!lettersCount.ContainsKey(letter))
                {
                    lettersCount[letter] = 0;
                }

                lettersCount[letter]++;
            }

            foreach (KeyValuePair<char, int> kvp in lettersCount)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
