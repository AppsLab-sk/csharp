using System.ComponentModel.Design;
using System.Threading.Channels;

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
            //ctrl + click
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
                //generuje 27 cisiel
                    int randomNumber = _random.Next(27);
                //dava tie cisla do a-z alb to stringu, idk, asi, robi to ale podla dlzky
                    password = password + Alphabet[randomNumber].ToString();
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
            
            string pasword = GeneratePassword(length);

            if (includeSpecialChars) 
            {
         
                int index = _random.Next(0, 9);
                pasword.Replace(pasword[length - 1], SpecialChars[index]);

                //ask chat gpt or something....
            }
            if (includeNumbers)
            {

                int numIndex = _random.Next(0, 9);
                pasword.Replace(pasword[0], Numbers[numIndex]);
            }
         return pasword;
            }
    }
}


// napis "cw" a potom tab a mas insta Console.WriteLine();