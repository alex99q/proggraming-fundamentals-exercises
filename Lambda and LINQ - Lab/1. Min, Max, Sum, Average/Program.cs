using System;
using System.Linq;

namespace _1.Min__Max__Sum__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());
                numbers[i] = inputNumber;
            }

            int sum = numbers.Sum();
            int minNumber = numbers.Min();
            int maxNumber = numbers.Max();
            double Average = numbers.Average();

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Min = {minNumber}");
            Console.WriteLine($"Max = {maxNumber}");
            Console.WriteLine($"Average = {Average}");
        }
    }
}
