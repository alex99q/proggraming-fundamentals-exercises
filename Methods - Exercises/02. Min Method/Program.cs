using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Min_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int minFirstOrSecondNumber = GetMin(firstNumber, secondNumber);
            int lowestNumber = GetMin(minFirstOrSecondNumber, GetMin(minFirstOrSecondNumber, thirdNumber));

            Console.WriteLine(lowestNumber);
        }

        static int GetMin(int firstNumber, int secondNumber)
        {
            if(firstNumber < secondNumber)
            {
                return firstNumber;
            }
            return secondNumber;
        }
    }
}
