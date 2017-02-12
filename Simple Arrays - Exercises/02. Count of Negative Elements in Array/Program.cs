using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Count_of_Negative_Elements_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int numberOfNegativeNumbers = 0;
            foreach (var number in numbers)
            {
                if (number < 0)
                {
                    numberOfNegativeNumbers++;
                }
            }

            Console.WriteLine(numberOfNegativeNumbers);
        }
    }
}
