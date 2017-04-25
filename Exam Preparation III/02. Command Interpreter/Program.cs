using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> array = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] inputParameters = inputLine.Split();

                string command = inputParameters[0];

                switch (command)
                {
                    case "reverse":
                        int reverseStart = int.Parse(inputParameters[2]);
                        int reverseCount = int.Parse(inputParameters[4]);

                        if (IsValid(array, reverseStart, reverseCount))
                        {
                            Reverse(array, reverseStart, reverseCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;

                    case "sort":
                        int sortStart = int.Parse(inputParameters[2]);
                        int sortCount = int.Parse(inputParameters[4]);

                        if (IsValid(array, sortStart, sortCount))
                        {
                            Sort(array, sortStart, sortCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;

                    case "rollLeft":
                        int rollLeftCount = int.Parse(inputParameters[1]);

                        if (rollLeftCount >= 0)
                        {
                            rollLeft(array, rollLeftCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;

                    case "rollRight":
                        int rollRightCount = int.Parse(inputParameters[1]);

                        if (rollRightCount >= 0)
                        {
                            rollRight(array, rollRightCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;

                    default:
                        break;
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        private static bool IsValid(List<string> array, int start, int count)
        {
            bool result = start >= 0 && start < array.Count && count >= 0 && (start + count) <= array.Count;

            return result;
        }

        private static void Reverse(List<string> array, int reverseStart, int reverseCount)
        {
            array.Reverse(reverseStart, reverseCount);
        }

        private static void Sort(List<string> array, int sortStart, int sortCount)
        {
            array.Sort(sortStart, sortCount, null);
        }

        private static void rollLeft(List<string> array, int rollLeftCount)
        {
            int rotations = rollLeftCount % array.Count;

            for (int i = 0; i < rotations; i++)
            {
                for (int j = 0; j < array.Count - 1; j++)
                {
                    string temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }

        private static void rollRight(List<string> array, int rollRightCount)
        {
            int rotations = rollRightCount % array.Count;

            for (int i = 0; i < rotations; i++)
            {
                for (int j = array.Count - 2; j >= 0; j--)
                {
                    string temp = string.Empty;

                    if (j == 0)
                    {
                        temp = array[array.Count - 1];
                        array[array.Count - 1] = array[j];
                        array[j] = temp;
                    }
                    else
                    {
                        temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
