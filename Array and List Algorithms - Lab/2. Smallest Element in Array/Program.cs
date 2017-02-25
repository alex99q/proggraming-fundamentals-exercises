using System;
using System.Linq;

namespace _2.Smallest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int smallestNumber = int.MaxValue;

            foreach (var number in numbers)
            {
                if (number < smallestNumber)
                {
                    smallestNumber = number;
                }
            }

            Console.WriteLine(smallestNumber);
        }
    }
}
