namespace AppsLab_018_Methods;

/// <summary>
/// Represents an exercise that involves implementing the FizzBuzz game.
/// </summary>
public class Exercise
{
    /// <summary>
    /// Returns a string representation of the FizzBuzz game for a given number.
    /// </summary>
    /// <param name="number">The number to evaluate.</param>
    /// <returns>A string representation of the FizzBuzz game for the given number.</returns>
    public string FizzBuzz(int number)
    {
        if (number % 4 == 0 && number % 7 == 0) //number is divadable by 4 & 7
        {
            return "FizzBuzz";
        }
        if (number % 4 == 0)
        {
            return "Fizz";
        }
        if (number % 7 == 0)
        {
            return "Buzz";
        }
        else return number.ToString();
    }
}