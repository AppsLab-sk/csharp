namespace AppsLab_016_Loops.Tests;

/// <summary>
/// Tests for the WeatherStats class.
/// </summary>
public class WeatherStatsTests
{
    private WeatherStats _weatherStats;

    /// <summary>
    /// Setup the test.
    /// </summary>
    [SetUp]
    public void Setup()
    {
        _weatherStats = new WeatherStats();
    }

    /// <summary>
    /// Test the AverageTemperature method.
    /// </summary>
    [Test]
    public void AverageTemperature_CorrectAverage_ReturnsTrue()
    {
        var temperatures = new double[] {20, 25, 30, 35, 40};
        var result = _weatherStats.AverageTemperature(temperatures);
        Assert.That(result, Is.EqualTo(30), "The average temperature is not calculated correctly.");
    }

    /// <summary>
    /// Test the MaxTemperature method.
    /// </summary>
    [Test]
    public void MaxTemperature_MaxInArray_ReturnsTrue()
    {
        var temperatures = new double[] {20, 25, 30, 35, 40};
        var result = _weatherStats.MaxTemperature(temperatures);
        Assert.That(result, Is.EqualTo(40), "The maximum temperature is not calculated correctly.");
    }

    /// <summary>
    /// Test the MinTemperature method.
    /// </summary>
    [Test]
    public void MinTemperature_MinInArray_ReturnsTrue()
    {
        var temperatures = new double[] {20, 25, 30, 35, 40};
        var result = _weatherStats.MinTemperature(temperatures);
        Assert.That(result, Is.EqualTo(20), "The minimum temperature is not calculated correctly.");
    }
}
