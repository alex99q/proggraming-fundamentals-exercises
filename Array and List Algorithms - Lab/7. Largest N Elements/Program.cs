using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.Largest_N_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> resultList = new List<int>();
            int n = int.Parse(Console.ReadLine());

            //Insertion Sort in to a List named resultList
            for (int arrIndex = 0; arrIndex < numbers.Length; arrIndex++)
            {
                bool inserted = false;
                int currentElement = numbers[arrIndex];

                for (int listIndex = 0; listIndex < resultList.Count; listIndex++)
                {
                    int currentListElement = resultList[listIndex];

                    if (currentElement <= currentListElement)
                    {
                        inserted = true;

                        resultList.Insert(listIndex, currentElement);

                        break;
                    }
                }

                if (!inserted)
                {
                    resultList.Add(currentElement);
                }
            }
            ////////////////////////////////////////////

            resultList.Reverse();
            var result = resultList.Take(n);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
