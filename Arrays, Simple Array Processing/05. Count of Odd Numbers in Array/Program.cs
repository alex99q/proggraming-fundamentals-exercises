namespace _05.Count_of_Odd_Numbers_in_Array
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int oddElements = 0;
            int[] numbers = input.Split(
                    new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    oddElements++;
                }
            }

            Console.WriteLine(oddElements);
        }
    }
}
