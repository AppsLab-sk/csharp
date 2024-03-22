using System.Diagnostics.Metrics;

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public int Subtract(int a, int b)
    {
        return a - b;
    }
    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public double Divide(int a, int b)
    {
        return (double)a / (double)b;
    }
    public int Remainder(int a, int b)
    {
        return a % b;
    }
    public bool AreEqual(int a, int b)
    {
        return a == b;
    }
    public bool AreNotEqual(int a, int b)
    {
        return a != b;
    }
    public bool IsGreater(int a, int b)
    {
        return a > b;
    }
    public bool IsLesser(int a, int b)
    {
        return a < b;
    }
    public bool IsGreaterOrEqual(int a, int b)
    {
        return a >= b;
    }
    public bool IsLesserOrEqual(int a, int b)
    {
        return a <= b;
    }
}