namespace AppsLab_011_Strings.Tests;

using NUnit.Framework;

/// <summary>
/// Provides tests for the <see cref="StringManipulator"/> class.
/// </summary>
[TestFixture]
public class StringManipulatorTests
{
    private StringManipulator _stringManipulator;

    [SetUp]
    public void SetUp()
    {
        _stringManipulator = new StringManipulator();
    }

    /// <summary>
    /// Tests the <see cref="StringManipulator.AppendStrings"/> method.
    /// </summary>
    [Test]
    public void AppendStrings_AppendsCorrectly()
    {
        var result = _stringManipulator.AppendStrings("Hello", "World");
        Assert.That(result, Is.EqualTo("HelloWorld"), "The appended string is incorrect.");
    }

    /// <summary>
    /// Tests the <see cref="StringManipulator.ConvertToUpper"/> method.
    /// </summary>
    [Test]
    public void ConvertToUpper_ConvertsCorrectly()
    {
        var result = _stringManipulator.ConvertToUpper("hello");
        Assert.That(result, Is.EqualTo("HELLO"), "The converted string is incorrect.");
    }

    /// <summary>
    /// Tests the <see cref="StringManipulator.ConvertToLower"/> method.
    /// </summary>
    [Test]
    public void ConvertToLower_ConvertsCorrectly()
    {
        var result = _stringManipulator.ConvertToLower("HELLO");
        Assert.That(result, Is.EqualTo("hello"), "The converted string is incorrect.");
    }

    /// <summary>
    /// Tests the <see cref="StringManipulator.ContainsSubstring"/> method.
    /// </summary>
    [Test]
    public void ContainsSubstring_FindsSubstring()
    {
        var result = _stringManipulator.ContainsSubstring("Hello World", "World");
        Assert.That(result, Is.True, "The substring was not found.");
    }

    /// <summary>
    /// Tests the <see cref="StringManipulator.ContainsSubstring"/> method.
    /// </summary>
    [Test]
    public void ContainsSubstring_DoesNotFindSubstring()
    {
        var result = _stringManipulator.ContainsSubstring("Hello World", "Goodbye");
        Assert.That(result, Is.False, "The substring was found when it should not have been.");
    }

    /// <summary>
    /// Tests the <see cref="StringManipulator.StartsWithSubstring"/> method.
    /// </summary>
    [Test]
    public void StartsWithSubstring_StartsWithSubstring()
    {
        var result = _stringManipulator.StartsWithSubstring("Hello World", "Hello");
        Assert.That(result, Is.True, "The string does not start with the substring.");
    }

    /// <summary>
    /// Tests the <see cref="StringManipulator.StartsWithSubstring"/> method.
    /// </summary>
    [Test]
    public void StartsWithSubstring_DoesNotStartWithSubstring()
    {
        var result = _stringManipulator.StartsWithSubstring("Hello World", "Goodbye");
        Assert.That(result, Is.False, "The string starts with the substring when it should not.");
    }
}