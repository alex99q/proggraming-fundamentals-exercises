using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Exercise> exercises = new List<Exercise>();

            while(input != "go go go")
            {
                Exercise currentExercise = Exercise.Parse(input);

                exercises.Add(currentExercise);

                input = Console.ReadLine();
            }

            foreach (var exercise in exercises)
            {
                Console.WriteLine($"Exercises: {exercise.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{exercise.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {exercise.JudgeContestLink}");

                for (int i = 0; i < exercise.Problems.Count; i++)
                {
                    string currentProblem = exercise.Problems[i];

                    Console.WriteLine($"{i + 1}. {currentProblem}");
                }
            }
        }
    }

    public class Exercise
    {
        public string Topic { get; set; }

        public string CourseName { get; set; }

        public string JudgeContestLink { get; set; }

        public List<string> Problems { get; set; }

        public static Exercise Parse(string input)
        {
            string[] inputParameters = input.Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            List<string> problems = inputParameters[3].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

            return new Exercise
            {
                Topic = inputParameters[0].Trim(),
                CourseName = inputParameters[1].Trim(),
                JudgeContestLink = inputParameters[2].Trim(),
                Problems = problems
            };
        }
    }
}
