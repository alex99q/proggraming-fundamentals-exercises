using System;

namespace TextFilter
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] forbidenWords = Console.ReadLine().Split(" ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            foreach (var forbidenWord in forbidenWords)
            {
                if (text.Contains(forbidenWord))
                {
                    text = text.Replace(forbidenWord, new string('*', forbidenWord.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}