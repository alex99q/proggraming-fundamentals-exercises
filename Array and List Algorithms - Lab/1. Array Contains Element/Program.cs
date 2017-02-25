using System;
using System.Linq;

namespace _1.Array_Contains_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            bool isFound = false;

            foreach (var number in numbers)
            {
                if (number == n)
                {
                    Console.WriteLine("yes");
                    isFound = true;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
