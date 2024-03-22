using System;
using System.Security.Cryptography.X509Certificates;

namespace AppsLab_007_Casting;

/// <summary>
/// This class contains methods to convert between different data types.
/// </summary>
public class Converter
{
    /// <summary>
    /// This method converts a string to an integer. 
    /// </summary>;                               
    public double IntToDouble(int number)
    {
        double result;
        result = (double)number;
        return result;  
        
    }
    public int DoubleToInt(double number)
    {
        int result;
        result = (int)number;
        return result;

    }     

 /// <summary>
    /// This method converts a double to an integer.
     public double DoubleToDouble(string number) 
    {
        double result;
        result = Double.Parse(number);
        return result;

      }   

     
   

    /// <summary>
    /// This method converts a double to a string.
    /// </summary>
    public string DoubleToString(double number)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// This method converts a string to a boolean.
    /// </summary>
    public string IntToString(int number)
    {
        String result;
        result = number + "";
        return result;

    }

    /// <summary>
    /// This method converts a boolean to a string.
    /// </summary>
    public bool StringToBool(string boolValue)
    {
        bool result;
        result= Convert.ToBoolean(boolValue);
        return result;

    }


    /// <summary>
    /// This method converts a boolean to a string.
    /// </summary>
    public string BoolToString(bool boolValue)
        {
            string result;  
            result = boolValue.ToString();
            return result;

        }
       }
    












   