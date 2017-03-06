using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split();
            Dictionary<string, int> counts = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                string key = input[i];

                if (!counts.ContainsKey(key))
                {
                    counts.Add(key, 1);
                }
                else
                {
                    counts[key]++;
                }
            }

            List<string> result = new List<string>();
            foreach (var kvp in counts)
            {
                if (kvp.Value % 2 != 0)
                {
                    result.Add(kvp.Key);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
