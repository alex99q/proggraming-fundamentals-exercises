using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            Regex regex = new Regex(@"(\D+)(\d+)");
            MatchCollection matches = regex.Matches(inputLine);

            StringBuilder stringBuilderResult = new StringBuilder();

            foreach (Match match in matches)
            {
                string partition = match.Groups[1].Value;
                int times = int.Parse(match.Groups[2].Value);

                stringBuilderResult.Append(Repeat(partition, times).ToUpper());
            }

            string result = stringBuilderResult.ToString();

            int distinctSymbolsCount = result.Distinct().Count();

            Console.WriteLine($"Unique symbols used: {distinctSymbolsCount}");
            Console.WriteLine(result);
        }

        private static string Repeat(string partition, int times)
        {
            StringBuilder final = new StringBuilder();

            for (int i = 0; i < times; i++)
            {
                final.Append(partition);
            }

            return final.ToString();
        }
    }
}
