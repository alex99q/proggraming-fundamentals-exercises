using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double area = GetTriangleArea(a, b);

            Console.WriteLine(area);
        }

        static double GetTriangleArea(double width, double height)
        {
            return width * height / 2;
        }
    }
}
