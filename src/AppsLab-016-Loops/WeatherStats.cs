namespace AppsLab_016_Loops;

/// <summary>
/// Class to calculate weather statistics.
/// </summary>
public class WeatherStats
{
    /// <summary>
    /// Calculate the average temperature from the provided values.
    /// </summary>
    /// <param name="temperatures">Array of temperatures.</param>
    /// <returns>Average temperature.</returns>
    public static double AverageTemperature(double[] temperatures);
    

    /// <summary>
    /// Find the maximum temperature from the provided values.
    /// </summary>
    /// <param name="temperatures">Array of temperatures.</param>
    /// <returns>Maximum temperature.</returns>
    public double MaxTemperature(double[] temperatures)
    {
        double maximum = double .MaxValue;
        foreach (double temperature in temperatures)
        {
            if (temperature < maximum)
            {
                maximum = temperature;
            }
        }
        return maximum;
    }

    /// <summary>
    /// Find the minimum temperature from the provided values.
    /// </summary>
    /// <param name="temperatures">Array of temperatures.</param>
    /// <returns>Minimum temperature.</returns>
    public double MinTemperature(double[] temperatures)
    {
        double minimum = double.MaxValue;
        foreach (double temperature in temperatures)
        {
            if (temperature < minimum)
            {
                minimum = temperature;
            }
        }
        return minimum;
    }
}
