namespace AppsLab_019_MethodsOverloading.Tests;

public class PasswordGeneratorTests
{
    private PasswordGenerator _generator;

    [SetUp]
    public void Setup()
    {
        _generator = new PasswordGenerator();
    }
    /*
    [Test]
    public void GeneratePassword_DefaultLength_ShouldReturnEightCharactersLong()
    {
        string password = _generator.GeneratePassword();
        Assert.That(password.Length, Is.EqualTo(8), "The password does not have the expected length of 8 characters.");
    }

    [Test]
    public void GeneratePassword_CustomLength_ShouldReturnCorrectLength()
    {
        int length = 12;
        string password = _generator.GeneratePassword(length);
        Assert.That(password.Length, Is.EqualTo(length), "The password does not have the expected length of 12 characters.");
    }

    [Test]
    public void GeneratePassword_WithSpecialChars_ShouldContainSpecialChars()
    {
        string password = _generator.GeneratePassword(15, true, false);
        Assert.That(password.Any(c => "!@#$%^&*()".Contains(c)), "The password does not contain any special characters.");
    }

    [Test]
    public void GeneratePassword_WithNumbers_ShouldContainNumbers()
    {
        string password = _generator.GeneratePassword(15, false, true);
        Assert.That(password.Any(char.IsDigit), "The password does not contain any numeric characters.");
    }*/
}
