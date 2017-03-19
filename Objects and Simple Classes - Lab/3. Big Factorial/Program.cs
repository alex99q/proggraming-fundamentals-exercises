using System;
using System.Numerics;

namespace _3.Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int parameter = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;
            for (int i = parameter; i > 1; i--)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
