using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace RegisterUsers
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string input = Console.ReadLine();

			Dictionary<string, DateTime> usernameRegistrationDate = new Dictionary<string, DateTime>();

			while (input != "end")
			{
				string[] inputTokens = input.Split("-> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                string username = inputTokens[0];
                string date = inputTokens[1];

				usernameRegistrationDate[username] = DateTime.ParseExact(date, "dd/mm/yyyy", CultureInfo.InvariantCulture);

				input = Console.ReadLine();
			}

			usernameRegistrationDate = 
                usernameRegistrationDate
                    .Reverse()
                    .OrderBy(n => n.Value)
                    .Take(5)
                    .OrderByDescending(n => n.Value)
                    .ToDictionary(n => n.Key, n => n.Value);

            foreach (var username in usernameRegistrationDate.Keys)
            {
                Console.WriteLine(username);
            }
		}
	}
}
	