using System;
using System.Text.RegularExpressions;

namespace _01.Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();

            Regex regex = new Regex(Regex.Escape(pattern));
            MatchCollection matches = regex.Matches(input);

            while (true)
            {
                if (matches.Count >= 2 && pattern.Length > 0)
                {
                    int startIndex = input.IndexOf(pattern);
                    int lastIndex = input.LastIndexOf(pattern) - pattern.Length;

                    input = input.Remove(startIndex, pattern.Length);
                    input = input.Remove(lastIndex, pattern.Length);

                    pattern = pattern.Remove(pattern.Length / 2, 1);

                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    Console.WriteLine("No shake.");
                    break;
                }

                regex = new Regex(Regex.Escape(pattern));
                matches = regex.Matches(input);
            }

            Console.WriteLine(input);
        }
    }
}
