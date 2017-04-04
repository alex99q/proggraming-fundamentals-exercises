namespace _04.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string[] inputWords = Console.ReadLine().Split(" ,.?!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            HashSet<string> palindromes = new HashSet<string>();

            foreach (var word in inputWords)
            {
                string reversedWord = string.Empty;
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reversedWord = string.Concat(reversedWord, word[i].ToString());
                }

                if (word.Equals(reversedWord))
                {
                    palindromes.Add(word);
                }
            }

             var result = palindromes.OrderBy(w => w);

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
