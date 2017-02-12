using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Altitude
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            long altitude = long.Parse(input[0]);

            for (int i = 1, j = 2; i < input.Length; i++, j++)
            {
                if (altitude <= 0)
                {
                    Console.WriteLine("crashed");
                    return;
                }

                if (input[i].ToLower() == "up")
                {
                        altitude += long.Parse(input[j]);
                }
                else if(input[i].ToLower() == "down")
                {
                        altitude -= long.Parse(input[j]);
                }
            }

            Console.WriteLine($"got through safely. current altitude: {altitude}m");
        }
    }
}
