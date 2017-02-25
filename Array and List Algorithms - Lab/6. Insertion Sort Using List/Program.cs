namespace _6.Insertion_Sort_Using_List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                int j = i + 1;

                while (j > 0)
                {
                    if (numbers[j] < numbers[j - 1])
                    {
                        numbers.Insert(j - 1, numbers[j]);
                        numbers.RemoveAt(j + 1);
                    }

                    j--;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
