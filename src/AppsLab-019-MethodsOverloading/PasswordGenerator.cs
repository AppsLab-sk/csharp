using System;

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
        public string GeneratePassword()
        {
            return GeneratePassword(DefaultLength);
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
                int rondomNumber = _random.Next(27);
                password = password + Alphabet[rondomNumber].ToString();
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
            string password = GeneratePassword(length);
            if (includeSpecialChars)
            {
                int index = _random.Next(10);
                password.Replace(password[length - 1], SpecialChars[index]);
            }
            if (includeNumbers)
            {
                int Index1 = _random.Next(10);
                password.Replace(password[0], Numbers[Index1]);
            }
            return password;
        }
    }
}