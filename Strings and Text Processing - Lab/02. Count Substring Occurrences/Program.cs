using System;

namespace _02.Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string substring = Console.ReadLine().ToLower();

            int index = input.IndexOf(substring);
            int counter = 0;
            while (index != -1)
            {
                index = input.IndexOf(substring, index + 1);

                counter++;
            }

            Console.WriteLine(counter);
        }
    }
}
