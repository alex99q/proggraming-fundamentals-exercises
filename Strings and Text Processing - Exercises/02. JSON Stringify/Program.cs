namespace _02.JSON_Stringify
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public List<int> Grades { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            List<Student> students = new List<Student>();

            while(input != "stringify")
            {
                string[] inputParameters = input.Split(new[] { ':', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                string name = string.Empty;
                int age = 0;
                List<int> grades = new List<int>();

                try
                {
                    name = inputParameters[0].Trim();
                    age = int.Parse(inputParameters[1].Trim());
                    grades = inputParameters[2].Split(',').Select(int.Parse).ToList();
                }
                catch (Exception) {}

                students.Add(new Student
                {
                    Name = name,
                    Age = age,
                    Grades = grades
                });

                input = Console.ReadLine();
            }

            Console.Write('[');
            for (int i = 0; i < students.Count; i++)
            {
                var student = students[i];

                string currentOutputLine = string.Concat("{name:", '"', student.Name, '"', $",age:{student.Age},", "grades:[", string.Join(", ", student.Grades), "]}");
                if (i < students.Count && i > 0)
                {
                    Console.Write(',');
                }

                Console.Write(currentOutputLine);
            }
            Console.WriteLine(']');
        }
    }
}
