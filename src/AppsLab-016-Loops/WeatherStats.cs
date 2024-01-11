using System.Diagnostics.CodeAnalysis;

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
        double sum = 0;

        foreach (var temperature in temperatures)
        {
            sum += temperature;
        }
        return sum / (double)temperatures.Length;
    }

    /// <summary>
    /// Find the maximum temperature from the provided values.
    /// </summary>
    /// <param name="temperatures">Array of temperatures.</param>
    /// <returns>Maximum temperature.</returns>
    public double MaxTemperature(double[] temperatures)
    {
        double max = double.MinValue;
        foreach (double temperature in temperatures)
        {
            if (max <= temperature)
                max = temperature;
        }
        return max;
    }

    /// <summary>
    /// Find the minimum temperature from the provided values.
    /// </summary>
    /// <param name="temperatures">Array of temperatures.</param>
    /// <returns>Minimum temperature.</returns>
    public double MinTemperature(double[] temperatures)
    {
        double min = double.MaxValue;
        foreach (double temperature in temperatures)
        {
            if (min >= temperature)
                min = temperature;
        }
        return min;
    }
}




