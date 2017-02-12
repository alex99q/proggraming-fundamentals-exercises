using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Smallest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            int LowestNumber = int.Parse(numbers[0]);

            for (int i = 0; i < numbers.Length; i++)
            {
                int[] ConvertedNumbers = new int[numbers.Length];

                ConvertedNumbers[i] = int.Parse(numbers[i]);
                
                if (ConvertedNumbers[i] < LowestNumber)
                {
                    LowestNumber = ConvertedNumbers[i];
                }
            }

            Console.WriteLine(LowestNumber);
        }
    }
}
