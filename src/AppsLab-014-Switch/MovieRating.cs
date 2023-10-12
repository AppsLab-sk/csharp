using System.ComponentModel;

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
        switch(rating) 
        {
            case 1:
                return "Veľmi zlý";
                break;
            case 2:
                return "Zlý";
                break;
            case 3:
                return "Priemerný";
                break;
            case 4:
                return "Dobrý";
                break;
            case 5:
                return "Výborný";
                break;
            default:
                return "Neplatné hodnotenie";
                    break;


        } 
    }
}