using System;

namespace _7.Greater_of_Two_Values
{
    class Program
    {
        public static void Main()
        {
            string type = Console.ReadLine().ToLower();

            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(first, second));
            }

            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(first, second));
            }

            else if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();

                Console.WriteLine(GetMax(first, second));
            }
        }

        static int GetMax(int firstNumber, int secondNumber)
        {
            if (firstNumber >= secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }

        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static char GetMax(char first, char second)
        {
            if (first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

    }
}
