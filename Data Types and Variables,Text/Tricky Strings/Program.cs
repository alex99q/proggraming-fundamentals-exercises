using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tricky_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string sum = string.Empty;
            for (int i = 0; i < n; i++)
            {
                sum += Console.ReadLine();
                if (i < n - 1)
                {
                    sum += delimiter;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
