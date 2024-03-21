    using System.ComponentModel.Design;
    using System.Runtime.InteropServices;
    using System.Security.Cryptography.X509Certificates;
    using System.Xml;

    namespace AppsLab_013_Conditions;
 
        public class GameRules
        {

            public bool CanPlayerEnterGame(string playerName, int playerAge)
            {
                if (playerName == string.Empty)
                    return false;
                if (playerName == null)
                {
                    Console.WriteLine("You can not enter the game");
                    return false;
                }

                else
                {
                    Console.WriteLine("You can enter the game");

                }
                if (playerAge >= 15)
                {
                    Console.WriteLine("You can enter the game.");
                    return true;
                }
                else
                {
                    Console.WriteLine("You can not enter the game");
                    return false;
                }
            }

            public bool IsGameOver(int playerHealth)
            {
                if (playerHealth <= 0)
                {
                    Console.WriteLine("GAME OVER");
                    return true;
                }
                else
                {
                    Console.WriteLine("You are alive");
                    return false;
                }
            }
            public bool ShouldOpenSecretDoor(bool hasKey, bool knowsPassword)
            {
                if (hasKey && knowsPassword) 
                    return true;
                else 
                    return false;
            }
        }
