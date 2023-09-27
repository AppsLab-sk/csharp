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
        return Convert.ToDouble(number);
    }

    /// <summary>
    /// This method converts a double to an integer.
    /// </summary>
    public int DoubleToInt(double number)
    {
        return (int)number;
    }
    
    /// <summary>
    /// This method converts a string to a double.
    /// </summary>
    public double StringToDouble(string number)
    {
        return Convert.ToDouble(number);
    }
    
    /// <summary>
    /// This method converts a double to a string.
    /// </summary>
    public string DoubleToString(double number)
    {
        return number.ToString();
    }

    /// <summary>
    /// This method converts a string to a boolean.
    /// </summary>
    public string IntToString(int number)
    {
        return number.ToString();
    }

    /// <summary>
    /// This method converts a boolean to a string.
    /// </summary>
    public bool StringToBool(string boolValue)
    {
        return Convert.ToBoolean(boolValue);
    }

    /// <summary>
    /// This method converts a boolean to a string.
    /// </summary>
    public string BoolToString(bool boolValue)
    {
        return boolValue.ToString();
    }
}
