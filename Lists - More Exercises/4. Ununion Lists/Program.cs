using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Ununion_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primalList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<int> currentInput = Console.ReadLine().Split().Select(int.Parse).ToList();

                for (int j = 0; j < currentInput.Count; j++)
                {
                    if (primalList.Contains(currentInput[j]))
                    {

                        while (primalList.Contains(currentInput[j]))
                        {
                            primalList.Remove(currentInput[j]);
                        }
                         
                    }

                    else
                    {
                        primalList.Add(currentInput[j]);
                    }
                }
            }

            primalList.Sort();

            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}
