namespace AppsLab_001_StartHere.Tests;

/// <summary>
/// Contains unit tests for the <see cref="Greetings"/> class.
/// </summary>
public class GreetingsTests
{
    /// <summary>
    /// Tests the Hello method of the Greetings class by checking if it returns "Hello AppsLab!".
    /// </summary>
    [Test]
    public void HelloAppsLab()
    {
        var result = new Greetings().Hello();
        Assert.That(result, Is.EqualTo("Hello AppsLab!"));
    }
}