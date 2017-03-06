namespace _3.Increasing_Crisis
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> resultingList = new List<int>();

            for (int i = 0; i < n; i++)
            {
                List<int> numbersToInsert = Console.ReadLine().Split().Select(int.Parse).ToList();

                if (resultingList.Count == 0)
                {
                    resultingList = new List<int>(numbersToInsert);
                }

                else
                {
                    for (int j = 0; j < numbersToInsert.Count - 1; j++)
                    {
                        if (numbersToInsert[j] > numbersToInsert[j + 1])
                        {
                            numbersToInsert.RemoveRange(j + 1, Math.Max(j + 1, numbersToInsert.Count) - Math.Min(j + 1, numbersToInsert.Count));
                        }
                    }

                    for (int indexOfResultingList = resultingList.Count - 1; indexOfResultingList > 0; indexOfResultingList--)
                    {
                        if (resultingList[indexOfResultingList] <= numbersToInsert[0])
                        {
                            resultingList.InsertRange(indexOfResultingList + 1, numbersToInsert);
                            break;
                        }
                    }

                    for (int j = 0; j < resultingList.Count - 1; j++)
                    {
                        if (resultingList[j] > resultingList[j + 1])
                        {
                            resultingList.RemoveRange(j + 1, Math.Max(resultingList.Count, j + 1) - Math.Min(resultingList.Count, j + 1));
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", resultingList));
        }
    }
}
