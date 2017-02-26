using System;

namespace _3.Sort_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    string currentString = input[j];
                    string prevString = input[j - 1];

                    if (currentString.CompareTo(prevString) < 0)
                    {
                        input[j - 1] = currentString;
                        input[j] = prevString;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
