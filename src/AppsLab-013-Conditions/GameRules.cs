using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace AppsLab_013_Conditions;

/// <summary>
/// Represents the rules of a game.
/// </summary>
public class GameRules
{
    /// <summary>
    /// Determines whether a player can enter the game based on their name and age.
    /// </summary>
    /// <param name="playerName">The name of the player.</param>
    /// <param name="playerAge">The age of the player.</param>
    /// <returns>True if the player can enter the game, false otherwise.</returns>
    public bool CanPlayerEnterGame(string playerName, int playerAge)
    {
        int age = 20;
        if (age > 18)
            Console.WriteLine("You Are An Adult.");
    
            else 
            Console.WriteLine("You are not an adult");
        {
            
        }
        return false;
    }

    /// <summary>
    /// Determines whether the game is over based on the player's health.
    /// </summary>
    /// <param name="playerHealth">The health of the player.</param>
    /// <returns>True if the game is over, false otherwise.</returns>
    public bool IsGameOver(int playerHealth)
    {
        int Health = 100;
        if (Health < 100);
            Console.WriteLine("Game is over.");
        return false;
        
        
    }

    /// <summary>
    /// Determines whether the secret door should be opened based on whether the player has the key and knows the password.
    /// </summary>
    /// <param name="hasKey">Whether the player has the key.</param>
    /// <param name="knowsPassword">Whether the player knows the password.</param>
    /// <returns>True if the secret door should be opened, false otherwise.</returns>
    public bool ShouldOpenSecretDoor(bool hasKey, bool knowsPassword)
    {
        
        if (hasKey = false);
        Console.WriteLine("Cant open secret door! Find the key!");
        if (knowsPassword = false) ;
         Console.WriteLine("Cant open secret door! Find the password!");
        return true;

    }
}