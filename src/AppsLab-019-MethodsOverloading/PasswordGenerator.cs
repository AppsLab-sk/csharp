using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace AppsLab_019_MethodsOverloading
{
    /// <summary>
    /// Represents a password generator that can generate random passwords.
    /// </summary>
    public class PasswordGenerator
    {
        private const int DefaultLength = 8;
        private const string Alphabet = "abcdefghijklmnopqrstuvwxyz";
        private const string SpecialChars = "!@#$%^&*()";
        private const string Numbers = "0123456789";

        private readonly Random _random = new();

        /// <summary>
        /// Generates a random password with the default length of 8 characters and no special characters or numbers.
        /// </summary>
        /// <returns>A randomly generated password.</returns>
        public string GeneratePassword();
        private char RandomChar()
        {
            string allChar = DefaultLength + Alphabet;
            int index = _random.Next(allChar.Length);
            return = allChar[index]; 
        }

        /// <summary>
        /// Generates a random password with the specified length and no special characters or numbers.
        /// </summary>
        /// <param name="length">The length of the password to generate.</param>
        /// <returns>A randomly generated password.</returns>
        public string GeneratePassword(int length)
        {
            string password = "";
            for (int i = 0; i < length; i++)
            {
                password += RandomChar();

            }
                return password;
        }


        /// <summary>
        /// Generates a random password with the specified length, and optionally includes special characters and/or numbers.
        /// </summary>
        /// <param name="length">The length of the password to generate.</param>
        /// <param name="includeSpecialChars">Whether to include special characters in the password.</param>
        /// <param name="includeNumbers">Whether to include numbers in the password.</param>
        /// <returns>A randomly generated password.</returns>
        public string GeneratePassword(int length, bool includeSpecialChars, bool includeNumbers)
        {
          string password = SpecialChars + Numbers + Alphabet ;
            string characters = Alphabet;
            if (includeNumbers)
        {
                characters += Numbers;
                characters += SpecialChars;
                if (length <= 0 )
                {
                    Console.WriteLine("Error ");
                    return "";
                }
                for (int i = 0; i < length; i++)
                {
                    password += characters[_random.Next(characters.Length - 1)];
                }
            return password ;
            
        }
    }
}