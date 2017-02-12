using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexedecimal = Console.ReadLine();

            int nDecimal = Convert.ToInt32(hexedecimal, 16);

            Console.WriteLine(nDecimal);
        }
    }
}
