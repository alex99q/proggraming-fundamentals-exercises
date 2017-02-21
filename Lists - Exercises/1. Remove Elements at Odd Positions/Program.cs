using System;
using System.Collections.Generic;

namespace _1.Remove_Elements_at_Odd_Positions
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] inputText = Console.ReadLine().Split(' ');
			List<string> result = new List<string>();

			for (int i = 0; i < inputText.Length; i++)
			{
				if (i % 2 != 0)
				{
					result.Add(inputText[i]);
				}
			}

			Console.WriteLine(string.Join("", result));
		}
	}
}
