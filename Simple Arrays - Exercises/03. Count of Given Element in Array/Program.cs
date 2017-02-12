namespace _03.Count_of_Given_Element_in_Array
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int inputElement = int.Parse(Console.ReadLine());

            int numberOfElements = 0;
            foreach (var number in numbers)
            {
                if (number == inputElement)
                {
                    numberOfElements++;
                }
            }

            Console.WriteLine(numberOfElements);
        }
    }
}
