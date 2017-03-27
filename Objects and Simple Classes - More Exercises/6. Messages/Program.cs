using System;
using System.Collections.Generic;
using System.Linq;

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

                    users[name] = new User { Username = name, RecievedMessages = new List<Message>()};
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
                            users[recipientUsername].RecievedMessages.Add(new Message { Content = content, Sender = users[senderUsername]});
                        }
                        catch (System.NullReferenceException)
                        {
                            users[recipientUsername].RecievedMessages = new List<Message>();
                            users[recipientUsername].RecievedMessages.Add(new Message { Content = content, Sender = users[senderUsername] });
                        }

                        hasMessages = true;
                    }
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            string[] inputParameters = input.Split(' ');

            string firstUser = inputParameters[0];
            string secondUser = inputParameters[1];


            if (hasMessages == true && users.ContainsKey(firstUser) && users.ContainsKey(secondUser))
            {
                for (int i = 0; i < Math.Max(users[firstUser].RecievedMessages.Count, users[secondUser].RecievedMessages.Count); i++)
                {

                    try
                    {
                        string firstMessage = users.Values.Where(x => x.Username == secondUser).SelectMany(x => x.RecievedMessages).Where(x => x.Sender.Username == firstUser).Select(x => x.Content).ToList()[i];

                        Console.WriteLine($"{firstUser}: {firstMessage}");
                    }
                    catch (System.ArgumentOutOfRangeException){}

                    try
                    {
                        string secondMessage = users.Values.Where(x => x.Username == firstUser).SelectMany(x => x.RecievedMessages).Where(x => x.Sender.Username == secondUser).Select(x => x.Content).ToList()[i];

                        Console.WriteLine($"{secondMessage} :{secondUser}");

                    }
                    catch (System.ArgumentOutOfRangeException){}
                }
            }
            else
            {
                Console.WriteLine("No Messages");
            }
        }
    }
}