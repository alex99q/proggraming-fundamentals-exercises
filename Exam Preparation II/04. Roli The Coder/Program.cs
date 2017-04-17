using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\d) #(\w+?) ((?:@\w+? )+)";

            Regex inputRegex = new Regex(pattern);

            var eventsDict = new Dictionary<int, Dictionary<string, List<string>>>();
            var IdEventDict = new Dictionary<int, string>();

            string input = Console.ReadLine();
            while (input != "Time for Code")
            {
                Match inputMatch = inputRegex.Match((input + " "));

                if (!inputMatch.Success)
                {
                    input = Console.ReadLine();
                    continue;
                }

                int ID = int.Parse(inputMatch.Groups[1].ToString());
                string eventName = inputMatch.Groups[2].ToString();
                string unparsedParticipants = inputMatch.Groups[3].ToString().Trim();

                List<string> participants = unparsedParticipants
                    .Split(' ')
                    .Select(n => n.TrimStart('@'))
                    .ToList();

                if (!eventsDict.ContainsKey(ID))
                {
                    eventsDict[ID] = new Dictionary<string, List<string>>();

                    IdEventDict[ID] = eventName;
                }

                if (IdEventDict[ID] == eventName)
                {
                    if (!eventsDict[ID].ContainsKey(eventName))
                    {
                        eventsDict[ID][eventName] = new List<string>();
                    }

                    foreach (var participant in participants)
                    {
                        if (!eventsDict[ID][eventName].Contains(participant))
                        {
                            eventsDict[ID][eventName].Add(participant);
                        }
                    }
                }
                else
                {
                    input = Console.ReadLine();
                    continue;
                }

                eventsDict[ID] = eventsDict[ID]
                    .OrderByDescending(n => n.Value.Count)
                    .ThenBy(n => n)
                    .ToDictionary(n => n.Key, n => new List<string>(n.Value));

                input = Console.ReadLine();
            }

            foreach (var eventParticipantsPair in eventsDict)
            {
                string eventName = eventParticipantsPair.Key;
            }
        }
    }
}
