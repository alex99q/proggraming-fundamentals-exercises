namespace _01.Reverse_String
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string reversedInput = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedInput = string.Concat(reversedInput, input[i].ToString());
            }

            Console.WriteLine(reversedInput);
        }
    }
}
