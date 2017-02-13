using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Last_3_Consecutive_Equal_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            string[] result = new string[3];

            for (int i = 0; i < words.Length - 2; i++)
            {
                if (words[i] == words[i + 1] && words[i] == words[i + 2])
                {
                    for (int j = 0, k = i; j < result.Length; j++, k++)
                    {
                        result[j] = words[k];
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
