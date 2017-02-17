using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|');
            List<string> result = new List<string>();

            Array.Reverse(input);

            foreach (string token in input)
            {
                string[] numbers = token.Split();

                foreach (var item in numbers)
                {
                    if (item != " ")
                    {
                        result.Add(item);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
