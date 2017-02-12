using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Array_Symmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            bool isSymetric = true;
            for (int i = 0, j = words.Length - 1; i < words.Length / 2; i++, j--)
            {
                if(words[i] != words[j])
                {
                    isSymetric = false;
                    break;
                }
            }

            if (isSymetric)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
