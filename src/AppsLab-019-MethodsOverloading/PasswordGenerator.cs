namespace AppsLab_019_MethodsOverloading
{
    public class PasswordGenerator
    {
        private const string Letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string SpecialChars = "!@#$%^&*()_+-=[]{}|;:'\",.<>?";

        public string GeneratePassword()
        {
            var random = new Random();
            var result = "";

            for (int i = 0; i < 8; i++)
            {
                result += Alphabet[random.Next(0, 25)];
            }
            return result;

        public string GeneratePassword(int length)
        {
            return GeneratePassword(length, false, false);
        }

            for (int i = 0; i < length; i++) ;
            {
                result += Alphabet[random.Next(0, 25)];
            }

            StringBuilder password = new StringBuilder();

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

            for (int i = 0; i < length; i++ )
            {
                result += Alphabet[random.Next(0, 25)];
            }
            return result;

        }