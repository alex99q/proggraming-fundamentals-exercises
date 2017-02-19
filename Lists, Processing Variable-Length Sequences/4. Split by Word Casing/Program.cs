using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']' };
            string[] inputText = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

            List<string> lowercase = new List<string>();
            List<string> uppercase = new List<string>();
            List<string> mixedcase = new List<string>();

            foreach (var word in inputText)
            {
                bool isAllLowerCase = true;
                bool isAllUpperrCase = true;

                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLower(word[i]))
                    {
                        isAllUpperrCase = false;
                    }
                    else if (char.IsUpper(word[i]))
                    {
                        isAllLowerCase = false;
                    }
                    else
                    {
                        isAllLowerCase = false;
                        isAllUpperrCase = false;
                    }

                }

                if (isAllLowerCase)
                {
                    lowercase.Add(word);
                }
                else if (isAllUpperrCase)
                {
                    uppercase.Add(word);
                }
                else
                {
                    mixedcase.Add(word);
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowercase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedcase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", uppercase));
        }
    }
}
