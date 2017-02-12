using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double powerOfNumber = double.Parse(Console.ReadLine());

            Console.WriteLine(RaiseToPower(number, powerOfNumber));
        }

        static double RaiseToPower(double number, double powerOfNumber)
        {
            double result = 1d;


            for (int i = 0; i < powerOfNumber; i++)
            {
                result *= number;
            }
            //result = Math.Pow(number, powerOfNumber);

            return result;
        }
    }
}
