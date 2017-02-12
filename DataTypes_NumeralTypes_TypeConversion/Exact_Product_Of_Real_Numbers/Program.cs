using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exact_Product_Of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            decimal number = 0m;
            decimal sum = 1m;

            for (int i = 0; i < n; i++)
            {
                number = decimal.Parse(Console.ReadLine());
                sum *= number;
            }

            Console.WriteLine(sum);
        }
    }
}
