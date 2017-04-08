using System;

namespace _01.Placeholders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputParameters = input.Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                string someString = inputParameters[0].Trim();
                string[] stringElements = inputParameters[1].Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < stringElements.Length; i++)
                {
                    string parameterForReplacement = "{" + i + "}";

                    if (someString.Contains(parameterForReplacement))
                    {
                        someString = someString.Replace(parameterForReplacement, stringElements[i]);
                    }
                    else
                    {
                        break;
                    }
                }

                Console.WriteLine(someString);

                input = Console.ReadLine();
            }
        }
    }
}
