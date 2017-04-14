using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Happiness_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex happyPattern = new Regex(@"[:;(*c[][)D*\]}:;]");
            Regex sadPattern = new Regex(@"[:D;)\]][(:[{c;]");

            string input = Console.ReadLine();

            int happyCount = happyPattern.Matches(input).Count;
            int sadCount = sadPattern.Matches(input).Count;

            double happinessIndex = (double)happyCount / sadCount;

            string emoticonToDisplay = string.Empty;
            if (happinessIndex >= 2)
            {
                emoticonToDisplay = ":D";
            }
            else if (happinessIndex > 1)
            {
                emoticonToDisplay = ":)";
            }
            else if (happinessIndex == 1)
            {
                emoticonToDisplay = ":|";
            }
            else if (happinessIndex < 1)
            {
                emoticonToDisplay = ":(";
            }

            Console.WriteLine($"Happiness index: {happinessIndex:F2} {emoticonToDisplay}");
            Console.WriteLine($"[Happy count: {happyCount}, Sad count: {sadCount}]");
        }
    }
}
