using System;

namespace _2.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Random rnd = new Random();

            for (int j = 0; j < 100; j++)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    int randomPosition = rnd.Next(0, words.Length);

                    string temp = words[i];
                    words[i] = words[randomPosition];
                    words[randomPosition] = temp;
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
