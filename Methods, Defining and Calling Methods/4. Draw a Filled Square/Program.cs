using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintHeaderRow(n);

            for (int i = 0; i < n - 2; i++)
            {
                PrintMiddleRow(n);
            }

            PrintHeaderRow(n);
        }

        static void PrintHeaderRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        static void PrintMiddleRow(int n)
        {
            string row = "-";

            for (int i = 1; i <= n - 1; i++)
            {
                row += @"\/";
            }

            row += "-";

            Console.WriteLine(row);
        }
    }
}
