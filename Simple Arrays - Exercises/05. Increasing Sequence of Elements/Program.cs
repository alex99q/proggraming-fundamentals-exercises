using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Increasing_Sequence_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i > 0 && numbers [i - 1] > numbers[i])
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            Console.WriteLine("Yes");
        }
    }
}
