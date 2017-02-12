using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int c = b;
            b = a;
            a = c;

            //a = a - b;
            //b = b + a;
            //a = b - a;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
