namespace AppsLab_007_Casting;

/// <summary>
/// This class contains methods to convert between different data types.
/// </summary>
public class Converter
{
    /// <summary>
    /// This method converts a string to an integer.
    /// </summary>
    public double IntToDouble(int number)
    {
        double mojDouble = (double)number;
        return mojDouble;
    }

    /// <summary>
    /// This method converts a double to an integer.
    /// </summary>
    public int DoubleToInt(double number)
    {
        int mojInt = (int)number;
        return mojInt;
    }

    /// <summary>
    /// This method converts a string to a double.
    /// </summary>
    public double StringToDouble(string number)
    {
        string a = number;
        string result = a.Replace(".", ",");
        return Convert.ToDouble(result);
    }
    /// <summary>
    /// This method converts a double to a string.
    /// </summary>
    public string DoubleToString(double number)
    {
        double a = number;
        string b = Convert.ToString(a);
        b = b.Replace(",", ".");
        return b;
    }

    /// <summary>
    /// This method converts a string to a boolean.
    /// </summary>
    public string IntToString(int number)
    {
        int a = number;
        string b = Convert.ToString(a);
        b = b.Replace(",", ".");
        return b;
    }

    /// <summary>
    /// This method converts a boolean to a string.
    /// </summary>
    public bool StringToBool(string boolValue)
    {
       string a = boolValue;
       bool b = Convert.ToBoolean(a);
       
       return b;
    }

    /// <summary>
    /// This method converts a boolean to a string.
    /// </summary>
    public string BoolToString(bool boolValue)
    {
        bool a = boolValue;
        string b = Convert.ToString(a);
        return b;
    }
}
