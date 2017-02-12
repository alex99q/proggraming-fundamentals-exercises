using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Float_or_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            if (n == Math.Floor(n))
            {
                Console.WriteLine((int)n);
            }
            else
            {
                Console.WriteLine(Math.Round(n, 0));
            }
        }
    }
}
