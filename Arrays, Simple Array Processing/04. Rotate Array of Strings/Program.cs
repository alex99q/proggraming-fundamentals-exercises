using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Rotate_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            int numberOfRotatedWords = int.Parse(Console.ReadLine());
            string[] rotatedWords = new string[words.Length];

            for (int i = 0; i < words.Length - numberOfRotatedWords; i++)
            {
                rotatedWords[i + numberOfRotatedWords] = words[i];
            }

            int indexOfRotatedWords = 0;
            for (int i = (words.Length - numberOfRotatedWords; i < words.Length; i++)
            {
                string lastWord = words[i];
                rotatedWords[indexOfRotatedWords] = lastWord;

                indexOfRotatedWords++;
            }
            
            Console.WriteLine(string.Join(" ", rotatedWords));
        }
    }
}
