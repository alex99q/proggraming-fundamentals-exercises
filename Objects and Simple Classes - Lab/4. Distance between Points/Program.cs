using System;
using System.Linq;

namespace _4.Distance_between_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstPoint = new Point();

            double[] firstInput = Console.ReadLine().Split().Select(double.Parse).ToArray();

            firstPoint.X = firstInput[0];
            firstPoint.Y = firstInput[1];

            var secondPoint = new Point();

            double[] secondInput = Console.ReadLine().Split().Select(double.Parse).ToArray();

            secondPoint.X = secondInput[0];
            secondPoint.Y = secondInput[1];

            double result = Point.CalcDistance(firstPoint, secondPoint);
            Console.WriteLine("{0:F3}", result);
        }
    }
}
