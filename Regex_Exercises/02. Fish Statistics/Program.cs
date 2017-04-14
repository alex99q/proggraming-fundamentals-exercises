using System;
using System.Text.RegularExpressions;

namespace _02.Fish_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(>*)<(\(+)(['\-x])>";

            Regex regex = new Regex(pattern);

            if (regex.IsMatch(input))
            {
                MatchCollection matches = regex.Matches(input);

                int fishCount = 0;
                foreach (Match fish in matches)
                {
                    fishCount++;

                    Console.WriteLine($"Fish {fishCount}: {fish.Value}");

                    Console.Write("Tail type: ");

                    string type = string.Empty;
                    int lenght = 0;

                    FindTailLenght(fish, out type, out lenght);

                    if (lenght == 0)
                    {
                        Console.WriteLine("None");
                    }
                    else
                    {
                        Console.WriteLine($"{type} ({lenght * 2} cm)");
                    }

                    Console.Write("Body type: ");

                    FindBodyLenght(fish, out type, out lenght);

                    Console.WriteLine($"{type} ({lenght * 2} cm)");

                    Console.WriteLine("Status: {0}", FishStatus(fish));
                }
            }
            else
            {
                Console.WriteLine("No fish found.");
            }
            
        }

        private static string FishStatus(Match fish)
        {
            string status = fish.Groups[3].ToString();
            if (status == "'")
            {
                status = "Awake";
            }
            else if (status == "-")
            {
                status = "Asleep";
            }
            else if (status == "x")
            {
                status = "Dead";
            }

            return status;
        }

        private static void FindBodyLenght(Match fish, out string bodyType, out int bodyLenght)
        {
            bodyLenght = fish.Groups[2].Length;
            if (bodyLenght > 10)
            {
                bodyType = "Long";
            }
            else if (bodyLenght > 5)
            {
                bodyType = "Medium";
            }
            else
            {
                bodyType = "Short";
            }
        }

        private static void FindTailLenght(Match fish, out string tailType, out int tailLenght)
        {
            tailType = string.Empty;
            tailLenght = fish.Groups[1].Length;
            if (tailLenght == 1)
            {
                tailType = "Short";
            }
            else if (tailLenght > 5)
            {
                tailType = "Long";
            }
            else if (tailLenght > 1)
            {
                tailType = "Medium";
            }
        }
    }
}
