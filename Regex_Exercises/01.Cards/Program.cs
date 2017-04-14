using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Cards
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string input = Console.ReadLine();

			string pattern = @"([1]?[2-9JQKA])([SHDC])";

			Regex rx = new Regex(pattern);

			MatchCollection matches = rx.Matches(input);

			List<string> result = new List<string>();

			foreach (Match match in matches)
			{
				int num = 0;
				if (int.TryParse(match.Groups[1].Value, out num))
				{
					if (num < 2 || num > 10)
					{
						continue;
					}	
				}

				result.Add(match.Value);
			}

			Console.WriteLine(string.Join(", ", result));
		}
	}
}
