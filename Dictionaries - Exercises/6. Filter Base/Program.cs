using System;
using System.Collections.Generic;

namespace _6.Filter_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameAgeDict = new Dictionary<string, int>();
            var nameSalaryDict = new Dictionary<string, double>();
            var namePositionDict = new Dictionary<string, string>();

            string input = Console.ReadLine();
            while (input != "filter base")
            {
                string[] inputTokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string name = inputTokens[0];
                string position = inputTokens[inputTokens.Length - 1];

                int age = 0;
                double salary = 0d;

                if (int.TryParse(position, out age))
                {
                    if (!nameAgeDict.ContainsKey(name))
                    {
                        nameAgeDict[name] = 0;
                    }
                    nameAgeDict[name] = age;
                }
                else if(double.TryParse(position, out salary))
                {
                    if (!nameSalaryDict.ContainsKey(name))
                    {
                        nameSalaryDict[name] = 0d;
                    }
                    nameSalaryDict[name] = salary;
                }
                else
                {
                    if (!namePositionDict.ContainsKey(name))
                    {
                        namePositionDict[name] = string.Empty;
                    }
                    namePositionDict[name] = position;
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            if (input == "Age")
            {
                foreach (var nameAgePair in nameAgeDict)
                {
                    string name = nameAgePair.Key;
                    int age = nameAgePair.Value;

                    Console.WriteLine($"Name: {name}");
                    Console.WriteLine($"Age: {age}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (input == "Salary")
            {
                foreach (var nameSalaryPair in nameSalaryDict)
                {
                    string name = nameSalaryPair.Key;
                    double salary = nameSalaryPair.Value;

                    Console.WriteLine($"Name: {name}");
                    Console.WriteLine($"Salary: {salary:F2}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else
            {
                foreach (var namePositionPair in namePositionDict)
                {
                    string name = namePositionPair.Key;
                    string position = namePositionPair.Value;

                    Console.WriteLine($"Name: {name}");
                    Console.WriteLine($"Position: {position}");
                    Console.WriteLine(new string('=', 20));
                }
            }
        }
    }
}
