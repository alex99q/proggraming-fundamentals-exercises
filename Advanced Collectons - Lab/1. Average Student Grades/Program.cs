using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> nameGradesDict = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                double grade = double.Parse(input[1]);

                if (!nameGradesDict.ContainsKey(name))
                {
                    nameGradesDict[name] = new List<double>();
                }
                nameGradesDict[name].Add(grade);
            }

            foreach (var nameGradesPair in nameGradesDict)
            {
                string name = nameGradesPair.Key;
                List<double> grades = nameGradesPair.Value;
                double average = grades.Average();

                Console.Write($"{name} -> ");

                foreach (var grade in grades)
                    Console.Write($"{grade:F2} ");

                Console.WriteLine($"(avg: {average:F2})");
            }
        }
    }
}
