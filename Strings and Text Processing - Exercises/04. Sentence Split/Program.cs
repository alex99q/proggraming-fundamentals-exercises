namespace _04.Sentence_Split
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var sentence = Console.ReadLine();
            var delimiter = Console.ReadLine();

            var splitedSentence = sentence
                .Split(new string[] { delimiter }, StringSplitOptions.None)
                .ToArray();

            Console.WriteLine("[" + string.Join(", ", splitedSentence) + "]");
        }
    }
}
