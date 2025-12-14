using System;
using System.Numerics;
using System.Xml.Serialization;

int round = 1;
int roundF = 0;

decimal PlayerHp = 100;

int EnemyHp = 50;
decimal EnemyDmg = 5;
    
    
    
   
int enemyBackappHp = 50;
decimal enemyBackappDmg = 5;

string[] OneTimeUseItems = { "Double damage poison", "Double HP poison" };



Console.WriteLine("Note: If you can type in the console from a Console.ReadLine, don’t write anything — just press Enter \n");



bool ThePoisonThingIsHappeningSoShutUp = false;


List<string> PlayerOneTimeUseItems = new List<string>();

while (round < 1000000)
{
   


    //numbers.Add(string.Parse(vstup));
    if (round % 5 == 0) 
    {
        if (ThePoisonThingIsHappeningSoShutUp == false)
        {
            // pick a random item from OneTimeUseItems
            Random rand = new Random();
            int randomIndex = rand.Next(OneTimeUseItems.Length);

            PlayerOneTimeUseItems.Add(OneTimeUseItems[randomIndex]);
            Console.WriteLine($"You've received a {OneTimeUseItems[randomIndex]}!");
        }
        else
        {
            
        }
    }
   


    int PlayerMaxHp = 100;
    int PlayerDmg = 20;

    //--------------------------//

    //string? number1Text = Console.ReadLine();
    //decimal number1 = decimal.Parse(number1Text);
    //   if (round == 4)
   // {
        //Console.WriteLine(PlayerOneTimeUseItems.Count);
   // }
   //some sexy show case code ig?

    //--------------------------//

    if (round > 1)
    {
        EnemyHp = (int)(EnemyHp * 1.05); // 5% more
        enemyBackappHp = EnemyHp;
        EnemyDmg = EnemyDmg * 1.05m;
        enemyBackappDmg = EnemyDmg;
    }
    //--------------------------//
    bool PoisonSkip = false;
    if (PoisonSkip != true)
    {
        Console.WriteLine("The Round Started, do you want to use a poison?  (y/n) (n = enter...don't ask why)");
        string? PlayersPoisonDicision = Console.ReadLine();
        if (PlayersPoisonDicision == "y")
        {
            if (PlayerOneTimeUseItems.Count > 0)
            {
                Console.WriteLine("Which poison do you want to use? (heal/damage), pressing enter makes you skip this and just go to the round.");
                string? PlayersPoisonType = Console.ReadLine();
                if (PlayersPoisonType == "heal")
                {
                    if (PlayerOneTimeUseItems.Contains("Double HP poison"))
                    {
                        PlayerOneTimeUseItems.Remove("Double HP poison");
                        PlayerHp = PlayerHp * 2;
                        PlayerMaxHp = PlayerMaxHp * 2;
                    }
                    else
                    {
                        Console.WriteLine("You don't have that poison, dummy");
                        PoisonSkip = true;
                        ThePoisonThingIsHappeningSoShutUp = true;
                        continue;
                    }

                }
                else if (PlayersPoisonType == "damage")
                {
                    if (PlayerOneTimeUseItems.Contains("Double damage poison"))
                    {
                        PlayerOneTimeUseItems.Remove("Double damage poison");
                        PlayerDmg = PlayerDmg * 2;
                    }
                    else
                    {
                        Console.WriteLine("You don't have that poison, dummy");
                        PoisonSkip = true;
                        ThePoisonThingIsHappeningSoShutUp = true;
                        continue;
                    }
                        
                    
                }
                else if (PlayerOneTimeUseItems.Count == 0)
                {
                    PoisonSkip = true;
                    continue;
                }
            }
           else
            {
                Console.WriteLine("You don't have a poison, dummy");
                PoisonSkip = true;
                continue;
            }

        }
        else if (PlayersPoisonDicision == "n")
        {
            continue;
        }
    }
    else if (PoisonSkip == true)
    {
        continue;
    }
    else
    {
        continue;
    }
    


    if (PlayerMaxHp < PlayerHp)
    {
        PlayerHp = PlayerMaxHp;
    }

    Console.WriteLine($"A Enemy has appeared in front of you and it hit you, dealing {EnemyDmg} damage (Your hp {PlayerHp - EnemyDmg})");
    PlayerHp = PlayerHp - EnemyDmg;
    Console.WriteLine($"Press enter to deal {PlayerDmg} damage");
    while (roundF < 1000000)
    {

        
        string? PlayerDecision = Console.ReadLine();

        

        //the attack part
        if (PlayerDecision == "")
        {

            EnemyHp = EnemyHp - PlayerDmg;
            if (EnemyHp <= 0)
            {
                EnemyHp = 0;
                Console.WriteLine("You hit the Enemy and killed it! \n");
            }
            else
            {
                Console.WriteLine($"You hit the Enemy and their hp is now {EnemyHp} and it's their turn\n");
            }
               
        }
        // for testing 
        else if (PlayerDecision == "instaE")
        {
            EnemyHp = 0;
        }
        else if (PlayerDecision == "instaP")
        {
            PlayerHp = 0;
        }
        else
        {
            continue;
            // if you type anything else, it just skips your turn
        }

        // the enemy attack part
        if (EnemyHp != 0)
        {
            
            PlayerHp = PlayerHp - EnemyDmg;
            Console.WriteLine($"The enemy hit you (Your hp {PlayerHp}) \n");
        }

        decimal CurrentPlayerHp = PlayerHp;

        // this is the end/continue part
        if (PlayerHp <= 0)
        {
            Console.WriteLine("You are dead");
            Console.WriteLine($"You've Killed {round - 1} Enemies");
            roundF = 1000000;
            round = 1000000;
        }
        else if (EnemyHp <= 0)
        {
            
            PlayerHp = CurrentPlayerHp * 2;
            if (PlayerHp > PlayerMaxHp)
            {
                PlayerHp = PlayerMaxHp;
            }
            roundF = 1000000;
            Console.WriteLine($"Your hp is {PlayerHp}");
            Console.WriteLine("Next round!\n");
            

        }
        roundF++;
        
    }

    EnemyHp = enemyBackappHp;
    EnemyDmg = enemyBackappDmg;

    if (round < 1000000)
    {
        Console.WriteLine($"The {round}th round ended \n ----------------");
        roundF = 0;
    }
    

    round++;
}
