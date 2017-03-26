using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.Sales_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, decimal> salesByTown = new SortedDictionary<string, decimal>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Sale currentSale = Sale.Parse(Console.ReadLine());

                if (!salesByTown.ContainsKey(currentSale.Town))
                {
                    salesByTown[currentSale.Town] = 0;
                }

                salesByTown[currentSale.Town] += currentSale.Price * currentSale.Quantity;
            }

            foreach (var sale in salesByTown)
            {
                Console.WriteLine("{0} -> {1:F2}", sale.Key, sale.Value);
            }
        }
    }

    public class Sale
    {
        public string Town { get; set; }

        public string Product { get; set; }

        public decimal Price { get; set; }

        public decimal Quantity { get; set; }

        public static Sale Parse(string saleAsString)
        {
            string[] saleParameters = saleAsString.Split(' ').ToArray();

            return new Sale
            {
                Town = saleParameters[0],
                Product = saleParameters[1],
                Price = decimal.Parse(saleParameters[2]),
                Quantity = decimal.Parse(saleParameters[3])
            };
        }
    }
}
