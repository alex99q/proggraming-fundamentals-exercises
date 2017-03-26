using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Animals
{
    public class Dog
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int NumberOfLegs { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
        }

        public static Dog Parse(string s)
        {
            string[] stringParameters = s.Split(' ').Skip(1).ToArray();

            return new Dog
            {
                Name = stringParameters[0],
                Age = int.Parse(stringParameters[1]),
                NumberOfLegs = int.Parse(stringParameters[2])
            };
        }
    }

    public class Cat
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int IntelligenceQuotient { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
        }

        public static Cat Parse(string s)
        {
            string[] stringParameters = s.Split(' ').Skip(1).ToArray();

            return new Cat
            {
                Name = stringParameters[0],
                Age = int.Parse(stringParameters[1]),
                IntelligenceQuotient = int.Parse(stringParameters[2])
            };
        }
    }

    public class Snake
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int CrueltyCoefficient { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
        }

        public static Snake Parse(string s)
        {
            string[] stringParameters = s.Split(' ').Skip(1).ToArray();

            return new Snake
            {
                Name = stringParameters[0],
                Age = int.Parse(stringParameters[1]),
                CrueltyCoefficient = int.Parse(stringParameters[2])
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Cat> cats = new Dictionary<string, Cat>();
            Dictionary<string, Dog> dogs = new Dictionary<string, Dog>();
            Dictionary<string, Snake> snakes = new Dictionary<string, Snake>();

            string input = Console.ReadLine();

            while (input != "I'm your Huckleberry")
            {
                string[] inputTokens = input.Split(' ');

                string animalOrCommand = inputTokens[0];
                string name = inputTokens[1];

                if (animalOrCommand == "talk")
                {
                    if (dogs.ContainsKey(name))
                    {
                        dogs[name].ProduceSound();
                    }
                    else if (cats.ContainsKey(name))
                    {
                        cats[name].ProduceSound();
                    }
                    else if (snakes.ContainsKey(name))
                    {
                        snakes[name].ProduceSound();
                    }
                }
                else
                {
                    if (animalOrCommand == "Dog")
                    {
                        Dog currentDog = Dog.Parse(input);

                        dogs[name] = currentDog;
                    }
                    else if (animalOrCommand == "Cat")
                    {
                        Cat currentCat = Cat.Parse(input);

                        cats[name] = currentCat;
                    }
                    else if (animalOrCommand == "Snake")
                    {
                        Snake currentSnake = Snake.Parse(input);

                        snakes[name] = currentSnake;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var dog in dogs.Values)
            {
                Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.NumberOfLegs}");
            }

            foreach (var cat in cats.Values)
            {
                Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.IntelligenceQuotient}");
            }

            foreach (var snake in snakes.Values)
            {
                Console.WriteLine($"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.CrueltyCoefficient}");
            }
        }
    }
}
