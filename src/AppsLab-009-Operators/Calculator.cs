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
        return a + b;
    }

    /// <summary>
    /// This method subtracts two integers and returns the difference.
    /// </summary>
    public int Subtract(int a, int b)
    {
        return a - b;
    }

    /// <summary>
    /// This method multiplies two integers and returns the product.
    /// </summary>
    public int Multiply(int a, int b)
    {
        return a*b;
    }

    /// <summary>
    /// This method divides two integers and returns the quotient.
    /// </summary>
    public double Divide(int a, int b)
    {
        return (double)a /b;
    }

    /// <summary>
    /// This method divides two integers and returns the remainder.
    /// </summary>
    public int Remainder(int a, int b)
    {
        return a % b;
    }

    /// <summary>
    /// This method returns true if the two integers are equal.
    /// </summary>
    public bool AreEqual(int a, int b)
    {
        return a== b;
    }

    /// <summary>
    /// This method returns true if the two integers are not equal.
    /// </summary>
    public bool AreNotEqual(int a, int b)
    {
        return a != b;
    }

    /// <summary>
    /// This method returns true if the first integer is greater than the second.
    /// </summary>
    public bool IsGreater(int a, int b)
    {
        return a > b;
    }

    /// <summary>
    /// This method returns true if the first integer is lesser than the second.
    /// </summary>
    public bool IsLesser(int a, int b)
    {
        return a < b;
    }

    /// <summary>
    /// This method returns true if the first integer is greater than or equal to the second.
    /// </summary>
    public bool IsGreaterOrEqual(int a, int b)
    {
        return a >= b;
    }

    /// <summary>
    /// This method returns true if the first integer is lesser than or equal to the second.
    /// </summary>
    public bool IsLesserOrEqual(int a, int b)
    {
        return a <= b;
    }
}
