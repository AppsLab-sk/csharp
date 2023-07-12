namespace AppsLab_013_Conditions.Tests;

/// <summary>
/// Contains unit tests for the <see cref="GameRules"/> class.
/// </summary>
public class GameRulesTests
{
    private GameRules _gameRules;

    [SetUp]
    public void Setup()
    {
        _gameRules = new GameRules();
    }

    /// <summary>
    /// Tests the <see cref="GameRules.CanPlayerEnterGame"/> method when the player name is null.
    /// </summary>
    [Test]
    public void CanPlayerEnterGame_PlayerNameIsNull_ReturnsFalse()
    {
        // Arrange
        string? playerName = null;
        int playerAge = 20;

        // Act
        bool result = _gameRules.CanPlayerEnterGame(playerName!, playerAge);

        // Assert
        Assert.That(result, Is.False, "Player name is null, should return false");
    }

    /// <summary>
    /// Tests the <see cref="GameRules.CanPlayerEnterGame"/> method when the player name is empty.
    /// </summary>
    [Test]
    public void CanPlayerEnterGame_PlayerNameIsEmpty_ReturnsFalse()
    {
        // Arrange
        string playerName = "";
        int playerAge = 20;

        // Act
        bool result = _gameRules.CanPlayerEnterGame(playerName, playerAge);

        // Assert
        Assert.That(result, Is.False, "Player name is empty, should return false");
    }

    /// <summary>
    /// Tests the <see cref="GameRules.CanPlayerEnterGame"/> method when the player age is less than 15.
    /// </summary>
    [Test]
    public void CanPlayerEnterGame_PlayerAgeIsLessThan15_ReturnsFalse()
    {
        // Arrange
        string playerName = "John";
        int playerAge = 14;

        // Act
        bool result = _gameRules.CanPlayerEnterGame(playerName, playerAge);

        // Assert
        Assert.That(result, Is.False, "Player age is less than 15, should return false");
    }

    /// <summary>
    /// Tests the <see cref="GameRules.CanPlayerEnterGame"/> method when the player name and age are valid.
    /// </summary>
    [Test]
    public void CanPlayerEnterGame_PlayerNameAndAgeAreValid_ReturnsTrue()
    {
        // Arrange
        string playerName = "John";
        int playerAge = 20;

        // Act
        bool result = _gameRules.CanPlayerEnterGame(playerName, playerAge);

        // Assert
        Assert.That(result, Is.True, "Player name and age are valid, should return true");
    }

    /// <summary>
    /// Tests the <see cref="GameRules.IsGameOver"/> method when the player health is zero.
    /// </summary>
    [Test]
    public void IsGameOver_PlayerHealthIsZero_ReturnsTrue()
    {
        // Arrange
        int playerHealth = 0;

        // Act
        bool result = _gameRules.IsGameOver(playerHealth);

        // Assert
        Assert.That(result, Is.True, "Player health is zero, should return true");
    }

    /// <summary>
    /// Tests the <see cref="GameRules.IsGameOver"/> method when the player health is greater than zero.
    /// </summary>
    [Test]
    public void IsGameOver_PlayerHealthIsGreaterThanZero_ReturnsFalse()
    {
        // Arrange
        int playerHealth = 10;

        // Act
        bool result = _gameRules.IsGameOver(playerHealth);

        // Assert
        Assert.That(result, Is.False, "Player health is greater than zero, should return false");
    }

    /// <summary>
    /// Tests the <see cref="GameRules.ShouldOpenSecretDoor"/> method when the player has the key and knows the password.
    /// </summary>
    [Test]
    public void ShouldOpenSecretDoor_PlayerHasKeyAndKnowsPassword_ReturnsTrue()
    {
        // Arrange
        bool hasKey = true;
        bool knowsPassword = true;

        // Act
        bool result = _gameRules.ShouldOpenSecretDoor(hasKey, knowsPassword);

        // Assert
        Assert.That(result, Is.True, "Player has key and knows password, should return true");
    }

    /// <summary>
    /// Tests the <see cref="GameRules.ShouldOpenSecretDoor"/> method when the player does not have the key.
    /// </summary>
    [Test]
    public void ShouldOpenSecretDoor_PlayerDoesNotHaveKey_ReturnsFalse()
    {
        // Arrange
        bool hasKey = false;
        bool knowsPassword = true;

        // Act
        bool result = _gameRules.ShouldOpenSecretDoor(hasKey, knowsPassword);

        // Assert
        Assert.That(result, Is.False, "Player does not have key, should return false");
    }

    /// <summary>
    /// Tests the <see cref="GameRules.ShouldOpenSecretDoor"/> method when the player does not know the password.
    /// </summary>
    [Test]
    public void ShouldOpenSecretDoor_PlayerDoesNotKnowPassword_ReturnsFalse()
    {
        // Arrange
        bool hasKey = true;
        bool knowsPassword = false;

        // Act
        bool result = _gameRules.ShouldOpenSecretDoor(hasKey, knowsPassword);

        // Assert
        Assert.That(result, Is.False, "Player does not know password, should return false");
    }
}