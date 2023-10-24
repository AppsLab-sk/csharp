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
        {
            string description;

            switch (rating)
            {
                case 1:
                    description = "Veľmi zlý";
                    break;
                case 2:
                    description = "Zlý";
                    break;
                case 3:
                    description = "Priemerný";
                    break;
                case 4:
                    description = "Dobrý";
                    break;
                case 5:
                    description = "Výborný";
                    break;
                default:
                    description = "Neplatné hodnotenie";
                    break;
            }

            return description;
        }
    }
}
    
