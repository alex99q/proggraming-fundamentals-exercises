namespace _2.Japanese_Roulette
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] commands = Console.ReadLine().Split();

            int bulletPosition = 0;

            for (int i = 0; i < bullets.Length; i++)
            {
                if (bullets[i] == 1)
                {
                    bulletPosition = i;
                    break;
                }
            }

            for (int player = 0; player < commands.Length; player++)
            {
                string[] currentCommands = commands[player].Split(',');
                int muzzle = 2;

                int playerPower = int.Parse(currentCommands[0]);
                string playerDirection = currentCommands[1];

                if (playerDirection == "Right")
                {
                    for (int i = 0; i < playerPower; i++)
                    {
                        bulletPosition = MoveRight(bullets, bulletPosition);
                    }

                    if (bullets[muzzle] == 1)
                    {
                        Console.WriteLine($"Game over! Player {player} is dead.");
                        return;
                    }
                }

                else if (playerDirection == "Left")
                {
                    for (int i = 0; i < playerPower; i++)
                    {
                        bulletPosition = MoveLeft(bullets, bulletPosition);
                    }

                    if (bullets[muzzle] == 1)
                    {
                        Console.WriteLine($"Game over! Player {player} is dead.");
                        return;
                    }
                }

                bulletPosition = MoveRight(bullets, bulletPosition);
            }

            Console.WriteLine("Everybody got lucky!");
        }



        private static int MoveRight(int[] bullets, int bulletPosition)
        {
            if (bullets[bullets.Length - 1] == 1)
            {
                bullets[bullets.Length - 1] = 0;
                bullets[0] = 1;
            }
            else
            {
                int temporal = bullets[bulletPosition + 1];
                bullets[bulletPosition + 1] = bullets[bulletPosition];
                bullets[bulletPosition] = temporal;
            }

            for (int i = 0; i < bullets.Length; i++)
            {
                if (bullets[i] == 1)
                {
                    bulletPosition = i;
                    break;
                }
            }

            return bulletPosition;
        }

        private static int MoveLeft(int[] bullets, int bulletPosition)
        {
            if (bullets[0] == 1)
            {
                bullets[0] = 0;
                bullets[bullets.Length - 1] = 1;
            }

            else
            {
                int temporal = bullets[bulletPosition - 1];
                bullets[bulletPosition - 1] = bullets[bulletPosition];
                bullets[bulletPosition] = temporal;
            }

            for (int i = 0; i < bullets.Length; i++)
            {
                if (bullets[i] == 1)
                {
                    bulletPosition = i;
                    break;
                }
            }

            return bulletPosition;
        }
    }
}
