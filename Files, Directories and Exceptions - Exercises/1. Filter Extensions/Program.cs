using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _1.Filter_Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputExtention = Console.ReadLine();

            var files = Directory.GetFiles("../../../Exercises-Resource/01. Filter-Extensions/input");

            List<string> fileNames = new List<string>();

            foreach (var file in files)
            {
                string currentExtention = file.Split('.').Reverse().Take(1).ToArray()[0];

                if (currentExtention == inputExtention)
                {
                    fileNames.Add(file.Split('\\').Reverse().Take(1).ToArray()[0]);
                }
            }

            File.WriteAllLines("../../../Exercises-Resource/01. Filter-Extensions/output.txt", fileNames);
        }
    }
}
