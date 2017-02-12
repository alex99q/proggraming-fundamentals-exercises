using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increment_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());

            int overflow = 0;
            int counter = 0;
            for(ulong i = 0; i <= n; i ++)
            {
                if ((counter + 1) > 256)
                {
                    overflow++;
                    counter = 0;
                }
                counter++;
            }
            byte number = (byte)n;
            Console.WriteLine(number);
            if (overflow != 0)
            {
                Console.WriteLine($"Overflowed {overflow} times");
            }
        }
    }
}
