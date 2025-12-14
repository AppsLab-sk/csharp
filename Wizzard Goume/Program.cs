using System;
using System.Text;

int round = 1;
int roundF = 0;

decimal PlayerHealth = 100;

decimal EnemyDamage = 10; // 10
int EnemyHealth = 50;

int enemyBackappHealth = 50;
int enemyBackappDamage = 10;

string[] OneTimeUseItems = { "Double damage potion", "HP potion" };

bool ThePotionThingIsHappeningSoShutUp = false;

List<string> PlayerOneTimeUseItems = new List<string>();


while (round < 100000)
{
    

    int PlayerDamage = 30;
    
    int PlayerMaxHealth = 100;

    if (round % 5 == 0)
    {
        if (ThePotionThingIsHappeningSoShutUp == false)
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




    if (round > 1)
    {
        EnemyHealth = (int)(EnemyHealth * 1.05); // 5% more
        enemyBackappHealth = EnemyHealth;
        EnemyDamage = EnemyDamage * 1.05m;
        enemyBackappDamage = (int)EnemyDamage;
    }

    bool PoisonSkip = false;
    if (PoisonSkip != true)
    {
        Console.WriteLine("--------------\nThe Round Started, do you want to use a potion?  (y/n) (n = enter...don't ask why)");
        string? PlayersPoisonDicision = Console.ReadLine();
        if (PlayersPoisonDicision == "y")
        {
            if (PlayerOneTimeUseItems.Count > 0)
            {
                Console.WriteLine("Which potion do you want to use? (heal/damage), pressing enter makes you skip this and just go to the round.");
                string? PlayersPoisonType = Console.ReadLine();
                if (PlayersPoisonType == "heal")
                {
                    if (PlayerOneTimeUseItems.Contains("HP potion"))
                    {
                        PlayerOneTimeUseItems.Remove("HP potion");
                        PlayerHealth = PlayerHealth * 2;
                        PlayerHealth = PlayerHealth * 2;
                    }
                    else
                    {
                        Console.WriteLine("You don't have that potion, dummy");
                        PoisonSkip = true;
                        ThePotionThingIsHappeningSoShutUp = true;
                        continue;
                    }

                }
                else if (PlayersPoisonType == "damage")
                {
                    if (PlayerOneTimeUseItems.Contains("Double damage potion"))
                    {
                        PlayerOneTimeUseItems.Remove("Double damage potion");
                        PlayerDamage = PlayerDamage * 2;
                    }
                    else
                    {
                        Console.WriteLine("You don't have that poison, dummy");
                        PoisonSkip = true;
                        ThePotionThingIsHappeningSoShutUp = true;
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
                Console.WriteLine("You don't have a potion, dummy");
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




    Console.WriteLine("-----------------\nA Skeleton has appeared out of nowhere");
       

    roundF = 0;
    while (roundF < 10000)

    {
        PlayerHealth = PlayerHealth - EnemyDamage;
        Console.WriteLine($"The skeleton hit you, dealing {EnemyDamage} damage \n");

         if (PlayerHealth <= 0)
        {
            Console.WriteLine("---------------\nYou're dead :/");
            Console.WriteLine($"You've won {round - 1} games");
            round = 100000;
            break;
        }

        Console.WriteLine($"Skeleton Health: {EnemyHealth}");
        Console.WriteLine($"Your Health: {PlayerHealth}");
        Console.WriteLine("Press enter to fight back");
        string? PlayerAcion = Console.ReadLine();
        



        switch (PlayerAcion)
        {
             
            case "":
                EnemyHealth = EnemyHealth - PlayerDamage;
                Console.WriteLine($"You dealt {PlayerDamage} damage to the Skeleton");
                break;

            default:
                Console.WriteLine("You hesitated and lost your turn");
                break;
        }

        if (EnemyHealth <= 0)
        {
            Console.WriteLine("\nYou have defeated the Skeleton!");
            roundF = 10000;
            if (PlayerHealth <= PlayerMaxHealth)
            {
                PlayerHealth = PlayerHealth * 2;
                if (PlayerHealth > PlayerMaxHealth)
                {
                    PlayerHealth = PlayerMaxHealth;
                }

            }
            else if (PlayerHealth > PlayerMaxHealth)
            {
                PlayerHealth = PlayerMaxHealth;
            }
            Console.WriteLine($"Your hp is {PlayerHealth}");
            Console.WriteLine($"the {round}th round has ended");
        }

       



        roundF++;



    }
    EnemyHealth = enemyBackappHealth;

    round++;
}

//  Praca Mareka Mahúta a Michala Cvengroša