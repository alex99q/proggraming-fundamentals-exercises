namespace _08.String_Encryption
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string encryptedString = string.Empty;

            for (int i = 0; i < n; i++)
            {
                char currentLetter = char.Parse(Console.ReadLine());
                encryptedString += Encrypt(currentLetter);
            }

            Console.WriteLine(encryptedString);
        }

        static string Encrypt(char letter)
        {
            int firstDigit = letter;

            while (firstDigit >= 10)
            {
                firstDigit /= 10;
            }
            int lastDigit = letter % 10;

            string firstAndLastDigit = $"{firstDigit}{lastDigit}";
            char firstChar = (char)(letter + lastDigit);
            char lastChar = (char)(letter - firstDigit);

            string result = firstChar + firstAndLastDigit + lastChar;
            return result;
        }
    }
}
