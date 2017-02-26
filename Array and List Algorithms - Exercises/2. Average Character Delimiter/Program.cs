using System;

namespace _2.Average_Character_Delimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int sum = 0;
            int countOfChars = 0;

            foreach (var word in input)
            {
                foreach (var character in word)
                {
                    sum += character;
                    countOfChars++;
                }
            }

            string delimiter = ((char)(sum / countOfChars)).ToString();
            delimiter = delimiter.ToUpper();

            Console.WriteLine(string.Join(delimiter, input));
        }
    }
}
