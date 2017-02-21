namespace _5.Tear_List_in_Half
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();

            for (int i = 0, j = input.Count / 2; i < input.Count / 2; i++, j++)
            {
                    int currentLeftNumber = input[i];
                    int currentRightNumber = input[j];

                    result.Add(currentRightNumber / 10);
                    result.Add(currentLeftNumber);
                    result.Add(currentRightNumber % 10);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
