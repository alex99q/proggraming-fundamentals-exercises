using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Lambada_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> lambdaExpresions = new Dictionary<string, Dictionary<string, string>>();

            string input = Console.ReadLine();
            while (input != "lambada")
            {
                string[] inputTokens = input.Split(" =>.".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                if (inputTokens.Length > 1)
                {
                    string selector = inputTokens[0];
                    string selectorObject = inputTokens[1];
                    string property = inputTokens[2];

                    if (!lambdaExpresions.ContainsKey(selector))
                    {
                        lambdaExpresions.Add(selector, new Dictionary<string, string>());
                    }

                    lambdaExpresions[selector][selectorObject] = property;
                }
                else
                {
                    lambdaExpresions = lambdaExpresions
                        .ToDictionary(selector => selector.Key,
                        selector => selector.Value
                            .ToDictionary(selectorObject => selectorObject.Key, 
                            selectorObject => selectorObject.Key + "." + selectorObject.Value));
                }

                input = Console.ReadLine();
            }

            foreach (var selector in lambdaExpresions)
            {
                foreach (var selectorObject in selector.Value)
                {
                    Console.WriteLine("{0} => {1}.{2}", selectorObject.Key, selectorObject.Key, selectorObject.Value);
                }
            }
        }
    }
}
