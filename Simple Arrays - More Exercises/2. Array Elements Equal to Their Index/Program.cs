using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Array_Elements_Equal_to_Their_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] result = new int[numbers.Length];

            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == numbers[i])
                {
                    result[count] = numbers[i];
                    count++;
                }
            }

            for (int i = 0; i < count; i++)
            {
                Console.Write(result[i]);
                if(i < count - 1)
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }
}
