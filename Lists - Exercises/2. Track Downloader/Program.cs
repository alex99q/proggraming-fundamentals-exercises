using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Track_Downloader
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] blacklist = Console.ReadLine().Split(' ');
            List<string> input = new List<string>();
            List<string> result = new List<string>();

            while (true)
            {
                input.Add(Console.ReadLine());

                string currentInput = input[input.Count - 1];

                if (currentInput == "end")
                {
                    break;
                }

                bool isOnBlacklist = false;

                foreach (var word in blacklist)
                {
                    if (currentInput.Contains(word))
                    {
                        isOnBlacklist = true;
                        break;
                    }
                }

                if(isOnBlacklist == false)
                {
                    result.Add(currentInput);
                }
            }

            result.Sort();

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
