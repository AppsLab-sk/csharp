namespace AppsLab_009_Operators.Tests;

/// <summary>
/// This class contains unit tests for the Calculator class.
/// </summary>
public class CalculatorTests
{
    private Calculator _calculator;

    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator();
    }

    /// <summary>
    /// This test verifies that the Add method returns the correct sum.
    /// </summary>
    [Test]
    public void Add_WhenCalled_ReturnsSum()
    {
        var result = _calculator.Add(5, 3);
        Assert.That(result, Is.EqualTo(8), "Add method returns incorrect value");
    }

    /// <summary>
    /// This test verifies that the Subtract method returns the correct difference.
    /// </summary>
    [Test]
    public void Subtract_WhenCalled_ReturnsDifference()
    {
        var result = _calculator.Subtract(5, 3);
        Assert.That(result, Is.EqualTo(2), "Subtract method returns incorrect value");
    }

    /// <summary>
    /// This test verifies that the Multiply method returns the correct product.
    /// </summary>
    [Test]
    public void Multiply_WhenCalled_ReturnsProduct()
    {
        var result = _calculator.Multiply(5, 3);
        Assert.That(result, Is.EqualTo(15), "Multiply method returns incorrect value");
    }

    /// <summary>
    /// This test verifies that the Divide method returns the correct quotient.
    /// </summary>
    [Test]
    public void Divide_WhenCalled_ReturnsQuotient()
    {
        var result = _calculator.Divide(5, 3);
        Assert.That(result, Is.EqualTo((double)5/3), "Divide method returns incorrect value");
    }

    /// <summary>
    /// This test verifies that the Remainder method returns the correct remainder.
    /// </summary>
    [Test]
    public void Remainder_WhenCalled_ReturnsRemainder()
    {
        var result = _calculator.Remainder(5, 3);
        Assert.That(result, Is.EqualTo(2), "Remainder method returns incorrect value");
    }

    /// <summary>
    /// This test verifies that the AreEqual method returns true when the numbers are equal.
    /// </summary>
    [Test]
    public void AreEqual_WhenCalled_ReturnsCorrectResult()
    {
        var result = _calculator.AreEqual(5, 5);
        Assert.That(result, Is.True, "AreEqual method returns incorrect value");
    }

    /// <summary>
    /// This test verifies that the AreNotEqual method returns true when the numbers are not equal.
    /// </summary>
    [Test]
    public void AreNotEqual_WhenCalled_ReturnsCorrectResult()
    {
        var result = _calculator.AreNotEqual(5, 3);
        Assert.That(result, Is.True, "AreNotEqual method returns incorrect value");
    }

    /// <summary>
    /// This test verifies that the IsGreater method returns true when the first number is greater than the second number.
    /// </summary>
    [Test]
    public void IsGreater_WhenCalled_ReturnsCorrectResult()
    {
        var result = _calculator.IsGreater(5, 3);
        Assert.That(result, Is.True, "IsGreater method returns incorrect value");
    }

    /// <summary>
    /// This test verifies that the IsLesser method returns true when the first number is lesser than the second number.
    /// </summary>
    [Test]
    public void IsLesser_WhenCalled_ReturnsCorrectResult()
    {
        var result = _calculator.IsLesser(3, 5);
        Assert.That(result, Is.True, "IsLesser method returns incorrect value");
    }

    /// <summary>
    /// This test verifies that the IsGreaterOrEqual method returns true when the first number is greater than or equal to the second number.
    /// </summary>
    [Test]
    public void IsGreaterOrEqual_WhenCalled_ReturnsCorrectResult()
    {
        var result = _calculator.IsGreaterOrEqual(5, 5);
        Assert.That(result, Is.True, "IsGreaterOrEqual method returns incorrect value");
    }

    /// <summary>
    /// This test verifies that the IsLesserOrEqual method returns true when the first number is lesser than or equal to the second number.
    /// </summary>
    [Test]
    public void IsLesserOrEqual_WhenCalled_ReturnsCorrectResult()
    {
        var result = _calculator.IsLesserOrEqual(3, 3);
        Assert.That(result, Is.True, "IsLesserOrEqual method returns incorrect value");
    }
}