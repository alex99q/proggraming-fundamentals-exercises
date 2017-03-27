using System.IO;

namespace _2.Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileLines = File.ReadAllLines("../../../Resources/02. Line Numbers/Input.txt");

            string[] fileLinesWithNumbers = new string[fileLines.Length];

            for (int i = 0; i < fileLinesWithNumbers.Length; i++)
            {
                fileLinesWithNumbers[i] = (i + 1) + ". " + fileLines[i];
            }
            
            File.WriteAllLines("../../../Resources/02. Line Numbers/Output.txt", fileLinesWithNumbers);
        }
    }
}
