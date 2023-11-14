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
            string password = "";
            for (int i = 0; i < DefaultLength; i++)
            {   
                password += Alphabet[_random.Next(Alphabet.Length-1)];
            }
            return password;
            
        }

        /// <summary>
        /// Generates a random password with the specified length and no special characters or numbers.
        /// </summary>
        /// <param name="length">The length of the password to generate.</param>
        /// <returns>A randomly generated password.</returns>
        public string GeneratePassword(int length)
        {
           if(length <= 0)
            {
                Console.WriteLine("Error");
                return "";
            }
            string password = "";            
            for (int i = 0; i < length; i++)
            {
                password += Alphabet[_random.Next(Alphabet.Length - 1)];
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
            string password = "";//Alphabet + SpecialChars + Numbers;
            string characters = Alphabet;
            if (includeNumbers) 
            {
                characters += Numbers;
            }
            if(includeSpecialChars) 
            {
            characters = SpecialChars;
            }
            for (int i = 0; i < length; i++)
            {
                password += characters[_random.Next(characters.Length - 1)];
            }
            return password;

        }
    }
}