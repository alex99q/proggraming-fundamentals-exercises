namespace _7.Count_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            numbers.Sort();
            numbers.Add(int.MaxValue);

            int counter = 1;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine($"{numbers[i]} -> {counter}");
                    counter = 1;
                }
            }

            //List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //int[] count = new int[1001];

            //foreach (var number in numbers)
            //{
            //    count[number]++;
            //}

            //for (int i = 0; i < count.Length; i++)
            //{
            //    if (count[i] > 0)
            //    {
            //        Console.WriteLine($"{i} -> {count[i]}");
            //    }
            //}

            //List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            //nums.Sort();

            //var pos = 0;

            //while (pos < nums.Count)
            //{

            //    int num = nums[pos], count = 1;

            //    while (pos + count < nums.Count && nums[pos + count] == num)
            //    {
            //        count++;
            //    }

            //    pos = pos + count;

            //    Console.WriteLine($"{num} -> {count}");

            //}
        }
    }
}
