using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Ballistics_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] directions = Console.ReadLine().Split(' ');

            int x = coordinates[0];
            int y = coordinates[1];
            int currentY = 0, currentX = 0;

            for (int i = 0, j = 1; i < directions.Length; i++, j++)
            {
                if (directions[i].Contains("up"))
                {
                    currentY += int.Parse(directions[j]);
                }
                else if (directions[i].Contains("down"))
                {
                    currentY -= int.Parse(directions[j]);
                }
                else if (directions[i].Contains("left"))
                {
                    currentX -= int.Parse(directions[j]);
                }
                else if (directions[i].Contains("right"))
                {
                    currentX += int.Parse(directions[j]);
                }
            }

            if (currentX == x && currentY == y)
            {
                Console.WriteLine($"firing at [{x}, {y}]\ngot 'em!");
            }
            else
            {
                Console.WriteLine($"firing at [{currentX}, {currentY}]\nbetter luck next time...");
            }
        }
    }
}
