using System;
using System.IO;

namespace _1.Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] fileLines = File.ReadAllLines("D:/Programirane/Programming Fundamentals/Files, Directories and Exceptions - Lab/Resources/01. Odd Lines/input.txt");

            string[] fileLines = File.ReadAllLines("../../../Resources/01. Odd Lines/Input.txt");

            for (int i = 1; i < fileLines.Length; i += 2)
            {
                File.AppendAllText("../../../Resources/01. Odd Lines/Output.txt", fileLines[i] + Environment.NewLine);
            }
        }
    }
}
