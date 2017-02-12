using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Count_Occurrences_of_Larger_Numbers_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            double p = double.Parse(Console.ReadLine());

            int numberOfBiggerNumbers = 0;
            foreach (var number in numbers)
            {
                if(number > p)
                {
                    numberOfBiggerNumbers++;
                }
            }

            Console.WriteLine(numberOfBiggerNumbers);
        }
    }
}
