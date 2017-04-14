using System;
using System.Text.RegularExpressions;

namespace Replace_a_tag
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string input = Console.ReadLine();

			while (input != "end")
			{
				string pattern = @"<a.*href=(.+?)>(.+?)<\/a>";

				Regex rx = new Regex(pattern);

				string replacement = "[URL href=$1]$2[/URL]";

				string output = rx.Replace(input, replacement);

				Console.WriteLine(output);

				input = Console.ReadLine();
			}
		}
	}
}
