using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.Closest_Two_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Point[] points = new Point[n];

            for (int i = 0; i < n; i++)
            {
                double[] inputCoordinates = Console.ReadLine().Split().Select(double.Parse).ToArray();

                Point currentPoint = new Point();
                currentPoint.X = inputCoordinates[0];
                currentPoint.Y = inputCoordinates[1];

                points[i] = currentPoint;
            }

            var closestPoints = Point.FindClosestPoints(points);

            foreach (var parameters in closestPoints)
            {
                Console.WriteLine("{0:F3}", parameters.Key);
                Console.WriteLine("({0}, {1})", parameters.Value[0].X, parameters.Value[0].Y);
                Console.WriteLine("({0}, {1})", parameters.Value[1].X, parameters.Value[1].Y);
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

            public static Dictionary<double, Point[]> FindClosestPoints(Point[] points)
            {
                Point[] minDistancePoints = new Point[2];
                double minDistance = double.MaxValue;

                for (int firstPointIndex = 0; firstPointIndex < points.Length - 1; firstPointIndex++)
                {
                    for (int secondPointIndex = firstPointIndex + 1; secondPointIndex < points.Length; secondPointIndex++)
                    {
                        var firstPoint = points[firstPointIndex];
                        var secondPoint = points[secondPointIndex];

                        double currentDistance = CalcDistance(firstPoint, secondPoint);

                        if (currentDistance < minDistance)
                        {
                            minDistance = currentDistance;

                            minDistancePoints[0] = firstPoint;
                            minDistancePoints[1] = secondPoint;
                        }
                    }
                }

                Dictionary<double, Point[]> result = new Dictionary<double, Point[]>();
                result[minDistance] = minDistancePoints;

                return result;
            }
        }
    }
}
