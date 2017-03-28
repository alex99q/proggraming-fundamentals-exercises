using System;
using System.IO;
using System.Linq;

namespace Merge_Files
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string[] input1 = File.ReadLines("../../../Resources/04.Merge Files/FileOne.txt").ToArray();
			string[] input2 = File.ReadLines("../../../Resources/04.Merge Files/FileTwo.txt").ToArray();

			string[] input = input1.Concat(input2).OrderBy(n => n).ToArray();
		}
	}
}
