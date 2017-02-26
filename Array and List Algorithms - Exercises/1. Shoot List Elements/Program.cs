namespace _1.Shoot_List_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberToShoot = new List<int>();
            int lastRemovedNumber = 0;

            while (true)
            {
                string currentInput = Console.ReadLine();

                if (currentInput == "stop")
                {
                    if (numberToShoot.Count == 0)
                    {
                        Console.WriteLine($"you shot them all. last one was {lastRemovedNumber}");
                    }
                    else
                    {
                        Console.WriteLine("survivors: {0}", string.Join(" ", numberToShoot));
                    }

                    break;
                }

                else if (currentInput == "bang")
                {
                    if(numberToShoot.Count == 0)
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {lastRemovedNumber}");

                        break;
                    }
                    else
                    {
                        double average = numberToShoot.Average();

                        for (int i = 0; i < numberToShoot.Count; i++)
                        {
                            if (numberToShoot[i] < average || numberToShoot.Count == 1)
                            {
                                Console.WriteLine($"shot {numberToShoot[i]}");

                                lastRemovedNumber = numberToShoot[i];
                                numberToShoot.RemoveAt(i);

                                break;
                            }
                        }

                        for (int i = 0; i < numberToShoot.Count; i++)
                        {
                            numberToShoot[i] -= 1;
                        }
                    }
                }

                else
                {
                    numberToShoot.Insert(0, int.Parse(currentInput));
                }
            }
        }
    }
}
