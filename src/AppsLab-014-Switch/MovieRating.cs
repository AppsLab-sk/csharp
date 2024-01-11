using System;

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
                Console.WriteLine("Veľmi zlý");
                break;
            case 2:
                Console.WriteLine("Zlý");
                break;
            case 3:
                Console.WriteLine("Priemerný");
                break;
            case 4:
                Console.WriteLine("Dobrý");
                break;
            case 5:
                Console.WriteLine("Výborný");
                break;
                
        }
        return GetRatingDescription(rating);    
    }
}