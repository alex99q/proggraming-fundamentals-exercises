using System;
using System.Linq;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split();

            double[] trackIndices = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            double[] checkpointIndices = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            foreach (var participant in participants)
            {
                double fuel = participant[0];

                for (int currentTrackIndex = 0; currentTrackIndex <= trackIndices.Length; currentTrackIndex++)
                {
                    bool outOfFuel = fuel <= 0;
                    bool reachEndOfTrack = currentTrackIndex == trackIndices.Length;
                    bool raceEnded = outOfFuel || reachEndOfTrack;

                    if (raceEnded)
                    {
                        if (outOfFuel)
                        {
                            Console.WriteLine($"{participant} - reached {currentTrackIndex - 1}");
                        }
                        else if (reachEndOfTrack)
                        {
                            Console.WriteLine($"{participant} - fuel left {fuel:F2}");
                        }

                        break;
                    }

                    double fuelAtCheckpoint = trackIndices[currentTrackIndex];

                    bool isCheckPoint = checkpointIndices.Contains(currentTrackIndex);
                    if (isCheckPoint)
                    {
                        fuel += fuelAtCheckpoint;
                    }
                    else
                    {
                        fuel -= fuelAtCheckpoint;
                    }
                }
            }
        }
    }
}
