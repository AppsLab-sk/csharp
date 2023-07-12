namespace AppsLab_012_Boolean.Tests;

/// <summary>
/// Provides unit tests for the <see cref="BooleanLogic"/> class.
/// </summary>
[TestFixture]
public class BooleanLogicTests
{
    private BooleanLogic booleanLogic;

    [SetUp]
    public void SetUp()
    {
        booleanLogic = new BooleanLogic();
    }

    /// <summary>
    /// Tests the <see cref="BooleanLogic.And"/> method with true and true values.
    /// </summary>
    [Test]
    public void And_TrueAndTrue_ReturnsTrue()
    {
        bool result = booleanLogic.And(true, true);
        Assert.That(result, Is.True, "AND operation with true and true should return true.");
    }

    /// <summary>
    /// Tests the <see cref="BooleanLogic.And"/> method with true and false values.
    /// </summary>
    [Test]
    public void And_TrueAndFalse_ReturnsFalse()
    {
        bool result = booleanLogic.And(true, false);
        Assert.That(result, Is.False, "AND operation with true and false should return false.");
    }

    /// <summary>
    /// Tests the <see cref="BooleanLogic.Or"/> method with true and false values.
    /// </summary>
    [Test]
    public void Or_TrueAndFalse_ReturnsTrue()
    {
        bool result = booleanLogic.Or(true, false);
        Assert.That(result, Is.True, "OR operation with true and false should return true.");
    }

    /// <summary>
    /// Tests the <see cref="BooleanLogic.Or"/> method with false and false values.
    /// </summary>
    [Test]
    public void Or_FalseAndFalse_ReturnsFalse()
    {
        bool result = booleanLogic.Or(false, false);
        Assert.That(result, Is.False, "OR operation with false and false should return false.");
    }

    /// <summary>
    /// Tests the <see cref="BooleanLogic.Not"/> method with true value.
    /// </summary>
    [Test]
    public void Not_True_ReturnsFalse()
    {
        bool result = booleanLogic.Not(true);
        Assert.That(result, Is.False, "NOT operation with true should return false.");
    }

    /// <summary>
    /// Tests the <see cref="BooleanLogic.Not"/> method with false value.
    /// </summary>
    [Test]
    public void Not_False_ReturnsTrue()
    {
        bool result = booleanLogic.Not(false);
        Assert.That(result, Is.True, "NOT operation with false should return true.");
    }
}