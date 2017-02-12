using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            long result = GetMultipleOfEvensAndOdds(number);

            Console.WriteLine(result);
        }

        static long GetMultipleOfEvensAndOdds(int number)
        {
            int sumEvens = GetSumOfEvenDigits(number);
            int sumOdds = GetSumOfOddDigits(number);

            return sumEvens * sumOdds;
        }

        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            number = Math.Abs(number);

            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }

            return sum;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            number = Math.Abs(number);

            while (number > 0)
            {
                int lastDigit = number % 10;
                number = Math.Abs(number);

                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }

            return sum;
        }
    }
}
