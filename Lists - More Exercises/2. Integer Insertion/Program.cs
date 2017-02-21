using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Integer_Insertion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> result = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                int firstDigit = input[0] - '0';
                result.Insert(firstDigit, int.Parse(input));
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
