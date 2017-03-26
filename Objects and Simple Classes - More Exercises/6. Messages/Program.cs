using System;
using System.Collections.Generic;

namespace _6.Messages
{
    public class User
    {
        public string Username { get; set; }

        public List<Message> RecievedMessages { get; set; }
    }

    public class Message
    {
        public string Content { get; set; }

        public User Sender { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, User> users = new Dictionary<string, User>();

            bool hasMessages = false;

            while (input != "exit")
            {
                string[] inputTokens = input.Split(' ');

                if (inputTokens[0] == "register")
                {
                    string name = inputTokens[1];

                    users[name] = new User { Username = name };
                }
                else
                {
                    string senderUsername = inputTokens[0];
                    string recipientUsername = inputTokens[2];
                    string content = inputTokens[3];

                    if (users.ContainsKey(senderUsername) && users.ContainsKey(recipientUsername))
                    {
                        try
                        {
                            users[senderUsername].RecievedMessages.Add(new Message { Content = content });
                        }
                        catch (System.NullReferenceException)
                        {
                            users[senderUsername].RecievedMessages = new List<Message>();
                            users[senderUsername].RecievedMessages.Add(new Message { Content = content });
                        }

                        hasMessages = true;
                    }
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            string[] inputParameters = input.Split(' ');

            string sender = inputParameters[0];
            string recipient = inputParameters[1];


            if (hasMessages == true && users.ContainsKey(sender) && users.ContainsKey(recipient))
            {
                for (int i = 0; i < Math.Max(users[sender].RecievedMessages.Count, users[recipient].RecievedMessages.Count); i++)
                {

                    try
                    {
                        var senderMessage = users[sender].RecievedMessages[i];
                        Console.WriteLine($"{sender}: {senderMessage.Content}");
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {
                    }

                    try
                    {
                        var recipientMessage = users[recipient].RecievedMessages[i];
                        Console.WriteLine($"{recipientMessage.Content} :{recipient}");
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {
                    }
                }
            }
            else
            {
                Console.WriteLine("No Messages");
            }
        }
    }
}