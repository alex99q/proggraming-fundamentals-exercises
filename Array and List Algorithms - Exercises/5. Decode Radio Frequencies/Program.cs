using System;
using System.Collections.Generic;

namespace _5.Decode_Radio_Frequencies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            List<string> result = new List<string>();

            int indexOfResult = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string ASCII_CodeOfSecondChar = "0";
                string ASCII_CodeOfFirstChar = "0";

                bool isSwitched = false;
                string currentString = input[i];

                //cycles through the current double writes the number after the dot in ASCII_CodeOfSecondChar
                for (int j = 0; j < currentString.Length; j++)
                {
                    if (currentString[j] == '.')
                        isSwitched = true;

                    if (isSwitched == true)
                    {
                        if (currentString[j] != '.')
                            ASCII_CodeOfSecondChar += currentString[j];
                    }
                    else
                    {
                        ASCII_CodeOfFirstChar += currentString[j];
                    }
                }
                ////////////////////////////////////////////////////////////////////////////////////////////

                char firstChar = (char)int.Parse(ASCII_CodeOfFirstChar);
                char secondChar = (char)int.Parse(ASCII_CodeOfSecondChar);

                if (firstChar != 0)
                {
                    result.Insert(indexOfResult, firstChar.ToString());
                }
                if(secondChar != 0)
                {
                    result.Insert(indexOfResult, secondChar.ToString());
                }

                indexOfResult++;
            }

            result.Reverse();

            Console.WriteLine(string.Join("", result));
        }
    }
}
