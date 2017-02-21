namespace Distinct_List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MainClass
	{
		public static void Main()
		{
			List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

			for (int i = 0; i < input.Count; i++)
			{
				int currentNumber = input[i];

				input.RemoveAt(i);

				if (input.Contains(currentNumber))
				{
					while (input.Contains(currentNumber))
                    {
                        input.Remove(currentNumber);
                    }
				}

                input.Insert(i, currentNumber);
			}

            Console.WriteLine(string.Join(" ", input));
		}
	}
}
