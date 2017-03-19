using System;

namespace _4.Distance_between_Points
{
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
    }
}
