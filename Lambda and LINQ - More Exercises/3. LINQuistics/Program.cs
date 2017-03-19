using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LINQuistics
{
    class LINQuistics
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            var collectionDict = new Dictionary<string, HashSet<string>>();

            while (!inputLine.Equals("exit"))
            {
                var dataLine = inputLine.Split(new char[] { '.', ')', '(' }, StringSplitOptions.RemoveEmptyEntries);
                var collection = dataLine[0];

                if (inputLine.Contains("."))
                { 
                    if (!collectionDict.ContainsKey(collection))
                    {
                        collectionDict[collection] = new HashSet<string>();
                    }
                    for (int i = 1; i < dataLine.Length; i++)
                    {
                        collectionDict[collection].Add(dataLine[i]);
                    }
                }
                else
                {
                    if (collectionDict.ContainsKey(collection))
                    {
                        int number = 0;
                        if (Int32.TryParse(inputLine, out number))
                        {
                            foreach (var methodName in collectionDict.Values
                                .OrderByDescending(x => x.Count()).First()
                                .OrderBy(x => x.Length).Take(number))
                            {
                                Console.WriteLine($"* {methodName}");
                            }
                        }
                        else if (collectionDict.ContainsKey(inputLine))
                        {
                            var result = collectionDict[inputLine]
                                .OrderByDescending(x => x.Length)
                                .ThenByDescending(x => x.Distinct().Count())
                                .ToList();
                            foreach (var methodName in result)
                            {
                                Console.WriteLine($"* {methodName}");
                            }
                        }
                    }                
                }

                inputLine = Console.ReadLine();
            }

            string[] commandLine = Console.ReadLine().Split();
            var method = commandLine[0];
            var selection = commandLine[1];

            if (commandLine.Contains("all"))
            {
                foreach (var collection in collectionDict.Where(x => x.Value.Contains(method))
                    .OrderByDescending(x => x.Value.Count())
                    .ThenByDescending(x => x.Value.Min(y => y.Length)))
                {
                    Console.WriteLine(collection.Key);
                    foreach (var methodName in collection.Value.OrderByDescending(x => x.Count()))
                    {
                        Console.WriteLine($"* {methodName}");
                    }
                }
            }
            else
            {
                foreach (var collection in collectionDict.Where(x => x.Value.Contains(method))
                    .OrderBy(x => x.Key.Count())
                    .ThenByDescending(x => x.Value.Min(y => y.Length)))
                {
                    Console.WriteLine(collection.Key);
                }
            }
        }
    }
}