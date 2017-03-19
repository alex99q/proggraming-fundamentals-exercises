using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Ordered_Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, decimal>> bankingInformation = new Dictionary<string, Dictionary<string, decimal>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputTokens = input.Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                string bank = inputTokens[0];
                string account = inputTokens[1];
                decimal balance = decimal.Parse(inputTokens[2]);

                if (!bankingInformation.ContainsKey(bank))
                {
                    bankingInformation.Add(bank, new Dictionary<string, decimal>());
                }

                if (!bankingInformation[bank].ContainsKey(account))
                {
                    bankingInformation[bank].Add(account, 0);
                }

                bankingInformation[bank][account] += balance;

                input = Console.ReadLine();
            }

            bankingInformation = bankingInformation
                .OrderByDescending(x => x.Value.Sum(n => n.Value))
                .ThenByDescending(x => x.Value.Max(n => n.Value))
                .ToDictionary(n => n.Key, n => n.Value);

            foreach (var bankingAccounts in bankingInformation)
            {
                string bank = bankingAccounts.Key;
                var bankAccount = bankingAccounts.Value;

                bankAccount = bankAccount
                    .OrderByDescending(b => b.Value)
                    .ToDictionary(n => n.Key, n => n.Value);

                foreach (var accountBalancePair in bankAccount)
                {
                    string account = accountBalancePair.Key;
                    decimal balance = accountBalancePair.Value;

                    Console.WriteLine("{0} -> {1} ({2})", account, balance, bank);
                }
            }
        }
    }
}
