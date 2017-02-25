using System;
using System.Linq;

namespace _4.Sort_Array_Using_Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool isSorted = false;

            do
            {
                isSorted = false;

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    int currentNumber = numbers[i];
                    int nextNumber = numbers[i + 1];

                    if (currentNumber > nextNumber)
                    {
                        numbers[i] = nextNumber;
                        numbers[i + 1] = currentNumber;

                        isSorted = true;
                    }
                }

            } while (isSorted);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
