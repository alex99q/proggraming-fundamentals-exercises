using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Note_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputFrequencies = Console.ReadLine().Split().Select(double.Parse).ToArray();
            //double[] secondInputFrequencies = Console.ReadLine().Split().Select(double.Parse).ToArray();

            string[] allNotes = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
            double[] frequencies = { 261.63, 277.18, 293.66, 311.13, 329.63, 349.23, 369.99, 392.00, 415.30, 440.00, 466.16, 493.88 };

            List<string> notes = new List<string>();
            List<string> naturalNotes = new List<string>();
            List<string> sharpNotes = new List<string>();
            List<double> naturalFrequencies = new List<double>();
            List<double> sharpFrequencies = new List<double>();

            foreach (var frequency in inputFrequencies)
            {
                int i = Array.IndexOf(frequencies, frequency);
                notes.Add(allNotes[i]);

                if (allNotes[i].Contains("#"))
                {
                    sharpNotes.Add(allNotes[i]);
                    sharpFrequencies.Add(frequencies[i]);
                }
                else
                {
                    naturalNotes.Add(allNotes[i]);
                    naturalFrequencies.Add(frequencies[i]);
                }
                
            }

            Console.WriteLine($"Notes: {string.Join(" ", notes)}");
            Console.WriteLine($"Naturals: {string.Join(", ", naturalNotes)}");
            Console.WriteLine($"Sharps: {string.Join(", ", sharpNotes)}");
            Console.WriteLine($"Naturals sum: {naturalFrequencies.Sum()}");
            Console.WriteLine($"Sharps sum: {sharpFrequencies.Sum()}");

            for (int i = 0; i < 100; i++)
            {
                foreach (int frequency in inputFrequencies)
                {
                    Console.Beep(frequency, 200);
                }
                //foreach (int frequency in secondInputFrequencies)
                //{
                //    Console.Beep(frequency, 200);
                //}
            }
        }
    }
}
