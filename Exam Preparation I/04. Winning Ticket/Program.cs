using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            const string pattern = @"([$#^@])\1{5,}";

            Regex ticketRegex = new Regex(pattern);

            string[] tickets = Console.ReadLine()
                .Split(',')
                .Select(a => a.Trim())
                .ToArray();

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                string firstHalf = ticket.Substring(0, ticket.Length / 2);
                string secondHalf = ticket.Substring(ticket.Length / 2);

                Match leftMatch = ticketRegex.Match(firstHalf);
                Match rightMatch = ticketRegex.Match(secondHalf);

                if (leftMatch.Success && rightMatch.Success)
                {
                    char winningSymbol = leftMatch.Value[0];
                    int shorterMatch = Math.Min(leftMatch.Length, rightMatch.Length);

                    Console.Write($"ticket \"{ticket}\" - {shorterMatch}{winningSymbol}");
                    if (shorterMatch == 10)
                    {
                        Console.Write(" Jackpot!");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }
    }
}
