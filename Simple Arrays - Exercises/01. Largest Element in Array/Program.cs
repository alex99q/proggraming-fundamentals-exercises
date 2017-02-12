using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Element_in_Array
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

            int largestNumber = int.MinValue;
            foreach (var number in numbers)
            {
                if(number > largestNumber)
                {
                    largestNumber = number;
                }
            }

            //int largestNumber =  numbers.Max();
            Console.WriteLine(largestNumber);
        }
    }
}
