using System;
using System.Collections.Generic;

namespace _5.User_Logins
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> usernamePasswordDict = new Dictionary<string, string>();

            string input = Console.ReadLine();

            while (input != "login")
            {
                string[] inputTokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string username = inputTokens[0];
                string password = inputTokens[inputTokens.Length - 1];

                if (!usernamePasswordDict.ContainsKey(username))
                {
                    usernamePasswordDict.Add(username, password);
                }
                else
                {
                    usernamePasswordDict[username] = password;
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            int unsuccessfulLoginAttempts = 0;
            while(input != "end")
            {
                string[] inputTokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string username = inputTokens[0];
                string password = inputTokens[inputTokens.Length - 1];

                if (usernamePasswordDict.ContainsKey(username))
                {
                    if (usernamePasswordDict[username] == password)
                    {
                        Console.WriteLine($"{username}: logged in successfully");
                    }
                    else
                    {
                        Console.WriteLine($"{username}: login failed");
                        unsuccessfulLoginAttempts++;
                    }
                }
                else
                {
                    Console.WriteLine($"{username}: login failed");
                    unsuccessfulLoginAttempts++;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"unsuccessful login attempts: {unsuccessfulLoginAttempts}");
        }
    }
}
