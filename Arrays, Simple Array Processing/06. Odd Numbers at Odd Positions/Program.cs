using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Odd_Numbers_at_Odd_Positions
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
                if (numbers[i] % 2 != 0 && i % 2 != 0)
                {
                    Console.WriteLine($"Index {i} -> {numbers[i]}");    
                }
            }
        }
    }
}
