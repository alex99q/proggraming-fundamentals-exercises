using System;

namespace _03.Price_Change_Alert
{
    class Program
    {
        static void Main()
        {
            int numberOfPrices = int.Parse(Console.ReadLine());
            double treshold = double.Parse(Console.ReadLine());
            double firstPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPrices - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());

                double difference = PercentDifference(firstPrice, currentPrice);
                bool isSignificantDifference = CheckedChange(difference, treshold);
                string message = GetMessage(currentPrice, firstPrice, difference, isSignificantDifference);

                Console.WriteLine(message);

                firstPrice = currentPrice;
            }
        }

        private static string GetMessage(double currentPrice, double firstPrice, double difference, bool isSignificantDifference)
        {
            string result = string.Empty;
            difference *= 100;

            if (difference == 0)
            {
                result = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!isSignificantDifference)
            {
                result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", firstPrice, currentPrice, difference);
            }
            else if (isSignificantDifference && (difference > 0))
            {
                result = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", firstPrice, currentPrice, difference);
            }
            else if (isSignificantDifference && (difference < 0))
            {
                result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", firstPrice, currentPrice, difference);
            }

            return result;
        }
        private static bool CheckedChange(double difference, double treshold)
        {
            if (Math.Abs(difference) >= treshold)
            {
                return true;
            }

            return false;
        }

        private static double PercentDifference(double firstPrice, double currentPrice)
        {
            double result = (currentPrice - firstPrice) / firstPrice;

            return result;
        }
    }
}
