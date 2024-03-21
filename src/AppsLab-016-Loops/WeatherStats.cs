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
        foreach (double temperature in temperatures)
        {
            sum += temperature; 
        }

        return sum /(double)temperatures.Length;
    }
    /// <summary>
    /// Find the maximum temperature from the provided values.
    /// </summary>
    /// <param name="temperatures">Array of temperatures.</param>
    /// <returns>Maximum temperature.</returns>
    public double MaxTemperature(double[] temperatures)
    {
        double[] doubleArray = temperatures;
        int[] numbers = doubleArray.Select(d => (int)d).ToArray();
        return temperatures.Max();
    }

    /// <summary>
    /// Find the minimum temperature from the provided values.
    /// </summary>
    /// <param name="temperatures">Array of temperatures.</param>
    /// <returns>Minimum temperature.</returns>
    public double MinTemperature(double[] temperatures)
    {
        double[] doubleArray = temperatures;
        int[] numbers = doubleArray.Select(d=> (int)d).ToArray();
        return temperatures.Min();
    
    }
}
