using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Social_Media_Posts
{
    class Program
    {
        static void Main(string[] args)
        {
            var socialMediaDict = new Dictionary<string, Dictionary<string, List<string>>>();

            string input = Console.ReadLine();

            while (input != "drop the media")
            {
                string[] inputTokens = input.Split(' ');

                string command = inputTokens[0];
                string post = inputTokens[1];

                if (command == "post")
                {
                    if (!socialMediaDict.ContainsKey(post))
                    {
                        socialMediaDict[post] = new Dictionary<string, List<string>>();
                    }
                }

                else if (command == "like")
                {
                    if (!socialMediaDict[post].ContainsKey("like"))
                    {
                        socialMediaDict[post]["like"] = new List<string>();
                    }

                    socialMediaDict[post]["like"].Add("like");
                }

                else if (command == "dislike")
                {
                    if (!socialMediaDict[post].ContainsKey("dislike"))
                    {
                        socialMediaDict[post]["dislike"] = new List<string>();
                    }

                    socialMediaDict[post]["dislike"].Add("dislike");
                }

                else if (command == "comment")
                {
                    string commentatorName = inputTokens[2];
                    List<string> commentWords = new List<string>();

                    for (int i = 3; i <= inputTokens.Length - 1; i++)
                    {
                        commentWords.Add(inputTokens[i]);
                    }
                    
                    if (!socialMediaDict[post].ContainsKey(commentatorName))
                    {
                        socialMediaDict[post][commentatorName] = new List<string>();
                    }
                    socialMediaDict[post][commentatorName].Add(string.Join(" ", commentWords));
                }

                input = Console.ReadLine();
            }

            foreach (var socialMediaPair in socialMediaDict)
            {
                string post = socialMediaPair.Key;
                var commentatorCommentsDict = socialMediaPair.Value;

                if (!commentatorCommentsDict.ContainsKey("like"))
                {
                    commentatorCommentsDict["like"] = new List<string>();
                }
                int likes = commentatorCommentsDict["like"].Count;

                if (!commentatorCommentsDict.ContainsKey("dislike"))
                {
                    commentatorCommentsDict["dislike"] = new List<string>();
                }
                int dislikes = commentatorCommentsDict["dislike"].Count;

                Console.WriteLine($"Post: {post} | Likes: {likes} | Dislikes: {dislikes}");
                Console.WriteLine("Comments:");

                if (commentatorCommentsDict.Count - 2 == 0)
                {
                    Console.WriteLine("None");
                }
                else
                {
                    foreach (var commentatorCommentsPair in commentatorCommentsDict)
                    {
                        string commentator = commentatorCommentsPair.Key;

                        if (commentator == "like" || commentator == "dislike")
                            continue;

                        var comments = commentatorCommentsPair.Value;

                        foreach (var comment in comments)
                        {
                            Console.WriteLine($"*  {commentator}: {comment}");
                        }
                    }
                }

            }
        }
    }
}
