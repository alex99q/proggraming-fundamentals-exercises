using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = numbers.Length / 4;

            var firstPartUpperNumbers = numbers
                .Take(k)
                .Reverse()
                .ToArray();

            var secondPartUpperNumbers = numbers
                .Reverse()
                .Take(k)
                .ToArray();

            var upperRow = firstPartUpperNumbers
                .Concat(secondPartUpperNumbers)
                .ToArray();

            var lowerRow = numbers
                .Skip(k)
                .Take(2 * k)
                .ToArray();

            int[] result = new int[upperRow.Length];

            for (int i = 0; i < upperRow.Length; i++)
            {
                result[i] = upperRow[i] + lowerRow[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}