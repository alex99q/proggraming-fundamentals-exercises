using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Nth_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine(FindNthdigit(number, index));
        }

        static int FindNthdigit(long number, int index)
        {
            for (int i = 0; i < index - 1; i++)
            {
                number /= 10;
            }

            return (int)(number % 10);

            //int currentIndex = 1;

            //while (number > 0)
            //{
            //    if (index == currentIndex)
            //    {
            //        return (int)(number % 10);
            //    }

            //    number /= 10;
            //    currentIndex++;
            //}

            //return (int)(number % 10);
        }
    }
}
