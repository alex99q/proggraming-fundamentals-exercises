using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            List<string> items = values.Split(' ').ToList();

            List<int> numbers = new List<int>();

            for (int i = 0; i < items.Count; i++)
            {
                int currentNumber = int.Parse(items[i]);

                if (currentNumber > 0)
                {
                    numbers.Add(currentNumber);
                }
            }

            numbers.Reverse();

            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (i - 1 < numbers.Count)
                        Console.Write(numbers[i] + " ");
                    else
                        Console.Write(numbers[i]);
                }
                Console.WriteLine();
            }
            
        }
    }
}
