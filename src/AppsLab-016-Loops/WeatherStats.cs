using System.Reflection.Metadata.Ecma335;

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
    public double AverageTemperature(double[] temperatures)
    {
        double priemer = 0;
        foreach (double temperature in temperatures)
        {
            priemer += temperature;
        }
    
    return priemer / temperatures.Length;
    }

    /// <summary>
    /// Find the maximum temperature from the provided values.
    /// </summary>
    /// <param name="temperatures">Array of temperatures.</param>
    /// <returns>Maximum temperature.</returns>
    public double MaxTemperature(double[] temperatures)
    {
        double maximum = double.MinValue;
        foreach (double temperature in temperatures)
        {
            if (temperature > maximum)
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

