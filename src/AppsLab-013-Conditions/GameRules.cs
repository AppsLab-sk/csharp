﻿using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

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
        int playerage = 16;
        if (playerage >= 18)
        {
            Console.WriteLine("You can enter the game.");
            return true;
        }
        
        string? playername = Console.ReadLine();
        if (playername == null)
        { return false; 
        
        }
        else
        {
            Console.WriteLine("Welcome " + playername + "!");
          return true;
        }
    }


    /// <summary>
    /// Determines whether the game is over based on the player's health.
    /// </summary>
    /// <param name="playerHealth">The health of the player.</param>
    /// <returns>True if the game is over, false otherwise.</returns>
    public bool IsGameOver(int playerHealth)
    {
        if (playerHealth <= 0)
        {
            return true;
        }
        else { return false; }
    }

    /// <summary>
    /// Determines whether the secret door should be opened based on whether the player has the key and knows the password.
    /// </summary>
    /// <param name="hasKey">Whether the player has the key.</param>
    /// <param name="knowsPassword">Whether the player knows the password.</param>
    /// <returns>True if the secret door should be opened, false otherwise.</returns>
    public bool ShouldOpenSecretDoor(bool hasKey, bool knowsPassword)
    {
        if (hasKey)
        {
            if (knowsPassword)
            {
                return true;
            }
            else { return false; }
        }
        else { return false; }
    }
}