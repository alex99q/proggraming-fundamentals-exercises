using System;
using System.Collections.Generic;
using System.Linq;

namespace Distinct_List
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

			for (int i = 0; i < input.Count; i++)
			{
				int currentNumber = input[i];

				input.RemoveAt(i);

				if (input.Contains(currentNumber))
				{
					
				}
			}
		}
	}
}
