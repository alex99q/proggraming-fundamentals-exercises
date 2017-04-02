namespace _3.User_Database
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Program
    {
        private static string databasePath = "Users.txt";
        private static string loggedInUser = null;
        private static Dictionary<string, string> users = new Dictionary<string, string>();


        public static void Main(string[] args)
        {
            if (!File.Exists(databasePath))
            {
                File.Create(databasePath).Close();
            }
            else
            {
                foreach (var user in File.ReadAllLines(databasePath))
                {
                    var userParameters = user.Split(' ');

                    string username = userParameters[0];
                    string password = userParameters[1];

                    users[username] = password;
                }
            }

            string[] input = File.ReadAllLines("Input.txt");

            foreach (var inputLine in input)
            {
                string[] commandParameters = inputLine.Split(' ');

                string command = commandParameters[0];

                if (command == "exit")
                    break;

                switch (command)
                {
                    case "register":
                        string username = commandParameters[1];
                        string password = commandParameters[2];
                        string confirmPassword = commandParameters[3];
                        Register(username, password, confirmPassword);
                        break;

                    case "login":
                        username = commandParameters[1];
                        password = commandParameters[2];
                        Login(username, password);
                        break;

                    case "logout":
                        Logout();
                        break;

                    default:
                        break;
                }
            }
        }

        private static void Logout()
        {
            if (loggedInUser == null)
            {
                Console.WriteLine("There is no currently logged in user.");
                return;
            }

            loggedInUser = null;
        }

        private static void Login(string username, string password)
        {
            if (!users.ContainsKey(username))
            {
                Console.WriteLine("There is no user with the given username.");
                return;
            }

            if (loggedInUser != null)
            {
                Console.WriteLine("There is already a logged in user.");
                return;
            }

            if (users[username] != password)
            {
                Console.WriteLine("The password you entered is incorrect.");
                return;
            }

            loggedInUser = username;
        }

        private static void Register(string username, string password, string confirmPassword)
        {
            if (users.ContainsKey(username))
            {
                Console.WriteLine("The given username already exists.");
                return;
            }

            if (password != confirmPassword)
            {
                Console.WriteLine("The two passwords must match.");
                return;
            }

            users[username] = password;
            File.AppendAllText(databasePath, $"{username} {password}\r\n");
        }
    }
}
