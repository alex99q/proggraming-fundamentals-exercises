using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> squareNums = new List<int>();
                        
            foreach (double number in numbers)
            {

                if (Math.Sqrt(number) == (int)Math.Sqrt(number))
                {
                    squareNums.Add((int)number);
                }
            }

            //squareNums.Sort();
            //squareNums.Reverse();
            squareNums.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", squareNums));
        }
    }
}
