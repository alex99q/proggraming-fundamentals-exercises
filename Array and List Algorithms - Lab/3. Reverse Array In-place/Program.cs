using System;
using System.Linq;

namespace _3.Reverse_Array_In_place
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0, j = numbers.Length - 1; i < numbers.Length / 2; i++, j--)
            {
                int temp = numbers[i];

                numbers[i] = numbers[j];
                numbers[j] = temp;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
