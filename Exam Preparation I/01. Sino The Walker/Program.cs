using System;
using System.Globalization;

namespace _01.Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan time = TimeSpan.ParseExact(Console.ReadLine(), @"hh\:mm\:ss", CultureInfo.InvariantCulture);

            int numberOfSteps = int.Parse(Console.ReadLine());

            int timeforStep = int.Parse(Console.ReadLine());

            int secondsInADay = 60 * 60 * 24;

            TimeSpan timeToArrival = TimeSpan.FromSeconds((double)(numberOfSteps * timeforStep) % secondsInADay);

            time = time.Add(timeToArrival);

            Console.WriteLine(@"Time Arrival: {0:hh\:mm\:ss}", time);
        }
    }
}
