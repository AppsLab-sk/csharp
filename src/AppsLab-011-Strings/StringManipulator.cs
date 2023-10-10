using System.Security.Cryptography.X509Certificates;

namespace AppsLab_011_Strings;


public class StringManipulator
{
    
    public string AppendStrings(string first, string second)
    {
        string name = first + second;
        return name;
    }
   
    public string ConvertToUpper(string input)
    {
        string result = input;
        result = result.ToUpper();
        return result;
    } 
    public string ConvertToLower(string input)
    {
        string result = input.ToLower();     
        return result;
    }
    public bool ContainsSubstring(string input, string substring)
    {
        bool result = input.Contains(substring);
        return result;
    }
    public bool StartsWithSubstring(string input, string substring)
    {
        bool result =StartsWithSubstring(input, substring);
        return result;
    }
}