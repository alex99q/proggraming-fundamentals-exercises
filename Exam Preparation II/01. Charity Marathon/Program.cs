using System;

namespace _01.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            uint marathonLenght = uint.Parse(Console.ReadLine());
            uint numberOfRunners = uint.Parse(Console.ReadLine());
            uint averageNumberOfLaps = uint.Parse(Console.ReadLine());
            uint trackLenght = uint.Parse(Console.ReadLine());
            uint trackCapacity = uint.Parse(Console.ReadLine());
            decimal moneyPerKilometer = decimal.Parse(Console.ReadLine());

            if (numberOfRunners > trackCapacity * marathonLenght)
            {
                numberOfRunners = trackCapacity * marathonLenght;
            }

            ulong averageMetersPerRunner = (ulong)averageNumberOfLaps * trackLenght * numberOfRunners;
            ulong averageKilometers = averageMetersPerRunner / 1000;
            decimal MoneyRaised = averageKilometers * moneyPerKilometer;

            Console.WriteLine($"Money raised: {MoneyRaised:F2}");
        }
    }
}