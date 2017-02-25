using System;
using System.Linq;

namespace _5.Sort_Array_Using_Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int j = i + 1;

                while (j > 0)
                {
                    if (numbers[j] < numbers[j - 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j - 1];
                        numbers[j - 1] = temp;
                    }

                    j--;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
