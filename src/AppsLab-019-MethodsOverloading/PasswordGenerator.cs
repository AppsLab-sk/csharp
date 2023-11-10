using System;
using System.Text;

namespace AppsLab_019_MethodsOverloading
{
    public class PasswordGenerator
    {
        private const string Letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string SpecialChars = "!@#$%^&*()_+-=[]{}|;:'\",.<>?";

        public string GeneratePassword()
        {
            return GeneratePassword(8, false, false);
        }

        public string GeneratePassword(int length)
        {
            return GeneratePassword(length, false, false);
        }

        public string GeneratePassword(int length, bool includeSpecialChars, bool includeNumbers)
        {
            if (length <= 0)
            {
                throw new ArgumentException("Length must be greater than zero.");
            }

            StringBuilder password = new StringBuilder();

            // Pridaj písmená
            password.Append(GenerateRandomCharacters(Letters, length));

            // Pridaj špeciálne znaky, ak je požadované
            if (includeSpecialChars)
            {
                password.Append(GenerateRandomCharacters(SpecialChars, 1));
            }

            // Pridaj èísla, ak je požadované
            if (includeNumbers)
            {
                password.Append(GenerateRandomCharacters("0123456789", 1));
            }

            return password.ToString();
        }

        private string GenerateRandomCharacters(string characterSet, int count)
        {
            Random random = new Random();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                int index = random.Next(characterSet.Length);
                result.Append(characterSet[index]);
            }

            return result.ToString();
        }
    }
}
