using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Optimized_Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<BankAccount> bankAccounts = new List<BankAccount>();

            while(input != "end")
            {
                bankAccounts.Add(BankAccount.Parse(input));

                input = Console.ReadLine();
            }

            bankAccounts = bankAccounts
                .OrderByDescending(n => n.Balance)
                .ThenBy(n => n.Bank.Length)
                .ToList();

            foreach (var bankAccount in bankAccounts)
            {
                Console.WriteLine($"{bankAccount.Name} -> {bankAccount.Balance} ({bankAccount.Bank})");
            }
        }
    }

    public class BankAccount
    {
        public string Name { get; set; }

        public string Bank { get; set; }

        public decimal Balance { get; set; }

        public static BankAccount Parse(string input)
        {
            string[] inputParameters = input.Split("|".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            return new BankAccount
            {
                Bank = inputParameters[0].Trim(),
                Name = inputParameters[1].Trim(),
                Balance = decimal.Parse(inputParameters[2].Trim())
            };
        }
    }
}
