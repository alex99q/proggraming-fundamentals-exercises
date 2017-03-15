using System;
using System.Collections.Generic;
using System.Linq;

namespace RegisterUsers
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string input = Console.ReadLine();

			Dictionary<string, DateTime> date = new Dictionary<string, DateTime>();

			while (input != "end")
			{
				string[] inputTokens = input.Split("-> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
				date[inputTokens[0]] = DateTime.Parse(inputTokens[1]);

				input = Console.ReadLine();
			}

			date = date.Take(5).OrderBy(n => n).ToDictionary((KeyValuePair<string, DateTime> arg) => arg);
		}
	}
}
	