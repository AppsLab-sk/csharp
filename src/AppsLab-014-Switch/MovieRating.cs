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
        string MovieRating = "";
        switch (rating)
        {
            case 1:
                MovieRating = "Veľmi zlý";
                Console.WriteLine(MovieRating);
                break;
                case 2:
                MovieRating = "Zlý";
                Console.WriteLine(MovieRating);
                break;
                case 3:
                MovieRating = "Priemerný";
                Console.WriteLine(MovieRating);
                break;
                case 4:
                MovieRating = "Dobrý";
                Console.WriteLine(MovieRating);
                break;
                case 5:
                MovieRating = "Výborný";
                Console.WriteLine(MovieRating);
                break;
        }
        return MovieRating;
    }
}