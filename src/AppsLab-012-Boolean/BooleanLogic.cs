namespace AppsLab_012_Boolean;

/// <summary>
/// Provides methods for performing boolean logic operations.
/// </summary>
public class BooleanLogic
{
    /// <summary>
    /// Performs a logical AND operation on two boolean values.
    /// </summary>
    /// <param name="a">The first boolean value.</param>
    /// <param name="b">The second boolean value.</param>
    /// <returns>The result of the logical AND operation.</returns>
    public bool And(bool a, bool b)
    {
        return a && b;
    }

    /// <summary>
    /// Performs a logical OR operation on two boolean values.
    /// </summary>
    /// <param name="a">The first boolean value.</param>
    /// <param name="b">The second boolean value.</param>
    /// <returns>The result of the logical OR operation.</returns>
    public bool Or(bool a, bool b)
    {
        return a || b;
        

    }

    /// <summary>
    /// Performs a logical NOT operation on a boolean value.
    /// </summary>
    /// <param name="a">The boolean value to negate.</param>
    /// <returns>The result of the logical NOT operation.</returns>
    public bool Not(bool a)
    {
        return !a;
        
    }
}