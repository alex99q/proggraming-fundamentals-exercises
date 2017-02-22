using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Camel_s_Back
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> N = Console.ReadLine().Split().Select(int.Parse).ToList();
            int M = int.Parse(Console.ReadLine());

            int rounds = 0;

            if (M != N.Count)
            {

                int currentCount = N.Count;
                for (int i = 0; i < (currentCount - M) / 2; i++)
                {
                    N.RemoveAt(0);
                    N.RemoveAt(N.Count - 1);

                    rounds++;
                }
            }

            if (rounds == 0)
            {
                Console.Write("already stable: ");
                Console.WriteLine(string.Join(" ", N));
            }
            else
            {
                Console.WriteLine($"{rounds} rounds");
                Console.Write("remaining: ");
                Console.WriteLine(string.Join(" ", N));
            }
        }
    }
}
