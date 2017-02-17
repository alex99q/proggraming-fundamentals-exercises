using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ');
            string[] names = Console.ReadLine().Split(' ');
            char[] unalowedChars = { ' ', '*', '.', '(', ')', '+', '-', '_', ';', ':' };

            string[] input = new string[2];
            while (input[0] != "done")
            {
                input = Console.ReadLine().Split();
                string command = input[0];
                string numberOrName = string.Empty;

                if (input[0] != "done")
                numberOrName = input[1];

                for (int i = 0; i < names.Length; i++)
                {
                    if (command == "call" && (numberOrName == names[i] || numberOrName == phoneNumbers[i]))
                    {
                        if (numberOrName == names[i])
                            Console.WriteLine($"calling {phoneNumbers[i]}...");
                        else if (numberOrName == phoneNumbers[i])
                            Console.WriteLine($"calling {names[i]}...");

                        int result = 0;
                        string trimmedNumber = phoneNumbers[i].Trim(unalowedChars);
                        for (int j = 0; j < trimmedNumber.Length; j++)
                        {
                            result += trimmedNumber[j] - '0';
                        }
                        
                        if (result % 2 != 0)
                        {
                            Console.WriteLine("no answer");
                        }
                        else
                        {
                            int minutes = result / 60;
                            int seconds = result % 60;
                            string duration = string.Empty;

                            if (seconds < 10 && minutes < 10)
                                duration = $"0{minutes}:0{seconds}";
                            else if (minutes < 10)
                                duration = $"0{minutes}:{seconds}";
                            else if (seconds < 10)
                                duration = $"{minutes}:0{seconds}";

                            Console.WriteLine($"call ended. duration: {duration}");
                        }
                    }
                    else if (command == "message" && (numberOrName == names[i] || numberOrName == phoneNumbers[i]))
                    {
                        
                        if (numberOrName == names[i])
                            Console.WriteLine($"sending sms to {phoneNumbers[i]}...");
                        else if (numberOrName == phoneNumbers[i])
                            Console.WriteLine($"sending sms to {names[i]}...");

                        int result = 0;
                        string trimmedNumber = phoneNumbers[i].Trim(unalowedChars);
                        for (int j = 0; j < trimmedNumber.Length; j++)
                        {
                            result += trimmedNumber[j] - '0';
                        }

                        if (result % 2 != 0)
                        {
                            Console.WriteLine("busy");
                        }
                        else
                        {
                            Console.WriteLine("meet me there");
                        }
                    }
                }
            }
        }
    }
}
