using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.Boxes
{
    public class Box
    {
        public Point UpperLeft { get; set; }

        public Point UpperRight { get; set; }

        public Point BottomLeft { get; set; }

        public Point BottomRight { get; set; }

        public double Width
        {
            get
            {
                return Point.CalcDistance(UpperLeft, UpperRight);
            }
        }

        public double Height
        {
            get
            {
                return Point.CalcDistance(UpperLeft, BottomLeft);
            }
        }

        public double CalculatePerimeter()
        {
            return 2 * Width + 2 * Height;
        }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }

    public class Point
    {
        public double X { get; set; }

        public double Y { get; set; }

        public static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            double squareX = Math.Pow(firstPoint.X - secondPoint.X, 2);
            double squareY = Math.Pow(firstPoint.Y - secondPoint.Y, 2);

            double result = Math.Sqrt(squareX + squareY);

            return result;
        }

        public static Point Parse(string s)
        {
            int[] stringParameters = s.Split(':').Select(int.Parse).ToArray();

            return new Point
            {
                X = stringParameters[0],
                Y = stringParameters[1]
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Box> boxes = new List<Box>();

            while(input != "end")
            {
                string[] inputTokens = input.Split("| ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                Point upperLeft = Point.Parse(inputTokens[0]);
                Point upperRight = Point.Parse(inputTokens[1]);
                Point bottomLeft = Point.Parse(inputTokens[2]);
                Point bottomRight = Point.Parse(inputTokens[3]);

                boxes.Add(new Box
                {
                    UpperLeft = upperLeft,
                    UpperRight = upperRight,
                    BottomLeft = bottomLeft,
                    BottomRight = bottomRight
                });

                input = Console.ReadLine();
            }

            foreach (var box in boxes)
            {
                Console.WriteLine($"Box: {box.Width}, {box.Height}");
                Console.WriteLine($"Perimeter: {box.CalculatePerimeter()}");
                Console.WriteLine($"Area: {box.CalculateArea()}");
            }
        }
    }
}
