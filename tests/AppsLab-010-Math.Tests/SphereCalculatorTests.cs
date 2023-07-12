namespace AppsLab_010_Math.Tests;

/// <summary>
/// Tests for <see cref="SphereCalculator"/>.
/// </summary>
public class SphereCalculatorTests
{
    // Tolerance for floating point comparison
    private const double Delta = 0.0001;

    /// <summary>
    /// Tests the sphere calculations.
    /// </summary>
    [Test]
    [TestCase(1, 4.1888, 12.5664)]
    [TestCase(2, 33.5103, 50.2655)]
    [TestCase(3, 113.0973, 113.0973)]
    public void TestSphereCalculations(double radius, double expectedVolume, double expectedSurface)
    {
        // Arrange
        SphereCalculator calculator = new();

        // Act
        double volume = calculator.CalculateVolume(radius);
        double surface = calculator.CalculateSurface(radius);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(volume, Is.EqualTo(expectedVolume).Within(Delta), "Volume does not match expected value.");
            Assert.That(surface, Is.EqualTo(expectedSurface).Within(Delta), "Surface does not match expected value.");
        });
    }
}
