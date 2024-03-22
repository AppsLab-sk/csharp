namespace AppsLab_014_Switch.Tests;

public class MovieRatingTests
{
    private MovieRating _movieRating;

    [SetUp]
    public void Setup()
    {
        _movieRating = new MovieRating();
    }

    [Test]
    public void GetRatingDescription_WithRating1_ReturnsVelmiZly()
    {
        string description = MovieRating.GetRatingDescription(1);
        Assert.That(description, Is.EqualTo("Veľmi zlý"), "Expected 'Veľmi zlý' for rating 1");
    }

    [Test]
    public void GetRatingDescription_WithRating2_ReturnsZly()
    {
        string description = MovieRating.GetRatingDescription(2);
        Assert.That(description, Is.EqualTo("Zlý"), "Expected 'Zlý' for rating 2");
    }

    [Test]
    public void GetRatingDescription_WithRating3_ReturnsPriemerny()
    {
        string description = MovieRating.GetRatingDescription(3);
        Assert.That(description, Is.EqualTo("Priemerný"), "Expected 'Priemerný' for rating 3");
    }

    [Test]
    public void GetRatingDescription_WithRating4_ReturnsDobry()
    {
        string description = MovieRating.GetRatingDescription(4);
        Assert.That(description, Is.EqualTo("Dobrý"), "Expected 'Dobrý' for rating 4");
    }

    [Test]
    public void GetRatingDescription_WithRating5_ReturnsVyborny()
    {
        string description = MovieRating.GetRatingDescription(5);
        Assert.That(description, Is.EqualTo("Výborný"), "Expected 'Výborný' for rating 5");
    }

    [Test]
    public void GetRatingDescription_WithInvalidRating_ReturnsInvalidRating()
    {
        string description = MovieRating.GetRatingDescription(6);
        Assert.That(description, Is.EqualTo("Neplatné hodnotenie"), "Expected 'Neplatné hodnotenie' for invalid rating");
    }
}