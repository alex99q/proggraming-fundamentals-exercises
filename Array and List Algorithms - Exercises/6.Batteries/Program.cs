using System;
using System.Linq;

namespace Batteries
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			double[] capacity = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
			double[] usagePerHour = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
			int hoursTested = int.Parse(Console.ReadLine());

			for (int i = 0; i < capacity.Length; i++)
			{
				double currentCapacity = capacity[i];
				double currentUsage = usagePerHour[i];
				int hoursLasted = 0;

				for (int j = 0; j < hoursTested; j++)
				{
					if (currentCapacity > 0)
					{
						hoursLasted++;
					}

					currentCapacity -= currentUsage;
				}

				double percentage = (currentCapacity / capacity[i]) * 100;

				if (currentCapacity < 0)
				{
					Console.WriteLine($"Battery {i + 1}: dead (lasted {hoursLasted} hours)");
				}
				else 
				{
					Console.WriteLine($"Battery {i + 1}: {currentCapacity:F2} mAh ({percentage:F2})%");
				}
			}
		}
	}
}
