using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Equal_Sequence_of_Elements_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i + 1] != numbers[i])
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            Console.WriteLine("Yes");
        }
    }
}
