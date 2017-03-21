using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LINQuistics
{
	class LINQuistics
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			Dictionary<string, List<string>> collectionMethodsDict = new Dictionary<string, List<string>>();

			while (input != "end")
			{
				string[] inputTokens = input.Split(".()".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

				string collection = inputTokens[0];

				if (!collectionMethodsDict.ContainsKey(collection))
				{
					collectionMethodsDict[collection] = new List<string>();
				}

				for (int i = 1; i < inputTokens.Length; i++)
				{
					string method = inputTokens[i];

					collectionMethodsDict[collection].Add(method);
				}

				collectionMethodsDict[collection] = 
					collectionMethodsDict[collection]
						.Distinct()
						.OrderByDescending(n => n.Length)
						.ToList();

				for (int i = 0; i < ; i++)
				{

				}

				input = Console.ReadLine();
			}
		}
	}
}