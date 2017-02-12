namespace _02.Multiply_an_Array_of_Doubles
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            double p = double.Parse(Console.ReadLine());
            //string stringOfNumbers = Console.ReadLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= p;
            }

            string result = string.Join(" ", numbers);
            Console.WriteLine(result);

            //string[] numbers = stringOfNumbers.Split(' ');
            //SumOfArray(numbers, p);
        }

        //static void SumOfArray(string[] n, double p)
        //{
        //    for (int i = 0; i < n.Length; i++)
        //    {
        //        double result = 0;
        //        //result = Convert.ToDouble(n[i]) * p;
        //        result = double.Parse(n[i]) * p;

        //        Console.Write(result);
        //        if (i < n.Length - 1)
        //        {
        //            Console.Write(" ");
        //        }
        //    }

        //    Console.WriteLine();
        //}
    }
}
