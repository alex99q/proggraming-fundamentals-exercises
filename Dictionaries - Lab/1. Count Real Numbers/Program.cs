using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();

            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                double key = input[i];

                if (counts.ContainsKey(key))
                {
                    counts[key]++;
                }
                else if (!counts.ContainsKey(key))
                {
                    counts[key] = 1;
                }
            }

            foreach (var key in counts.Keys)
            {
                string timeOrTimes = counts[key] == 1 ? "time" : "times";

                Console.WriteLine($"{key} -> {counts[key]} {timeOrTimes}");
            }
        }
    }
}
