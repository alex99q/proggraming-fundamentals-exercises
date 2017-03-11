using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Forum_Topics
{
    class Program
    {
        static void Main(string[] args)
        {
            var topicTagsDict = new Dictionary<string, HashSet<string>>();

            string input = Console.ReadLine();
            while (input != "filter")
            {
                string[] inputTokens = input.Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                string name = inputTokens[0].Trim();
                string[] tags = inputTokens[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                foreach (var tag in tags)
                {
                    AddTagToTopic(topicTagsDict, name, tag);
                }

                input = Console.ReadLine();
            }

            string[] allowedTags = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            foreach (var topicTagsPair in topicTagsDict)
            {
                string topic = topicTagsPair.Key;
                var tags = topicTagsPair.Value;
                bool isReadyToPrint = true;

                foreach (var allowedTag in allowedTags)
                {
                    if (!tags.Contains("#" + allowedTag))
                    {
                        isReadyToPrint = false;
                        break;
                    }
                }

                if (isReadyToPrint)
                {
                    Console.WriteLine("{0} | {1}", topic, string.Join(", ", tags));
                }
            }
        }

        private static void AddTagToTopic(Dictionary<string, HashSet<string>> topicTagsDict, string name, string tag)
        {
            if (!topicTagsDict.ContainsKey(name))
            {
                topicTagsDict[name] = new HashSet<string>();
            }
            topicTagsDict[name].Add("#" + tag);
        }
    }
}
