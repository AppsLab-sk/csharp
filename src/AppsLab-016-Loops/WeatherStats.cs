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
        double avarage = 0;
        foreach (var temperature in temperatures)
        {
            avarage += temperature;
        }
        avarage /= temperatures.Length;
        return avarage;
    }

    /// <summary>
    /// Find the maximum temperature from the provided values.
    /// </summary>
    /// <param name="temperatures">Array of temperatures.</param>
    /// <returns>Maximum temperature.</returns>
    public static MaxTemperature(double[] temperatures)
    {
        {
            double maximum = double.MinValue;
            foreach (double temperature in temperatures)
            {
                if (temperature > maximum)
                {
                    maximum = temperature;
                }
            }
        }
    }

    /// <summary>
    /// Find the minimum temperature from the provided values.
    /// </summary>
    /// <param name="temperatures">Array of temperatures.</param>
    /// <returns>Minimum temperature.</returns>
    public double MinTemperature(double[] temperatures)
    {
        double Maximum = double.MaxValue;
        foreach (double temperature in temperatures)
        {
            if (temperature < Maximum)
            {
                Maximum = temperature;
            }
        }
        return Maximum;
    }
}
