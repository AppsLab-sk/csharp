namespace AppsLab_018_Methods;

/// <summary>
/// Represents an exercise that involves implementing the FizzBuzz game.
/// </summary>
public class Exercise
{
    public string FizzBuzz(int number)
    {
        if (number % 3 == 0 && number % 5 == 0) 
        {
            return "FizzBuzz";
        }
        if (number % 3 == 0)
        {
            return "Fizz";
        }
        if (number % 5 == 0)
        {
            return "Buzz";
        }
        else return number.ToString();
    }
}