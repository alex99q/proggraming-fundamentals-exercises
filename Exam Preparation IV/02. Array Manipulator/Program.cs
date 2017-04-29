using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Array_Manipulator
{
    class Program
    {
        static void Main()
        {
            var inputArray = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            string inputLine = Console.ReadLine();
            while (inputLine != "end")
            {
                var inputParameters = inputLine.Split(' ').ToArray();

                if (inputParameters[0] == "exchange")
                {
                    int indexForExchange = int.Parse(inputParameters[1]);
                    if (indexForExchange >= 0 && indexForExchange < inputArray.Count)
                    {
                        inputArray = new List<long>(Exchange(inputArray, (indexForExchange + 1)));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (inputParameters[0] == "max")
                {
                    long maxIndex = GetMaxIndex(inputArray, inputParameters[1]);

                    if (maxIndex == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(maxIndex);
                    }
                }
                else if (inputParameters[0] == "min")
                {
                    long minIndex = GetMinIndex(inputArray, inputParameters[1]);

                    if (minIndex == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(minIndex);
                    }
                }
                else if (inputParameters[0] == "first")
                {
                    long count = long.Parse(inputParameters[1]);
                    string evenOrOdd = inputParameters[2];

                    Console.WriteLine(FirstNumbers(inputArray, count, evenOrOdd));
                }
                else if (inputParameters[0] == "last")
                {
                    long count = long.Parse(inputParameters[1]);
                    string evenOrOdd = inputParameters[2];

                    Console.WriteLine(LastNumbers(inputArray, count, evenOrOdd));
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", inputArray)}]");
        }

        private static string FirstNumbers(List<long> inputArray, long count, string evenOrOdd)
        {
            if (count > inputArray.Count)
            {
                return "Invalid count";
            }

            if (evenOrOdd == "even")
            {
                return FirstEvenNumbers(inputArray, count);
            }
            else
            {
                return FirstOddNumbers(inputArray, count);
            }

        }

        private static string FirstOddNumbers(List<long> inputArray, long count)
        {
            List<long> oddNumbers = new List<long>();

            for (int indexOfinputArray = 0; indexOfinputArray < inputArray.Count; indexOfinputArray++)
            {
                if (oddNumbers.Count == count)
                {
                    break;
                }

                if (inputArray[indexOfinputArray] % 2 != 0)
                {
                    oddNumbers.Add(inputArray[indexOfinputArray]);
                }
            }

            return $"[{string.Join(", ", oddNumbers)}]";
        }

        private static string FirstEvenNumbers(List<long> inputArray, long count)
        {
            List<long> evenNumbers = new List<long>();

            for (int indexOfinputArray = 0; indexOfinputArray < inputArray.Count; indexOfinputArray++)
            {
                if (evenNumbers.Count == count)
                {
                    break;
                }

                if (inputArray[indexOfinputArray] % 2 == 0)
                {
                    evenNumbers.Add(inputArray[indexOfinputArray]);
                }
            }

            return $"[{string.Join(", ", evenNumbers)}]";
        }

        private static string LastNumbers(List<long> inputArray, long count, string evenOrOdd)
        {
            if (count > inputArray.Count)
            {
                return "Invalid count";
            }

            if (evenOrOdd == "even")
            {
                return LastEvenNumbers(inputArray, count);
            }
            else
            {
                return LastOddNumbers(inputArray, count);
            }

        }

        private static string LastOddNumbers(List<long> inputArray, long count)
        {
            List<long> oddNumbers = new List<long>();

            for (int indexOfinputArray = inputArray.Count - 1; indexOfinputArray >= 0; indexOfinputArray--)
            {
                if (oddNumbers.Count == count)
                {
                    break;
                }

                if (inputArray[indexOfinputArray] % 2 != 0)
                {
                    oddNumbers.Add(inputArray[indexOfinputArray]);
                }
            }

            return $"[{string.Join(", ", oddNumbers)}]";
        }

        private static string LastEvenNumbers(List<long> inputArray, long count)
        {
            List<long> evenNumbers = new List<long>();

            for (int indexOfinputArray = inputArray.Count - 1; indexOfinputArray >= 0; indexOfinputArray--)
            {
                if (evenNumbers.Count == count)
                {
                    break;
                }

                if (inputArray[indexOfinputArray] % 2 == 0)
                {
                    evenNumbers.Add(inputArray[indexOfinputArray]);
                }
            }

            return $"[{string.Join(", ", evenNumbers)}]";
        }

        private static long GetMinIndex(List<long> inputArray, string evenOrOdd)
        {
            if (evenOrOdd == "even")
            {
                return GetMinEvenIndex(inputArray);
            }
            else if (evenOrOdd == "odd")
            {
                return GetMinOddIndex(inputArray);
            }
            else
            {
                return -1;
            }
        }

        private static long GetMinOddIndex(List<long> inputArray)
        {
            long oddNumberIndex = -1;
            long minNumber = long.MaxValue;
            for (int i = 0; i < inputArray.Count; i++)
            {
                if (inputArray[i] % 2 != 0 && inputArray[i] <= minNumber)
                {
                    minNumber = inputArray[i];
                    oddNumberIndex = i;
                }
            }

            return oddNumberIndex;
        }

        private static long GetMinEvenIndex(List<long> inputArray)
        {
            long evenNumberIndex = -1;
            long minNumber = long.MaxValue;
            for (int i = 0; i < inputArray.Count; i++)
            {
                if (inputArray[i] % 2 == 0 && inputArray[i] <= minNumber)
                {
                    minNumber = inputArray[i];
                    evenNumberIndex = i;
                }
            }

            return evenNumberIndex;
        }

        private static long GetMaxIndex(List<long> inputArray, string evenOrOdd)
        {
            if (evenOrOdd == "even")
            {
                return GetMaxEvenIndex(inputArray);
            }
            else if (evenOrOdd == "odd")
            {
                return GetMaxOddIndex(inputArray);
            }
            else
            {
                return -1;
            }
        }

        private static long GetMaxOddIndex(List<long> inputArray)
        {
            long oddNumberIndex = -1;
            long maxNumber = long.MinValue;
            for (int i = 0; i < inputArray.Count; i++)
            {
                if (inputArray[i] % 2 != 0 && inputArray[i] >= maxNumber)
                {
                    maxNumber = inputArray[i];
                    oddNumberIndex = i;
                }
            }

            return oddNumberIndex;
        }

        private static long GetMaxEvenIndex(List<long> inputArray)
        {
            long evenNumberIndex = -1;
            long maxNumber = long.MinValue;
            for (int i = 0; i < inputArray.Count; i++)
            {
                if (inputArray[i] % 2 == 0 && inputArray[i] >= maxNumber)
                {
                    maxNumber = inputArray[i];
                    evenNumberIndex = i;
                }
            }

            return evenNumberIndex;
        }

        private static List<long> Exchange(List<long> inputArray, int indexforExchange)
        {
            var leftPart = inputArray.Take(indexforExchange);
            var rightPart = inputArray.Skip(indexforExchange);

            inputArray = rightPart.Concat(leftPart).ToList();

            return inputArray;
        }
    }
}
