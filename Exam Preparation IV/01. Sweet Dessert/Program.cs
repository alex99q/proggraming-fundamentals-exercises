using System;

namespace _01.Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal amountOfCash = decimal.Parse(Console.ReadLine());
            int numberOfGuests = int.Parse(Console.ReadLine());
            decimal priceOfBanana = decimal.Parse(Console.ReadLine());
            decimal priceOfEgg = decimal.Parse(Console.ReadLine());
            decimal kiloOfBerriesPrice = decimal.Parse(Console.ReadLine());

            int setOfPortions = 0;
            while (numberOfGuests > 0)
            {
                numberOfGuests -= 6;
                setOfPortions++;
            }

            decimal costOfBananas = setOfPortions * (2 * priceOfBanana);
            decimal costOfEggs = setOfPortions * (4 * priceOfEgg);
            decimal costOfBerries = setOfPortions * (0.2m * kiloOfBerriesPrice);

            decimal finalCost = costOfBananas + costOfEggs + costOfBerries;

            if (finalCost <= amountOfCash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {finalCost:F2}lv.");
            }
            else
            {
                decimal neededMoney = finalCost - amountOfCash;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoney:F2}lv more.");
            }
        }
    }
}
