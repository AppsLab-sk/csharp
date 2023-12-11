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
            var random = new Random();
            var result = "";

            for (int i = 0; i < 8; i++)
            {
                result += Alphabet[random.Next(0, 25)];
            }
            return result;
        }

        /// <summary>
        /// Generates a random password with the specified length and no special characters or numbers.
        /// </summary>
        /// <param name="length">The length of the password to generate.</param>
        /// <returns>A randomly generated password.</returns>
        public string GeneratePassword(int length)
        {
            var random = new Random();
            var result = "";

            for (int i = 0; i < length; i++)
            {
                result += Alphabet[random.Next(0, 25)];
            }
            return result;
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
            var charBook = Alphabet;
            var random = new Random();
            var result = "";

            if (includeSpecialChars)
            {
                charBook += SpecialChars;
            }
            if (includeNumbers)
            {
                charBook += Numbers;
            }

            for (int i = 0; i < length; i++)
            {
                result += charBook[random.Next(0, charBook.Length - 1)];
            }
            return result;
        }
    }
}