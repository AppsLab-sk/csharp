namespace AppsLab_011_Strings;

/// <summary>
/// Provides methods for manipulating strings.
/// </summary>
public class StringManipulator
{
    /// <summary>
    /// Appends two strings together.
    /// </summary>
    /// <param name="first">The first string.</param>
    /// <param name="second">The second string.</param>
    /// <returns>The concatenated string.</returns>
    public string AppendStrings(string first, string second)
    {
        string  fullName = first + " " + second;
        return fullName;
    }

    /// <summary>
    /// Converts a string to uppercase.
    /// </summary>
    /// <param name="input">The string to convert.</param>
    /// <returns>The uppercase string.</returns>
    public string ConvertToUpper(string input)
    {
        string result = input;
        result = result.ToUpper();
        return result;
    }

    /// <summary>
    /// Converts a string to lowercase.
    /// </summary>
    /// <param name="input">The string to convert.</param>
    /// <returns>The lowercase string.</returns>
    public string ConvertToLower(string input)
    {
        string result = input;
        result = result.ToLower();
        return result;
    }

    /// <summary>
    /// Determines if a string contains a substring.
    /// </summary>
    /// <param name="input">The string to search.</param>
    /// <param name="substring">The substring to search for.</param>
    /// <returns>True if the substring is found, false otherwise.</returns>
    public bool ContainsSubstring(string input, string substring)
    {
      bool result = input.Contains(substring);
        return result;
    }

    /// <summary>
    /// Determines if a string starts with a substring.
    /// </summary>
    /// <param name="input">The string to search.</param>
    /// <param name="substring">The substring to search for.</param>
    /// <returns>True if the string starts with the substring, false otherwise.</returns>
    public bool StartsWithSubstring(string input, string substring)
    {
        bool result = StartsWithSubstring(input, substring);
        return result;
    }
}