namespace _4.Flip_List_Sides
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 1, j = input.Count - 2; i <= (input.Count - 1) / 2; i++, j--)
            {
                int savedNumber = 0;
                savedNumber = input[i];

                input[i] = input[j];
                input[j] = savedNumber;
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
