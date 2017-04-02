using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _2.HTML_Contents
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLines = File.ReadAllLines("../../Input.txt");

            string title = string.Empty;
            List<string> bodyParts = new List<string>();

            foreach (var line in inputLines)
            {
                if (line == "exit")
                {
                    break;
                }

                string[] lineParts = line.Split(' ');

                string tag = lineParts[0];
                string content = lineParts[1];

                if (tag == "title")
                {
                    title = "\t<title>" + content + "</title>";
                }
                else
                {
                    bodyParts.Add("<" + tag + ">" + content + "</" + tag + ">");
                }
            }

            StringBuilder result = new StringBuilder();

            result.AppendLine("<!DOCTYPE html>");
            result.AppendLine("<html>");
            result.AppendLine("<head>");

            if (title != string.Empty)
            {
                result.AppendLine(title);
            }

            result.AppendLine("</head>");
            result.AppendLine("<body>");

            if (bodyParts.Any())
            {
                result.AppendLine(string.Join(Environment.NewLine, bodyParts));
            }

            result.AppendLine("</body>");
            result.AppendLine("</html>");

            File.WriteAllText("../../Index.html", result.ToString());
        }
    }
}
