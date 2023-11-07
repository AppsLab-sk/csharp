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
        var result = "";
        var isDivisibleByThree = number % 3 == 0;
        var isDivisibleByFive = number % 5 == 0;

        if (isDivisibleByThree)
            result += "Fizz";

        if (isDivisibleByFive)
            result += "Buzz";

        if (!isDivisibleByThree && !isDivisibleByFive)
            result = number + "";

        return result;
        

    }
}