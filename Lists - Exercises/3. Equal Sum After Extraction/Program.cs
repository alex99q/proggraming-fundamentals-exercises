using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Equal_Sum_After_Extraction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            foreach (int number in firstList)
            {
                while (secondList.Contains(number))
                {
                    secondList.Remove(number);
                }
            }

            int sumOfFirstList = firstList.Sum();
            int sumOfSecondList = secondList.Sum();

            if (sumOfFirstList == sumOfSecondList)
            {
                Console.WriteLine($"Yes. Sum: {sumOfFirstList}");
            }
            else if (sumOfFirstList != sumOfSecondList)
            {
                int absoluteDifference = Math.Abs(sumOfFirstList - sumOfSecondList);
                Console.WriteLine($"No. Diff: {absoluteDifference}");
            }
        }
    }
}
