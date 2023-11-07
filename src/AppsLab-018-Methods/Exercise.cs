using System.Reflection.Metadata.Ecma335;
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
        if (number % 3 == 0 && number % 5 == 0)
        {
            return "FizzBuzz";
        }
        else if (number % 3 == 0)
        {
           return  "Fizz";
        }
        else if (number % 5 == 0)
        {
            return "Buzz";
        }
        else
        {
            return number.ToString ();
        }
    }
}