using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine()
                .Split(',')
                .Select(n => n.Trim())
                .ToArray();

            string[] songs = Console.ReadLine()
                .Split(',')
                .Select(n => n.Trim())
                .ToArray();

            var participantAwardsDict = new Dictionary<string, HashSet<string>>();

            string inputLine = Console.ReadLine();
            while (inputLine != "dawn")
            {
                string[] inputParameters = inputLine
                    .Split(',')
                    .Select(n => n.Trim())
                    .ToArray();

                string participant = inputParameters[0];
                string song = inputParameters[1];
                string award = inputParameters[2];

                if (songs.Contains(song) && participants.Contains(participant))
                {
                    if (!participantAwardsDict.ContainsKey(participant))
                    {
                        participantAwardsDict[participant] = new HashSet<string>();
                    }

                    participantAwardsDict[participant].Add(award);
                }

                inputLine = Console.ReadLine();
            }

            if (!participantAwardsDict.Any())
            {
                Console.WriteLine("No awards");
            }
            else
            {
                participantAwardsDict = participantAwardsDict
                    .OrderByDescending(n => n.Value.Count)
                    .ThenBy(n => n.Key)
                    .ToDictionary(n => n.Key, n => n.Value);

                foreach (var participantAwardPair in participantAwardsDict)
                {
                    string participant = participantAwardPair.Key;
                    HashSet<string> awards = participantAwardPair.Value;

                    Console.WriteLine($"{participant}: {awards.Count} awards");

                    foreach (var award in awards.OrderBy(a => a))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
        }
    }
}
