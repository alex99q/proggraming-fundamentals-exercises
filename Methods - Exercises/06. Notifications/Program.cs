using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Notifications
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string status = Console.ReadLine();

                if (status == "success")
                {
                    string operation = Console.ReadLine();
                    string message = Console.ReadLine();

                    Console.WriteLine(ShowSuccess(operation, message));
                }
                else if (status == "error")
                {
                    string operation = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());

                    Console.WriteLine(ShowError(operation, code));
                }
            }
                     
        }

        static string ShowSuccess(string operation, string message)
        {
            string result = $"Successfully executed {operation}.";
            result +=        "\n==============================";
            result +=       $"\nMessage: {message}.";

            return result;
        }

        static string ShowError(string operation, int code)
        {
            string reason = string.Empty;

            if(code < 0)
            {
                reason = "Internal System Failure";
            }
            else
            {
                reason = "Invalid Client Data";
            }

            string result = $"Error: Failed to execute {operation}.";
            result +=        "\n==============================";
            result +=       $"\nError Code: {code}.";
            result +=       $"\nReason: {reason}.";

            return result;
        }

    }
}
