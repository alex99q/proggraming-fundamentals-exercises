using System;
using System.Collections.Generic;

namespace _4.Exam_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> stock = new Dictionary<string, int>();
            
            string input = Console.ReadLine();

            while(input != "exam time")
            {
                if (input == "shopping time")
                {
                    input = Console.ReadLine();
                    continue;
                }

                string[] inputTokens = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                string command = inputTokens[0];
                string product = inputTokens[1];
                int quantity = int.Parse(inputTokens[2]);

                if (command == "stock")
                {
                    if (!stock.ContainsKey(product))
                    {
                        stock[product] = 0;
                    }

                    stock[product] += quantity;
                }
                else if (command == "buy")
                {
                    if (stock.ContainsKey(product))
                    {
                        if (stock[product] == 0)
                        {
                            Console.WriteLine($"{product} out of stock");
                        }
                        else
                        {
                            stock[product] -= quantity;

                            if (stock[product] < 0)
                            {
                                stock[product] = 0;
                            }
                        }
                    }

                    else if (!stock.ContainsKey(product))
                    {
                        Console.WriteLine($"{product} doesn't exist");
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var productQuantityPair in stock)
            {
                string product = productQuantityPair.Key;
                int quantity = productQuantityPair.Value;

                if (quantity <= 0)
                {
                    continue;
                }
                Console.WriteLine($"{product} -> {quantity}");
            }
        }
    }
}
