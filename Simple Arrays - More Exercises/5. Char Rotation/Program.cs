using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Char_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] inputChars = Console.ReadLine().ToCharArray();
            int[] inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            char[] result = new char[inputChars.Length];
            for (int i = 0; i < inputChars.Length; i++)
            {
                int currentNumber = inputNumbers[i];
                int currentChar = inputChars[i];

                if (currentNumber % 2 == 0)
                {
                    result[i] = (char)(currentChar - currentNumber);
                }
                else
                {
                    result[i] = (char)(currentChar + currentNumber);
                }
            }

            foreach (char character in result)
            {
                Console.Write(character);
            }
            Console.WriteLine();

        }
    }
}
