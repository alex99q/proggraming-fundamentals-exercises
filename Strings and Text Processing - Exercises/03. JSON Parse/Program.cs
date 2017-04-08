namespace _03.JSON_Parse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public List<int> Grades { get; set; }

        public static Student Parse(string s)
        {
            string[] inputParameters = s.Split(',');

            string name = inputParameters[0]
                .Split(':')[1]
                .Trim('"');

            int age = int.Parse
                (
                    inputParameters[1]
                    .Split(':')[1]
                );

            inputParameters[2] = s.Split('[')[1];
            List<int> grades = new List<int>();
            try
            {
                grades = inputParameters[2]
                    .TrimEnd(']')
                    .Split(',')
                    .Select(n => int.Parse(n))
                    .ToList();
            }
            catch (System.FormatException)
            {
                grades = null;
            }

            return new Student
            {
                Name = name,
                Age = age,
                Grades = grades
            };
        }
    }

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            int startIndex = input.IndexOf('{');
            int endIndex = input.IndexOf('}');

            List<Student> students = new List<Student>();

            while (startIndex != -1)
            {
                string unparsedStudent = input.Substring(startIndex + 1, (endIndex - startIndex) - 1);

                students.Add(Student.Parse(unparsedStudent));

                startIndex = input.IndexOf('{', startIndex + 1);
                endIndex = input.IndexOf('}', endIndex + 1);
            }

            foreach (var student in students)
            {
                Console.Write($"{student.Name} : {student.Age} -> ");

                if (student.Grades == null)
                {
                    Console.WriteLine("None");
                }
                else
                {
                    Console.WriteLine(string.Join(", ", student.Grades));
                }
            }
        }
    }
}
