using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AppsLab_014_Switch;

/// <summary>
/// Provides methods for working with movie ratings.
/// </summary>
public class MovieRating
{
    /// <summary>
    /// Gets a description of the specified movie rating.
    /// </summary>
    /// <param name="rating">The movie rating to get a description for.</param>
    /// <returns>A string describing the specified movie rating.</returns>
    public string GetRatingDescription(int rating)
    {
        string numberDescription = rating switch
        {
            1 => "Veľmi zlý",
            2 => "Zlý",
            3 => "Priemerný",
            4 => "Dobrý",
            5 => "Výborný",
            _ => "Neplatné hodnotenie",

        }; 
        return numberDescription;
    }
}