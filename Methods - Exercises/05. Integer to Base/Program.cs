using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Integer_to_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            string converted = IntegertoBase(number, toBase);
            Console.WriteLine(converted);
        }

        static string IntegertoBase(int number, int toBase)
        {
            string result = string.Empty;

            while (number > 0)
            {
                int remainder = number % toBase;
                result = remainder + result;
                number /= toBase;
            }

            return result;
        }
    }
}
