namespace AppsLab_009_Operators;

/// <summary>
/// This class contains methods for performing basic arithmetic operations.
/// </summary>
public class Calculator
{
    /// <summary>
    /// This method adds two integers and returns the sum.
    /// </summary>
    public int Add(int a, int b)
    {
        int sum = a + b;
        return sum;
    }

    /// <summary>
    /// This method subtracts two integers and returns the difference.
    /// </summary>
    public int Subtract(int a, int b)
    {
        int difference = a-b;
        return difference;  
                
    }

    /// <summary>
    /// This method multiplies two integers and returns the product.
    /// </summary>
    public int Multiply(int a, int b)
    {
        int product = a*b;
        return product;
    }

    /// <summary>
    /// This method divides two integers and returns the quotient.
    /// </summary>
    public double Divide(int a, int b)
    {
        double division = (double)a / b;
        return division;                    
    }

    /// <summary>
    /// This method divides two integers and returns the remainder.
    /// </summary>
    public int Remainder(int a, int b)
    {
        int remainder = a % b;
        return remainder;
    }

    /// <summary>
    /// This method returns true if the two integers are equal.
    /// </summary>
    public bool AreEqual(int a, int b)
    {
        bool equality = a == b;
        return equality;    
    }

    /// <summary>
    /// This method returns true if the two integers are not equal.
    /// </summary>
    public bool AreNotEqual(int a, int b)
    {
        bool inequality = a !=b;
        return inequality;
    }

    /// <summary>
    /// This method returns true if the first integer is greater than the second.
    /// </summary>
    public bool IsGreater(int a, int b)
    {
       bool greater = a > b;
        return greater;
    }

    /// <summary>
    /// This method returns true if the first integer is lesser than the second.
    /// </summary>
    public bool IsLesser(int a, int b)
    {
        bool lesser = a < b;
        return lesser;
    }

    /// <summary>
    /// This method returns true if the first integer is greater than or equal to the second.
    /// </summary>
    public bool IsGreaterOrEqual(int a, int b)
    {
        bool greaterEqual = a >= b;
        return greaterEqual;
    }

    /// <summary>
    /// This method returns true if the first integer is lesser than or equal to the second.
    /// </summary>
    public bool IsLesserOrEqual(int a, int b)
    {
        bool lesserEqual = a <= b;
        return lesserEqual;
    }
}
