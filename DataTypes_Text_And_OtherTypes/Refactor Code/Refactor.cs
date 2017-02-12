namespace Refactor_Code
{
    using System;
    public class Refactor
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int currentNumber = 1; currentNumber <= n; currentNumber++)
            {
                int number = currentNumber;
                int sumOfDigits = 0;
                while (number > 0)
                {
                    sumOfDigits += number % 10;
                    number = number / 10;
                }

                bool isSpecialNumber = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);

                Console.WriteLine($"{currentNumber} -> {isSpecialNumber}");
            }

        }
    }
}
