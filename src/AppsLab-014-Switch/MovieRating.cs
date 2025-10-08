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
        switch (rating)
        {
            case 1:
                return "Veľmi zlý";
            case 2:
                return "Zlý";
            case 3:
                return "Priemerný";
            case 4:
                return "Dobrý";
            case 5:
                return "Výborný";
            default:
                return "Neplatné hodnotenie";
        };

    }
}

