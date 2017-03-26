using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Websites
{
    public class Website
    {
        public string Host { get; set; }

        public string Domain { get; set; }

        public List<string> Queries { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Website> websites = new List<Website>();

            while (input != "end")
            {
                string[] inputTokens = input.Split(" |".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                string host = inputTokens[0];
                string domain = inputTokens[1];

                List<string> queries = new List<string>();

                if (inputTokens.Length > 2)
                {
                    queries = inputTokens[2].Split(',').ToList();
                }

                websites.Add(new Website { Domain = domain, Host = host, Queries = queries});

                input = Console.ReadLine();
            }

            foreach (var website in websites)
            {
                if (website.Queries.Count == 0)
                {
                    Console.WriteLine($"https://www.{website.Host}.{website.Domain}");
                }
                else
                {
                    Console.Write($"https://www.{website.Host}.{website.Domain}/query?=[");
                    Console.Write(string.Join("]&[", website.Queries));
                    Console.WriteLine("]");
                }
            }
        }
    }
}
