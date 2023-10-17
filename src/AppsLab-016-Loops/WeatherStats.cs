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
        double[] t = temperatures;
        double sum = 0;
        for (int i = 0; i < t.Length; i++)
        {
            sum += t[i];
        }

        double average = (double)sum / t.Length;
        return average;
       

    }

    /// <summary>
    /// Find the maximum temperature from the provided values.
    /// </summary>
    /// <param name="temperatures">Array of temperatures.</param>
    /// <returns>Maximum temperature.</returns>
    public double MaxTemperature(double[] temperatures)
    {
        double[] temp = temperatures;
        double max = temp.Max();
        return max;


    }

    /// <summary>
    /// Find the minimum temperature from the provided values.
    /// </summary>
    /// <param name="temperatures">Array of temperatures.</param>
    /// <returns>Minimum temperature.</returns>
    public double MinTemperature(double[] temperatures)
    {
        double[] temp = temperatures;
        double min = temp.Min();
        return min;
    }
}
